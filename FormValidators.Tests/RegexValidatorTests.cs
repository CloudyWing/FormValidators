using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {

    [TestFixture]
    public class RegexValidatorTests {

        [SetUp]
        public void Setup() {
        }
        
        [TestCase(null, "", true)]
        [TestCase("", "", true)]
        [TestCase(" ", "", true)]
        [TestCase("1234567", @"^\d{7}$", true)]
        [TestCase("a123456", @"^\d{7}$", false)]
        public void Validate_ReturnValue_AreEqual(string value, string pattern, bool isValid) {
            RegexValidator validator = new RegexValidator("", value, pattern);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_BaseFormat_AreEqual() {
            string column = "測試欄位";
            RegexValidator validator = new RegexValidator(column, "123456", @"\D+");
            validator.Validate();
            Assert.AreEqual(
                string.Format(validator.DefaultErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_CustomFormat_AreEqual() {
            string column = "測試欄位";
            RegexValidator validator = new RegexValidator(column, "123456", @"\D+", "{0}Regex");
            validator.Validate();
            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }
    }
}