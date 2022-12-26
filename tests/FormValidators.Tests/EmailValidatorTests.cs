using CloudyWing.FormValidators.Core;
using FluentAssertions;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class EmailValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase(" ", true)]
        [TestCase("wing@gmail.com", true)]
        [TestCase("wing@gmail", false)]
        [TestCase("wing.com", false)]
        public void Validate_ReturnValue_AreEqual(string value, bool isValid) {
            EmailValidator validator = new EmailValidator("", value);

            validator.Validate().Should().Be(isValid);
        }

        [Test]
        public void ErrorMessage_DefaultMessage_AreEqual() {
            string column = "測試欄位";
            string value = "error";

            EmailValidator validator = new EmailValidator(column, value);
            validator.Validate();

            string expected = ErrorMessageProvider.ValueIsEmailAccessor(column, value);

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_CustomMessage_AreEqual() {
            string column = "測試欄位";
            string value = "error";
            string expected = column + value;

            EmailValidator validator = new EmailValidator(column, value, (c, v) => c + v);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }
    }
}
