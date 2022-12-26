using CloudyWing.FormValidators.Core;
using FluentAssertions;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class IntegerValidatorTests {
        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase(" ", true)]
        [TestCase("0", true)]
        [TestCase("1", true)]
        [TestCase("-1", true)]
        [TestCase("1.1", false)]
        [TestCase("string", false)]
        public void Validate_Message_AreEqual(string value, bool isValid) {
            IntegerValidator validator = new IntegerValidator("", value);

            validator.Validate().Should().Be(isValid);
        }

        [TestCase("3", 2, 4, true)]
        [TestCase("3", 3, 3, true)]
        [TestCase("3", 2, 2, false)]
        [TestCase("3", 4, 4, false)]
        public void Validate_Range_AreEqual(string value, long min, long max, bool isValid) {
            IntegerValidator validator = new IntegerValidator("", value, min, max);

            validator.Validate().Should().Be(isValid);
        }

        [TestCase("3", 2, true)]
        [TestCase("3", 3, true)]
        [TestCase("3", 4, false)]
        public void Validate_Min_AreEqual(string value, long min, bool isValid) {
            IntegerValidator validator = new IntegerValidator("", value, min, null);

            validator.Validate().Should().Be(isValid);
        }

        [TestCase("3", 4, true)]
        [TestCase("3", 3, true)]
        [TestCase("3", 2, false)]
        public void Validate_Max_AreEqual(string value, long max, bool isValid) {
            IntegerValidator validator = new IntegerValidator("", value, null, max);

            validator.Validate().Should().Be(isValid);
        }

        [Test]
        public void ErrorMessage_DefaultMessage_AreEqual() {
            string column = "測試欄位";
            string value = "error";
            string expected = ErrorMessageProvider.ValueIsIntegerAccessor(column, value);

            IntegerValidator validator = new IntegerValidator(column, value);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_CustomMessage_AreEqual() {
            string column = "測試欄位";
            string value = "error";
            string expected = column + value;

            IntegerValidator validator = new IntegerValidator(column, value, (c, v, _, _) => c + v);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_MinDefaultMessage_AreEqual() {
            string column = "測試欄位";
            string value = "0";
            int min = 1;
            string expected = ErrorMessageProvider.ValueGreaterOrEqualAccessor(column, value, min);

            IntegerValidator validator = new IntegerValidator(column, value, min, null);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_MinCustomMessage_AreEqual() {
            string column = "測試欄位";
            string value = "0";
            int min = 1;
            string expected = column + value + min;

            IntegerValidator validator = new IntegerValidator(column, value, min, null, (c, v, _min, _) => c + v + _min);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_MaxDefaultMessage_AreEqual() {
            string column = "測試欄位";
            string value = "1";
            int max = 0;
            string expected = ErrorMessageProvider.ValueLessOrEqualAccessor(column, value, max);

            IntegerValidator validator = new IntegerValidator(column, value, null, max);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_MaxCustomMessage_AreEqual() {
            string column = "測試欄位";
            string value = "1";
            int max = 0;
            string expected = column + value + max;

            IntegerValidator validator = new IntegerValidator(column, value, null, max, (c, v, _, _max) => c + v + _max);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_RangeDefaultMessage_AreEqual() {
            string column = "測試欄位";
            string value = "0";
            int min = 1;
            int max = 2;
            string expected = ErrorMessageProvider.ValueInRangeAccessor(column, value, min, max);

            IntegerValidator validator = new IntegerValidator(column, value, min, max);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_RangeCustomMessage_AreEqual() {
            string column = "測試欄位";
            string value = "0";
            int min = 1;
            int max = 2;
            string expected = column + value + min + max;

            IntegerValidator validator = new IntegerValidator(column, value, min, max, (c, v, _min, _max) => c + v + _min + _max);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }
    }
}
