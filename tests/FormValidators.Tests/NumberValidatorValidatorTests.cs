using CloudyWing.FormValidators.Core;
using FluentAssertions;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class NumberValidatorTests {
        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase(" ", true)]
        [TestCase("0", true)]
        [TestCase("1", true)]
        [TestCase("-1", true)]
        [TestCase("1.1", true)]
        [TestCase("string", false)]
        public void Validate_Message_AreEqual(string value, bool isValid) {
            NumberValidator validator = new NumberValidator("", value);

            validator.Validate().Should().Be(isValid);
        }

        [TestCase("3.1", 2.1, 4.1, true)]
        [TestCase("3.1", 3.1, 3.1, true)]
        [TestCase("3.1", 2.1, 2.1, false)]
        [TestCase("3.1", 4.1, 4.1, false)]
        public void Validate_Range_AreEqual(string value, decimal min, decimal max, bool isValid) {
            NumberValidator validator = new NumberValidator("", value, min, max);

            validator.Validate().Should().Be(isValid);
        }

        [TestCase("3.1", 2.1, true)]
        [TestCase("3.1", 3.1, true)]
        [TestCase("3.1", 4.1, false)]
        public void Validate_Min_AreEqual(string value, decimal min, bool isValid) {
            NumberValidator validator = new NumberValidator("", value, min, null);

            validator.Validate().Should().Be(isValid);
        }

        [TestCase("3.1", 4.1, true)]
        [TestCase("3.1", 3.1, true)]
        [TestCase("3.1", 2.1, false)]
        public void Validate_Max_AreEqual(string value, decimal max, bool isValid) {
            NumberValidator validator = new NumberValidator("", value, null, max);

            validator.Validate().Should().Be(isValid);
        }

        [Test]
        public void ErrorMessage_DefaultMessage_AreEqual() {
            string column = "測試欄位";
            string value = "error";
            string expected = ErrorMessageProvider.ValueIsNumberAccessor(column, value);

            NumberValidator validator = new NumberValidator(column, value);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_CustomMessage_AreEqual() {
            string column = "測試欄位";
            string value = "error";
            string expected = column + value;

            NumberValidator validator = new NumberValidator(column, value, (c, v, _, _) => c + v);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_MinDefaultMessage_AreEqual() {
            string column = "測試欄位";
            string value = "1.0";
            decimal min = 1.1m;
            string expected = ErrorMessageProvider.ValueGreaterOrEqualAccessor(column, value, min);

            NumberValidator validator = new NumberValidator(column, value, min, null);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_MinCustomMessage_AreEqual() {
            string column = "測試欄位";
            string value = "1.0";
            decimal min = 1.1m;
            string expected = column + value + min;

            NumberValidator validator = new NumberValidator(
                column, value, min, null, (c, v, _min, _) => c + v + _min
            );
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_MaxDefaultMessage_AreEqual() {
            string column = "測試欄位";
            string value = "1.1";
            decimal max = 0.1m;
            string expected = ErrorMessageProvider.ValueLessOrEqualAccessor(column, value, max);

            NumberValidator validator = new NumberValidator(column, value, null, max);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_MaxCustomMessage_AreEqual() {
            string column = "測試欄位";
            string value = "1.1";
            decimal max = 0.1m;
            string expected = column + value + max;

            NumberValidator validator = new NumberValidator(column, value, null, max, (c, v, _, _max) => c + v + _max);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_RangeDefaultMessage_AreEqual() {
            string column = "測試欄位";
            string value = "0.1";
            decimal min = 1.1m;
            decimal max = 2.1m;
            string expected = ErrorMessageProvider.ValueInRangeAccessor(column, value, min, max);

            NumberValidator validator = new NumberValidator(column, value, min, max);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_RangeCustomMessage_AreEqual() {
            string column = "測試欄位";
            string value = "0.1";
            decimal min = 1.1m;
            decimal max = 2.1m;
            string expected = column + value + min + max;

            NumberValidator validator = new NumberValidator(
                column, value, min, max, (c, v, _min, _max) => c + v + _min + _max
            );
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }
    }
}
