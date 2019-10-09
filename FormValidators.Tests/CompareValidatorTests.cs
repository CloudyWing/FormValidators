using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class CompareValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase(null, "", true)]
        [TestCase("", "", true)]
        [TestCase(" ", "", true)]
        [TestCase("123", "123", true)]
        [TestCase("123", "456", false)]
        public void Validate_ReturnValue_AreEqual(string value, string validationValue, bool isValid) {
            CompareValidator validator = new CompareValidator("", value, validationValue);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_BaseFormat_AreEqual() {
            string column = "測試欄位";
            CompareValidator validator = new CompareValidator(column, "123", "456");
            validator.Validate();
            Assert.AreEqual(
                string.Format(validator.DefaultErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_CustomFormat_AreEqual() {
            string column = "測試欄位";
            CompareValidator validator = new CompareValidator(column, "123", "456", "{0}Compare");
            validator.Validate();
            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }
    }
}