using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture()]
    public class ValueLengthValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase("123", 0, 3, true)]
        [TestCase("123", 2, 2, false)]
        [TestCase("123", 4, 4, false)]
        public void Validate_Range_AreEqual(string value, int min, int max, bool isValid) {
            ValueLengthValidator validator = new ValueLengthValidator("", value, min, max);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [TestCase("123", 0, true)]
        [TestCase("123", 3, true)]
        [TestCase("123", 4, false)]
        public void Validate_Min_AreEqual(string value, int min, bool isValid) {
            ValueLengthValidator validator = ValueLengthValidator.CreateMinLength("", value, min);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [TestCase("123", 3, true)]
        [TestCase("123", 4, true)]
        [TestCase("123", 2, false)]
        public void Validate_Max_AreEqual(string value, int max, bool isValid) {
            ValueLengthValidator validator = ValueLengthValidator.CreateMaxLength("", value, max);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_BasicFormat_AreEqual() {
            string column = "測試欄位";
            int min = 1;
            int max = 1;

            ValueLengthValidator validator = new ValueLengthValidator(column, "123", min, max);
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.DefaultErrorMessageFormat, column, min, max),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_CustomFormat_AreEqual() {
            string column = "測試欄位";
            int min = 1;
            int max = 1;

            ValueLengthValidator validator = new ValueLengthValidator(column, "123", min, max, "{0}_{1}_{2}ValueLength");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column, min, max),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MinFormat_AreEqual() {
            string column = "測試欄位";
            int min = 4;

            ValueLengthValidator validator = ValueLengthValidator.CreateMinLength(column, "123", min);
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.MinLengthErrorMessageFormat, column, min),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MinCustomFormat_AreEqual() {
            string column = "測試欄位";
            int min = 4;

            ValueLengthValidator validator = ValueLengthValidator.CreateMinLength(column, "123", min, "{0}_{1}ValueLength");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column, min),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MaxFormat_AreEqual() {
            string column = "測試欄位";
            int max = 2;

            ValueLengthValidator validator = ValueLengthValidator.CreateMaxLength(column, "123", max);
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.MaxLengthErrorMessageFormat, column, max),
                validator.ErrorMessage
            );
        }

        [Test]
        public void ErrorMessage_MaxCustomFormat_AreEqual() {
            string column = "測試欄位";
            int max = 2;

            ValueLengthValidator validator = ValueLengthValidator.CreateMaxLength(column, "123", max, "{0}_{1}ValueLength");
            validator.Validate();

            Assert.AreEqual(
                string.Format(validator.CustomErrorMessageFormat, column, max),
                validator.ErrorMessage
            );
        }
    }
}