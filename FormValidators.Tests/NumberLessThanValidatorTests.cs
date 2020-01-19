using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class NumberLessThanValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase("0.1", "0.1", true, true)]
        [TestCase("0.1", "0.1", false, false)]
        [TestCase("0.1", "1.1", false, true)]
        [TestCase("0.1", "-1.1", false, false)]
        [TestCase("a", "2", false, true)]
        [TestCase("0", "a", false, true)]
        public void Validate_Value_LessThan(string value, string comparisonValue, bool allowedEquals, bool isValid) {
            NumberLessThanValidator validator = new NumberLessThanValidator("", value, "", comparisonValue, allowedEquals);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_BasicFormat_AreEqual() {
            string column = "欄位";
            string comparisonColumn = "比較欄位";

            NumberLessThanValidator validator = new NumberLessThanValidator(column, "1.1", comparisonColumn, "0.1");
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

            NumberLessThanValidator validator = new NumberLessThanValidator(
                column, "1.1", comparisonColumn, "0.1", customMessageFormat: "{0}NumberLessThan{1}"
            );
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column, comparisonColumn),
                validator.ErrorMessage
            );
        }
    }
}