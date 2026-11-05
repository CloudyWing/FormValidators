using System;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class ValueLengthValidatorTests {
    [TestCase("123", 0, true)]
    [TestCase("123", 3, true)]
    [TestCase("123", 4, false)]
    public void Validate_WithMinConstraint_ReturnsExpectedResult(string value, int min, bool isValid) {
        ValueLengthValidator validator = new("", value, min, 0);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [TestCase("123", 3, true)]
    [TestCase("123", 4, true)]
    [TestCase("123", 2, false)]
    public void Validate_WithMaxConstraint_ReturnsExpectedResult(string value, int max, bool isValid) {
        ValueLengthValidator validator = new("", value, 0, max);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [TestCase("123", 0, 3, true)]
    [TestCase("123", 2, 2, false)]
    [TestCase("123", 4, 4, false)]
    public void Validate_WithRangeConstraint_ReturnsExpectedResult(string value, int min, int max, bool isValid) {
        ValueLengthValidator validator = new("", value, min, max);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenRangeConstraintFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "123";
        int min = 1;
        int max = 1;
        string expected = ErrorMessageProvider.ValueLengthInRangeAccessor(column, value, min, max);

        ValueLengthValidator validator = new(column, value, min, max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "123";
        int min = 1;
        int max = 1;
        string expected = column + value + min + max;

        ValueLengthValidator validator = new(column, value, min, max, (c, v, _min, _max) => c + v + _min + _max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMinConstraintFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "123";
        int min = 4;
        string expected = ErrorMessageProvider.ValueLengthGreaterOrEqualAccessor(column, value, min);

        ValueLengthValidator validator = new(column, value, min, 0);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMinConstraintFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "123";
        int min = 4;
        string expected = column + value + min;

        ValueLengthValidator validator = new(column, value, min, 0, (c, v, _min, _) => c + v + _min);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMaxConstraintFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "123";
        int max = 2;
        string expected = ErrorMessageProvider.ValueLengthLessOrEqualAccessor(column, value, max);

        ValueLengthValidator validator = new(column, value, 0, max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMaxConstraintFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "123";
        int max = 2;
        string expected = column + value + max;

        ValueLengthValidator validator = new(column, value, max, (c, v, _, _max) => c + v + _max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void Constructor_MinGreaterThanMax_ThrowsArgumentException() {
        ArgumentException? exception = Assert.Throws<ArgumentException>(() => new ValueLengthValidator("", "123", 5, 3));

        Assert.That(exception?.ParamName, Is.EqualTo("min"));
    }

    [TestCase(5, 0)]
    [TestCase(5, -1)]
    [TestCase(3, 3)]
    public void Constructor_MaxIsUnlimitedOrEqual_DoesNotThrow(long min, long max) {
        Assert.DoesNotThrow(() => new ValueLengthValidator("", "123", min, max));
    }

    [Test]
    public void ValidationProviderLengthRange_MinGreaterThanMax_ThrowsArgumentExceptionWhenCreated() {
        ValidationProvider provider = new();
        Func<string, string?, ValueLengthValidator> creator = provider.LengthRange(5, 3);

        Assert.Throws<ArgumentException>(() => creator("", "123"));
    }

    [TestCase("😀😀", TextLengthUnit.Utf16CodeUnit, false)]
    [TestCase("😀😀", TextLengthUnit.UnicodeScalar, true)]
    [TestCase("😀😀", TextLengthUnit.TextElement, true)]
    [TestCase("éé", TextLengthUnit.UnicodeScalar, false)]
    [TestCase("éé", TextLengthUnit.TextElement, true)]
    [TestCase("ab", TextLengthUnit.UnicodeScalar, true)]
    public void Validate_WithMaxLengthAndUnit_CountsByUnit(string value, TextLengthUnit unit, bool isValid) {
        ValueLengthValidator validator = new("", value, 0, 2, unit);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void Validate_WithUnicodeScalarAndLoneSurrogate_CountsSurrogateAsOne() {
        ValueLengthValidator validator = new("", "a\ud800", 2, 2, TextLengthUnit.UnicodeScalar);

        Assert.That(validator.Validate(), Is.True);
    }

    [Test]
    public void Unit_WhenNotSpecified_IsUtf16CodeUnit() {
        ValueLengthValidator validator = new("", "123", 0, 3);

        Assert.That(validator.Unit, Is.EqualTo(TextLengthUnit.Utf16CodeUnit));
    }

    [Test]
    public void ErrorMessage_WithUnitAndCustomAccessor_ReturnsCustomMessage() {
        ValueLengthValidator validator = new("欄位", "😀😀😀", 0, 2, TextLengthUnit.UnicodeScalar, (c, v, min, max) => $"{c}:{min}-{max}");

        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("欄位:0-2"));
    }

    [Test]
    public void ValidationProviderLengthMethods_WithUnit_CreateValidatorWithUnit() {
        ValidationProvider provider = new();

        ValueLengthValidator min = provider.MinLength(2, TextLengthUnit.UnicodeScalar)("", "😀");
        ValueLengthValidator max = provider.MaxLength(1, TextLengthUnit.UnicodeScalar, "{0}")("欄位", "😀😀");
        ValueLengthValidator range = provider.LengthRange(1, 2, TextLengthUnit.TextElement, (c, v, _min, _max) => c)("欄位", "😀😀😀");

        using (Assert.EnterMultipleScope()) {
            Assert.That(min.Validate(), Is.False);
            Assert.That(min.MinLength, Is.EqualTo(2));
            Assert.That(max.Validate(), Is.False);
            Assert.That(max.ErrorMessage, Is.EqualTo("欄位"));
            Assert.That(range.Validate(), Is.False);
            Assert.That(range.Unit, Is.EqualTo(TextLengthUnit.TextElement));
        }
    }

    [Test]
    public void Constructor_WithUnitAndMinGreaterThanMax_ThrowsArgumentException() {
        Assert.Throws<ArgumentException>(() => new ValueLengthValidator("", "123", 5, 3, TextLengthUnit.TextElement));
    }
}
