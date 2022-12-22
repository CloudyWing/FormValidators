using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class IntegerLessThanValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase("0", "0", true, true)]
        [TestCase("0", "0", false, false)]
        [TestCase("0", "1", false, true)]
        [TestCase("0", "-1", false, false)]
        [TestCase("1.1", "0", false, true)]
        [TestCase("2", "1.1", false, true)]
        public void Validate_Value_LessThan(string value, string comparisonValue, bool allowedEquals, bool isValid) {
            IntegerLessThanValidator validator = new IntegerLessThanValidator("", value, "", comparisonValue, allowedEquals);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_BasicFormat_AreEqual() {
            string column = "欄位";
            string comparisonColumn = "比較欄位";

            IntegerLessThanValidator validator = new IntegerLessThanValidator(column, "1", comparisonColumn, "0");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.DefaultErrorMessageFormat, column, comparisonColumn),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_CustomFormat_AreEqual() {
            string column = "欄位";
            string comparisonColumn = "比較欄位";

            IntegerLessThanValidator validator = new IntegerLessThanValidator(
                column, "1", comparisonColumn, "0", customMessageFormat: "{0}IntegerLessThan{1}"
            );
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column, comparisonColumn),
                validator.ErrorMessage
            );
        }
    }
}