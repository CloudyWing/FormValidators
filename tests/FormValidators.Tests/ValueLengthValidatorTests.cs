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
}
