using System;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class CustomValidatorTests {
    [TestCase(null, true)]
    [TestCase("", true)]
    [TestCase(" ", true)]
    [TestCase("abc", true)]
    [TestCase("ab", false)]
    public void Validate_WithLengthPredicate_ReturnsExpectedResult(string? value, bool isValid) {
        CustomValidator validator = new("", value, x => x.Length >= 3);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void Validate_EmptyValue_DoesNotCallPredicate() {
        bool isCalled = false;
        CustomValidator validator = new("", "", _ => isCalled = true);

        validator.Validate();

        Assert.That(isCalled, Is.False);
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        CustomValidator validator = new("欄位", "x", _ => false);

        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("「欄位」不符合規則。"));
    }

    [Test]
    public void ValidationProviderCustom_WithMessageFormat_ReturnsFormattedMessage() {
        ValidationProvider provider = new();

        CustomValidator validator = provider.Custom(x => x == "ok", "{0}必須為 ok，目前為 {1}")("欄位", "ng");
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("欄位必須為 ok，目前為 ng"));
    }

    [Test]
    public void Constructor_NullPredicate_ThrowsArgumentNullException() {
        Assert.Throws<ArgumentNullException>(() => new CustomValidator("", "", null!));
    }

    [Test]
    public void ValidationProviderCustom_NullPredicate_ThrowsArgumentNullException() {
        ValidationProvider provider = new();

        Assert.Throws<ArgumentNullException>(() => provider.Custom(null!));
    }
}
