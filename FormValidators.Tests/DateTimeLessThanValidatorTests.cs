using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class DateTimeLessThanValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase("2020/01/01", "2020/01/01", true, true)]
        [TestCase("2020/01/01", "2020/01/01", false, false)]
        [TestCase("2020/01/01", "2020/01/02", false, true)]
        [TestCase("2020/01/02", "2020/01/01", false, false)]
        [TestCase("AA", "2020/01/01", false, true)]
        [TestCase("2020/01/01", "AA", false, true)]
        public void Validate_Value_LessThan(string value, string comparisonValue, bool allowedEquals, bool isValid) {
            DateTimeLessThanValidator validator = new DateTimeLessThanValidator("", value, "", comparisonValue, allowedEquals);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_BasicFormat_AreEqual() {
            string column = "欄位";
            string comparisonColumn = "比較欄位";

            DateTimeLessThanValidator validator = new DateTimeLessThanValidator(column, "2020/01/02", comparisonColumn, "2020/01/01");
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

            DateTimeLessThanValidator validator = new DateTimeLessThanValidator(
                column, "2020/01/02", comparisonColumn, "2020/01/01", customMessageFormat: "{0}DateTimeLessThan{1}"
            );
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column, comparisonColumn),
                validator.ErrorMessage
            );
        }
    }
}