using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class NumberValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase(" ", true)]
        [TestCase("0", true)]
        [TestCase("1", true)]
        [TestCase("-1", true)]
        [TestCase("1.1", true)]
        [TestCase("string", false)]
        public void Validate_Format_AreEqual(string value, bool isValid) {
            NumberValidator validator = new NumberValidator("", value);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [TestCase("3.1", 2.1, 4.1, true)]
        [TestCase("3.1", 3.1, 3.1, true)]
        [TestCase("3.1", 2.1, 2.1, false)]
        [TestCase("3.1", 4.1, 4.1, false)]
        public void Validate_Range_AreEqual(string value, decimal min, decimal max, bool isValid) {
            NumberValidator validator = new NumberValidator("", value, min, max);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [TestCase("3.1", 2.1, true)]
        [TestCase("3.1", 3.1, true)]
        [TestCase("3.1", 4.1, false)]
        public void Validate_Min_AreEqual(string value, decimal min, bool isValid) {
            NumberValidator validator = NumberValidator.CreateMinValue("", value, min);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [TestCase("3.1", 4.1, true)]
        [TestCase("3.1", 3.1, true)]
        [TestCase("3.1", 2.1, false)]
        public void Validate_Max_AreEqual(string value, decimal max, bool isValid) {
            NumberValidator validator = NumberValidator.CreateMaxValue("", value, max);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_BasicFormat_AreEqual() {
            string column = "測試欄位";

            NumberValidator validator = new NumberValidator(column, "error");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.DefaultErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_CustomFormat_AreEqual() {
            string column = "測試欄位";

            NumberValidator validator = new NumberValidator(column, "error", "{0}Number");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MinFormat_AreEqual() {
            string column = "測試欄位";

            NumberValidator validator = NumberValidator.CreateMinValue(column, "0.1", 1.1m);
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.MinValueErrorMessageFormat, column, 1.1m),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MinCustomFormat_AreEqual() {
            string column = "測試欄位";

            NumberValidator validator = NumberValidator.CreateMinValue(column, "0.1", 1.1m, customRangeMessageFormat: "{0}_{1}Number");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomRangeMessageFormat, column, 1.1m),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MaxFormat_AreEqual() {
            string column = "測試欄位";

            NumberValidator validator = NumberValidator.CreateMaxValue(column, "1.1", 0.1m);
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.MaxValueErrorMessageFormat, column, 0.1m),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MaxCustomFormat_AreEqual() {
            string column = "測試欄位";

            NumberValidator validator = NumberValidator.CreateMaxValue(column, "1.1", 0.1m, customRangeMessageFormat: "{0}_{1}Number");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomRangeMessageFormat, column, 0.1m),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_RangeFormat_AreEqual() {
            string column = "測試欄位";

            NumberValidator validator = new NumberValidator(column, "0.1", 1.1m, 2.1m);
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.RangeErrorMessageFormat, column, 1.1m, 2.1m),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_RangeCustomFormat_AreEqual() {
            string column = "測試欄位";

            NumberValidator validator = new NumberValidator(column, "0.1", 1.1m, 2.1m, customRangeMessageFormat: "{0}_{1}_{2}Number");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomRangeMessageFormat, column, 1.1m, 2.1m),
                validator.ErrorMessage
            );
        }
    }
}