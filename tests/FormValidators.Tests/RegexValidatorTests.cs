using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class RegexValidatorTests {
    [TestCase(null, "", true)]
    [TestCase("", "", true)]
    [TestCase(" ", "", true)]
    [TestCase("1234567", @"^\d{7}$", true)]
    [TestCase("a123456", @"^\d{7}$", false)]
    public void Validate_WhenComparingValues_ReturnsExpectedResult(string value, string pattern, bool isValid) {
        RegexValidator validator = new RegexValidator("", value, pattern);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "123456";
        string expected = ErrorMessageProvider.ValueMatchRegexAccessor(column, value);

        RegexValidator validator = new RegexValidator(column, value, @"\D+");
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "123456";
        string expected = column + value;

        RegexValidator validator = new RegexValidator(column, value, @"\D+", (c, v) => c + v);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }
}
