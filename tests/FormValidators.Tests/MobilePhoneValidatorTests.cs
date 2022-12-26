using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class MobilePhoneValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        [TestCase(null, MobilePhoneFormats.AllowContainDashes, true)]
        [TestCase(null, MobilePhoneFormats.AllowWithoutDashes, true)]
        [TestCase(null, MobilePhoneFormats.All, true)]
        [TestCase("", MobilePhoneFormats.AllowContainDashes, true)]
        [TestCase("", MobilePhoneFormats.AllowWithoutDashes, true)]
        [TestCase("", MobilePhoneFormats.All, true)]
        [TestCase("0912345678", MobilePhoneFormats.AllowContainDashes, false)]
        [TestCase("0912345678", MobilePhoneFormats.AllowWithoutDashes, true)]
        [TestCase("0912345678", MobilePhoneFormats.All, true)]
        [TestCase("0912-345678", MobilePhoneFormats.AllowContainDashes, false)]
        [TestCase("0912-345678", MobilePhoneFormats.AllowWithoutDashes, false)]
        [TestCase("0912-345678", MobilePhoneFormats.All, true)]
        [TestCase("0912-345-678", MobilePhoneFormats.AllowContainDashes, true)]
        [TestCase("0912-345-678", MobilePhoneFormats.AllowWithoutDashes, false)]
        [TestCase("0912-345-678", MobilePhoneFormats.All, true)]
        [TestCase("09123456789", MobilePhoneFormats.AllowContainDashes, false)]
        [TestCase("09123456789", MobilePhoneFormats.AllowWithoutDashes, false)]
        [TestCase("09123456789", MobilePhoneFormats.All, false)]
        [TestCase("091234567", MobilePhoneFormats.AllowContainDashes, false)]
        [TestCase("091234567", MobilePhoneFormats.AllowWithoutDashes, false)]
        [TestCase("091234567", MobilePhoneFormats.All, false)]
        [TestCase("0812345678", MobilePhoneFormats.AllowContainDashes, false)]
        [TestCase("0812345678", MobilePhoneFormats.AllowWithoutDashes, false)]
        [TestCase("0812345678", MobilePhoneFormats.All, false)]
        [TestCase("1912345678", MobilePhoneFormats.AllowContainDashes, false)]
        [TestCase("1912345678", MobilePhoneFormats.AllowWithoutDashes, false)]
        [TestCase("1912345678", MobilePhoneFormats.All, false)]
        public void Validate_ReturnValue_AreEqual(string value, MobilePhoneFormats formats, bool isValid) {
            MobilePhoneValidator validator = new MobilePhoneValidator("", value, formats);
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
