using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class MobilePhoneValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase(" ", true)]
        [TestCase("0912345678", true)]
        [TestCase("09123456789", false)]
        [TestCase("091234567", false)]
        [TestCase("0812345678", false)]
        [TestCase("1912345678", false)]
        public void Validate_ReturnValue_AreEqual(string value, bool isValid) {
            MobilePhoneValidator validator = new MobilePhoneValidator("", value);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_BasicFormat_AreEqual() {
            string column = "測試欄位";

            MobilePhoneValidator validator = new MobilePhoneValidator(column, "error");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.DefaultErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_CustomFormat_AreEqual() {
            string column = "測試欄位";

            MobilePhoneValidator validator = new MobilePhoneValidator(column, "error", "{0}MobilePhone");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }
    }
}