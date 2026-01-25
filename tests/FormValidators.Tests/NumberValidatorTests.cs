using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class NumberValidatorTests {
    [TestCase(null, true, true)]
    [TestCase("", true, true)]
    [TestCase(" ", true, true)]
    [TestCase("0", true, true)]
    [TestCase("1", true, true)]
    [TestCase("-1", true, true)]
    [TestCase("1.1", true, true)]
    [TestCase("1,000.1", true, true)]
    [TestCase("1,000.1", false, false)]
    [TestCase("string", true, false)]
    public void Validate_WithVariousInputs_ReturnsExpectedResult(string value, bool allowedThousands, bool isValid) {
        NumberValidator validator = new NumberValidator("", value, allowedThousands);
        bool result = validator.Validate();
        Assert.That(result, Is.EqualTo(isValid));
    }

    [TestCase("3.1", 2.1, 4.1, true, true)]
    [TestCase("3.1", 3.1, 3.1, true, true)]
    [TestCase("3.1", 2.1, 2.1, true, false)]
    [TestCase("3.1", 4.1, 4.1, true, false)]
    [TestCase("3,000.1", 3000.1, 3000.1, true, true)]
    [TestCase("3,000.1", 3000.1, 3000.1, false, false)]
    public void Validate_WithRangeConstraints_ReturnsExpectedResult(string value, decimal min, decimal max, bool allowedThousands, bool isValid) {
        NumberValidator validator = new NumberValidator("", value, min, max, allowedThousands);
        bool result = validator.Validate();
        Assert.That(result, Is.EqualTo(isValid));
    }

    [TestCase("3.1", 2.1, true, true)]
    [TestCase("3.1", 3.1, true, true)]
    [TestCase("3.1", 4.1, true, false)]
    [TestCase("-2.1", -3.1, true, true)]
    [TestCase("-3.1", -3.1, true, true)]
    [TestCase("-4.1", -3.1, true, false)]
    [TestCase("3,000.1", 3000.1, true, true)]
    [TestCase("3,000.1", 3000.1, false, false)]
    public void Validate_WithMinConstraint_ReturnsExpectedResult(string value, decimal min, bool allowedThousands, bool isValid) {
        NumberValidator validator = new NumberValidator("", value, min, null, allowedThousands);
        bool result = validator.Validate();
        Assert.That(result, Is.EqualTo(isValid));
    }

    [TestCase("3.1", 4.1, true, true)]
    [TestCase("3.1", 3.1, true, true)]
    [TestCase("3.1", 2.1, true, false)]
    [TestCase("-4.1", -3.1, true, true)]
    [TestCase("-3.1", -3.1, true, true)]
    [TestCase("-2.1", -3.1, true, false)]
    [TestCase("3,000.1", 3000.1, true, true)]
    [TestCase("3,000.1", 3000.1, false, false)]
    public void Validate_WithMaxConstraint_ReturnsExpectedResult(string value, decimal max, bool allowedThousands, bool isValid) {
        NumberValidator validator = new NumberValidator("", value, null, max, allowedThousands);
        bool result = validator.Validate();
        Assert.That(result, Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "error";
        string expected = ErrorMessageProvider.ValueIsNumberAccessor(column, value);
        NumberValidator validator = new NumberValidator(column, value);
        validator.Validate();
        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "error";
        string expected = column + value;
        NumberValidator validator = new NumberValidator(column, value, false, (c, v, _, _) => c + v);
        validator.Validate();
        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMinConstraintFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "1.0";
        decimal min = 1.1m;
        string expected = ErrorMessageProvider.ValueGreaterOrEqualAccessor(column, value, min);
        NumberValidator validator = new NumberValidator(column, value, min, null);
        validator.Validate();
        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMinConstraintFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "1.0";
        decimal min = 1.1m;
        string expected = column + value + min;
        NumberValidator validator = new NumberValidator(
            column, value, min, null, false, (c, v, _min, _) => c + v + _min
        );
        validator.Validate();
        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMaxConstraintFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "1.1";
        decimal max = 0.1m;
        string expected = ErrorMessageProvider.ValueLessOrEqualAccessor(column, value, max);
        NumberValidator validator = new NumberValidator(column, value, null, max);
        validator.Validate();
        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMaxConstraintFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "1.1";
        decimal max = 0.1m;
        string expected = column + value + max;
        NumberValidator validator = new NumberValidator(column, value, null, max, false, (c, v, _, _max) => c + v + _max);
        validator.Validate();
        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenRangeConstraintFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "0.1";
        decimal min = 1.1m;
        decimal max = 2.1m;
        string expected = ErrorMessageProvider.ValueInRangeAccessor(column, value, min, max);
        NumberValidator validator = new NumberValidator(column, value, min, max);
        validator.Validate();
        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenRangeConstraintFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "0.1";
        decimal min = 1.1m;
        decimal max = 2.1m;
        string expected = column + value + min + max;
        NumberValidator validator = new NumberValidator(
            column, value, min, max, false, (c, v, _min, _max) => c + v + _min + _max
        );
        validator.Validate();
        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }
}
