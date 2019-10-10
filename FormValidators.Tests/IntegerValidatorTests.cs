using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class IntegerValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase(" ", true)]
        [TestCase("0", true)]
        [TestCase("1", true)]
        [TestCase("-1", true)]
        [TestCase("1.1", false)]
        [TestCase("string", false)]
        public void Validate_Format_AreEqual(string value, bool isValid) {
            IntegerValidator validator = new IntegerValidator("", value);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [TestCase("3", 2, 4, true)]
        [TestCase("3", 3, 3, true)]
        [TestCase("3", 2, 2, false)]
        [TestCase("3", 4, 4, false)]
        public void Validate_Range_AreEqual(string value, int min, int max, bool isValid) {
            IntegerValidator validator = new IntegerValidator("", value, min, max);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [TestCase("3", 2, true)]
        [TestCase("3", 3, true)]
        [TestCase("3", 4, false)]
        public void Validate_Min_AreEqual(string value, int min, bool isValid) {
            IntegerValidator validator = IntegerValidator.CreateMinValue("", value, min);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [TestCase("3", 4, true)]
        [TestCase("3", 3, true)]
        [TestCase("3", 2, false)]
        public void Validate_Max_AreEqual(string value, int max, bool isValid) {
            IntegerValidator validator = IntegerValidator.CreateMaxValue("", value, max);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_BasicFormat_AreEqual() {
            string column = "測試欄位";

            IntegerValidator validator = new IntegerValidator(column, "error");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.DefaultErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_CustomFormat_AreEqual() {
            string column = "測試欄位";

            IntegerValidator validator = new IntegerValidator(column, "error", "{0}Integer");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MinFormat_AreEqual() {
            string column = "測試欄位";

            IntegerValidator validator = IntegerValidator.CreateMinValue(column, "0", 1);
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.MinValueErrorMessageFormat, column, 1),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MinCustomFormat_AreEqual() {
            string column = "測試欄位";

            IntegerValidator validator = IntegerValidator.CreateMinValue(column, "0", 1, customRangeMessageFormat: "{0}_{1}Integer");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomRangeMessageFormat, column, 1),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MaxFormat_AreEqual() {
            string column = "測試欄位";

            IntegerValidator validator = IntegerValidator.CreateMaxValue(column, "1", 0);
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.MaxValueErrorMessageFormat, column, 0),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MaxCustomFormat_AreEqual() {
            string column = "測試欄位";

            IntegerValidator validator = IntegerValidator.CreateMaxValue(column, "1", 0, customRangeMessageFormat: "{0}_{1}Integer");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomRangeMessageFormat, column, 0),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_RangeFormat_AreEqual() {
            string column = "測試欄位";

            IntegerValidator validator = new IntegerValidator(column, "0", 1, 2);
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.RangeErrorMessageFormat, column, 1, 2),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_RangeCustomFormat_AreEqual() {
            string column = "測試欄位";

            IntegerValidator validator = new IntegerValidator(column, "0", 1, 2, customRangeMessageFormat: "{0}_{1}_{2}Integer");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomRangeMessageFormat, column, 1, 2),
                validator.ErrorMessage
            );
        }
    }
}