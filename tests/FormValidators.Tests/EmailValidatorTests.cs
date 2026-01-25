using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class EmailValidatorTests {
    [TestCase(null, true)]
    [TestCase("", true)]
    [TestCase(" ", true)]
    [TestCase("wing@gmail.com", true)]
    [TestCase("wing@gmail", false)]
    [TestCase("wing.com", false)]
    public void Validate_WhenComparingValues_ReturnsExpectedResult(string value, bool isValid) {
        EmailValidator validator = new EmailValidator("", value);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "error";

        EmailValidator validator = new EmailValidator(column, value);
        validator.Validate();

        string expected = ErrorMessageProvider.ValueIsEmailAccessor(column, value);

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "error";
        string expected = column + value;

        EmailValidator validator = new EmailValidator(column, value, (c, v) => c + v);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }
}
