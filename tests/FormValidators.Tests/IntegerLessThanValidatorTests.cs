using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
[SetCulture("zh-TW")]
public class IntegerLessThanValidatorTests {
    [TestCase("0", "0", true, true)]
    [TestCase("0", "0", false, false)]
    [TestCase("0", "1", false, true)]
    [TestCase("0", "-1", false, false)]
    [TestCase("1.1", "0", false, true)]
    [TestCase("2", "1.1", false, true)]
    [TestCase("1,000", "1,000", true, true)]
    public void Validate_WhenComparingDateTimes_ReturnsExpectedResult(string value, string comparisonValue, bool allowedEqual, bool isValid) {
        IntegerLessThanValidator validator = new("", value, "", comparisonValue, allowedEqual);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "欄位";
        string value = "1";
        string comparisonColumn = "比較欄位";
        string comparisonValue = "0";
        bool allowedEqual = false;
        string expected = "「欄位」必須要小於「比較欄位」。";

        IntegerLessThanValidator validator = new(column, value, comparisonColumn, comparisonValue, allowedEqual);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "欄位";
        string value = "1";
        string comparisonColumn = "比較欄位";
        string comparisonValue = "0";
        bool allowedEqual = false;
        string expected = column + value + comparisonColumn + comparisonValue + allowedEqual;

        IntegerLessThanValidator validator = new(
            column, value, comparisonColumn, comparisonValue, allowedEqual, (c, v, cc, cv, b) => c + v + cc + cv + b
        );
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [TestCase("2,000", "1,000", false)]
    [TestCase("-2", "1", true)]
    [TestCase(" 2 ", "1", false)]
    public void Validate_WithIntegerFormat_ComparesValues(string value, string comparisonValue, bool isValid) {
        IntegerLessThanValidator validator = new("", value, "", comparisonValue, false);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [TestCase("2.0", "1")]
    [TestCase("1e3", "2")]
    [TestCase("$5", "1")]
    [TestCase("(5)", "1")]
    public void Validate_WithNonIntegerFormat_SkipsComparison(string value, string comparisonValue) {
        IntegerLessThanValidator validator = new("", value, "", comparisonValue, false);

        Assert.That(validator.Validate(), Is.True);
    }
}
