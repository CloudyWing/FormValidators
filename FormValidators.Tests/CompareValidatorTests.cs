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
        public void Validate_ReturnValue_AreEqual(string value, string comparisonValue, bool isValid) {
            CompareValidator validator = new CompareValidator("", value, "", comparisonValue);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_BasicFormat_AreEqual() {
            const string column = "測試欄位";
            const string comparisonColumn = "比較欄位";
            CompareValidator validator = new CompareValidator(column, "123", comparisonColumn, "456");
            validator.Validate();
            Assert.AreEqual(
                string.Format(validator.DefaultErrorMessageFormat, column, comparisonColumn),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_CustomFormat_AreEqual() {
            string column = "測試欄位";
            const string comparisonColumn = "比較欄位";
            CompareValidator validator = new CompareValidator(column, "123", comparisonColumn, "456", "{0}Compare{1}");
            validator.Validate();
            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column, comparisonColumn),
                validator.ErrorMessage
            );
        }
    }
}