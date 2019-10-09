using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class RequiredValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase("0", true)]
        [TestCase("1", true)]
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase(" ", false)]
        public void Validate_ReturnValue_AreEqual(string value, bool isValid) {
            RequiredValidator validator = new RequiredValidator("", value);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_BaseFormat_AreEqual() {
            string column = "測試欄位";

            RequiredValidator validator = new RequiredValidator(column, null);
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.DefaultErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_CustomFormat_AreEqual() {
            string column = "測試欄位";

            RequiredValidator validator = new RequiredValidator(column, null, "{0}Required");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }
    }
}