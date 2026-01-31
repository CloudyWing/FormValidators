using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class DateTimeLessThanValidatorTests {
    [TestCase("2020/01/01", "2020/01/01", true, true)]
    [TestCase("2020/01/01", "2020/01/01", false, false)]
    [TestCase("2020/01/01", "2020/01/02", false, true)]
    [TestCase("2020/01/02", "2020/01/01", false, false)]
    [TestCase("AA", "2020/01/01", false, true)]
    [TestCase("2020/01/01", "AA", false, true)]
    public void Validate_WhenComparingDateTimes_ReturnsExpectedResult(string value, string comparisonValue, bool allowedEqual, bool isValid) {
        DateTimeLessThanValidator validator = new("", value, "", comparisonValue, allowedEqual);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "欄位";
        string value = "2020/01/02";
        string comparisonColumn = "比較欄位";
        string comparisonValue = "2020/01/01";
        bool allowedEqual = false;
        string expected = ErrorMessageProvider.ValueLessThanAnotherColumnValueAccessor(column, comparisonColumn, value, comparisonValue, allowedEqual);

        DateTimeLessThanValidator validator = new(column, value, comparisonColumn, comparisonValue, allowedEqual);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "欄位";
        string value = "2020/01/02";
        string comparisonColumn = "比較欄位";
        string comparisonValue = "2020/01/01";
        bool allowedEqual = false;
        string expected = column + value + comparisonColumn + comparisonValue + allowedEqual;

        DateTimeLessThanValidator validator = new(
            column, value, comparisonColumn, comparisonValue, allowedEqual, (c, v, cc, cv, b) => c + v + cc + cv + b
        );
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }
}
