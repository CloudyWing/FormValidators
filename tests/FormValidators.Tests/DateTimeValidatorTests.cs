using System;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class DateTimeValidatorTests {
    [TestCase(null, true)]
    [TestCase("", true)]
    [TestCase(" ", true)]
    [TestCase("1912/3/4", true)]
    [TestCase("1912/03/04", true)]
    [TestCase("1912/03/04 12:34", true)]
    [TestCase("1912/03/04 25:00", false)]
    [TestCase("1912/03/04 00:61", false)]
    [TestCase("1913/02/29 00:00", false)]
    [TestCase("error", false)]
    public void Validate_WithFormatCheck_ReturnsExpectedResult(string value, bool isValid) {
        DateTimeValidator validator = new DateTimeValidator("", value);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [TestCase("1912/3/2", true)]
    [TestCase("1912/3/3", true)]
    [TestCase("1912/3/1", false)]
    public void Validate_WithMinConstraint_ReturnsExpectedResult(string value, bool isValid) {
        DateTimeValidator validator = new DateTimeValidator("", value, new DateTime(1912, 3, 2), null);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [TestCase("1912/3/1", true)]
    [TestCase("1912/3/2", true)]
    [TestCase("1912/3/3", false)]
    public void Validate_WithMaxConstraint_ReturnsExpectedResult(string value, bool isValid) {
        DateTimeValidator validator = new DateTimeValidator("", value, null, new DateTime(1912, 3, 2));

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [TestCase("1912/3/2", true)]
    [TestCase("1912/3/3", true)]
    [TestCase("1912/3/4", true)]
    [TestCase("1912/3/1", false)]
    [TestCase("1912/3/5", false)]
    public void Validate_WithRangeConstraint_ReturnsExpectedResult(string value, bool isValid) {
        DateTimeValidator validator = new DateTimeValidator("", value, new DateTime(1912, 3, 2), new DateTime(1912, 3, 4));

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "error";
        string expected = ErrorMessageProvider.ValueIsDateTimeAccessor(column, value);

        DateTimeValidator validator = new DateTimeValidator(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "error";
        string expected = column + value;

        DateTimeValidator validator = new DateTimeValidator(column, value, (c, v, _, _) => c + v);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMinConstraintFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "1912/03/04";
        DateTime min = new DateTime(1912, 3, 5);
        string expected = ErrorMessageProvider.ValueGreaterOrEqualAccessor(column, value, min);

        DateTimeValidator validator = new DateTimeValidator(column, value, min, null);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMinConstraintFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "1912/03/04";
        DateTime min = new DateTime(1912, 3, 5);
        string expected = column + value + min;

        DateTimeValidator validator = new DateTimeValidator(column, value, min, null, (c, v, _min, _) => c + v + min);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMaxConstraintFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "1912/03/04";
        DateTime max = new DateTime(1912, 3, 3);
        string expected = ErrorMessageProvider.ValueLessOrEqualAccessor(column, value, max);

        DateTimeValidator validator = new DateTimeValidator(column, value, null, max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMaxConstraintFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "1912/03/04";
        DateTime max = new DateTime(1912, 3, 3);
        string expected = column + value + max;

        DateTimeValidator validator = new DateTimeValidator(column, value, null, max, (c, v, _, _max) => c + v + _max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenRangeConstraintFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "1912/03/04";
        DateTime min = new DateTime(1912, 3, 5);
        DateTime max = new DateTime(1912, 3, 3);
        string expected = ErrorMessageProvider.ValueInRangeAccessor(column, value, min, max);

        DateTimeValidator validator = new DateTimeValidator(column, value, min, max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenRangeConstraintFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "1912/03/04";
        DateTime min = new DateTime(1912, 3, 5);
        DateTime max = new DateTime(1912, 3, 3);
        string expected = column + value + min + max;

        DateTimeValidator validator = new DateTimeValidator(column, value, min, max, (c, v, _min, _max) => c + v + _min + _max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }
}
