using System;
using System.Collections.Generic;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class AllowedValuesValidatorTests {
    [TestCase(null, true)]
    [TestCase("", true)]
    [TestCase("A", true)]
    [TestCase("B", true)]
    [TestCase("a", false)]
    [TestCase("A ", false)]
    [TestCase("C", false)]
    public void Validate_WithDefaultComparison_IsCaseSensitive(string? value, bool isValid) {
        AllowedValuesValidator validator = new("", value, ["A", "B"]);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [TestCase("a", true)]
    [TestCase("b", true)]
    [TestCase("c", false)]
    public void Validate_WithOrdinalIgnoreCase_IgnoresCase(string value, bool isValid) {
        AllowedValuesValidator validator = new("", value, ["A", "B"], StringComparison.OrdinalIgnoreCase);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        AllowedValuesValidator validator = new("性別", "X", ["M", "F"]);

        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("「性別」必須為「M」、「F」其中之一。"));
    }

    [Test]
    public void ErrorMessage_WhenValidationFailsWithCustomAccessor_ReceivesAllowedValues() {
        AllowedValuesValidator validator = new("性別", "X", ["M", "F"], StringComparison.Ordinal, (c, v, values) => $"{c}:{v}:{string.Join("/", values)}");

        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("性別:X:M/F"));
    }

    [Test]
    public void ValidationProviderIn_WithParams_UsesOrdinalComparison() {
        ValidationProvider provider = new();

        AllowedValuesValidator validator = provider.In("Y", "N")("", "y");

        using (Assert.EnterMultipleScope()) {
            Assert.That(validator.Validate(), Is.False);
            Assert.That(validator.ComparisonType, Is.EqualTo(StringComparison.Ordinal));
            Assert.That(validator.AllowedValues, Is.EqualTo(new[] { "Y", "N" }));
        }
    }

    [Test]
    public void ValidationProviderIn_SourceChangedAfterCreated_KeepsOriginalValues() {
        ValidationProvider provider = new();
        List<string> values = ["Y"];
        Func<string, string?, AllowedValuesValidator> creator = provider.In(values, StringComparison.OrdinalIgnoreCase);

        values.Add("N");

        Assert.That(creator("", "n").Validate(), Is.False);
    }

    [Test]
    public void Constructor_NullAllowedValue_ThrowsArgumentException() {
        Assert.Throws<ArgumentException>(() => new AllowedValuesValidator("", "", ["A", null!]));
    }

    [Test]
    public void Constructor_NullAllowedValues_ThrowsArgumentNullException() {
        Assert.Throws<ArgumentNullException>(() => new AllowedValuesValidator("", "", null!));
    }
}
