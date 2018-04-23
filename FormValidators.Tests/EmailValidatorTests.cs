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
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_BaseFormat_AreEqual() {
            string column = "測試欄位";
            EmailValidator validator = new EmailValidator(column, "error");
            validator.Validate();
            Assert.AreEqual(
                string.Format(validator.DefaultErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_CustomFormat_AreEqual() {
            string column = "測試欄位";
            EmailValidator validator = new EmailValidator(column, "error", "{0}Email");
            validator.Validate();
            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }
    }
}