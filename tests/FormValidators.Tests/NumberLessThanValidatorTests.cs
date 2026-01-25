using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class NumberLessThanValidatorTests {
    [TestCase("0.1", "0.1", true, true)]
    [TestCase("0.1", "0.1", false, false)]
    [TestCase("0.1", "1.1", false, true)]
    [TestCase("0.1", "-1.1", false, false)]
    [TestCase("a", "2", false, true)]
    [TestCase("0", "a", false, true)]
    [TestCase("1,000.1", "1,000.1", true, true)]
    public void Validate_WhenComparingDateTimes_ReturnsExpectedResult(string value, string comparisonValue, bool allowedEqual, bool isValid) {
        NumberLessThanValidator validator = new NumberLessThanValidator("", value, "", comparisonValue, allowedEqual);
        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "欄位";
        string value = "1.1";
        string comparisonColumn = "比較欄位";
        string comparisonValue = "0.1";
        bool allowedEqual = false;
        string expected = ErrorMessageProvider.ValueLessThanAnotherColumnValueAccessor(column, value, comparisonColumn, comparisonValue, allowedEqual);

        NumberLessThanValidator validator = new NumberLessThanValidator(column, value, comparisonColumn, comparisonValue, allowedEqual);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "欄位";
        string value = "1.1";
        string comparisonColumn = "比較欄位";
        string comparisonValue = "0.1";
        bool allowedEqual = false;
        string expected = column + value + comparisonColumn + comparisonValue + allowedEqual;

        NumberLessThanValidator validator = new NumberLessThanValidator(
            column, value, comparisonColumn, comparisonValue, allowedEqual,
            (c, v, cc, cv, b) => c + v + cc + cv + b
        );
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }
}
