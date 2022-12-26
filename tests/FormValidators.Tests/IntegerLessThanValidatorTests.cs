using CloudyWing.FormValidators.Core;
using FluentAssertions;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class IntegerLessThanValidatorTests {
        [TestCase("0", "0", true, true)]
        [TestCase("0", "0", false, false)]
        [TestCase("0", "1", false, true)]
        [TestCase("0", "-1", false, false)]
        [TestCase("1.1", "0", false, true)]
        [TestCase("2", "1.1", false, true)]
        public void Validate_Value_LessThan(string value, string comparisonValue, bool allowedEqual, bool isValid) {
            IntegerLessThanValidator validator = new IntegerLessThanValidator("", value, "", comparisonValue, allowedEqual);

            validator.Validate().Should().Be(isValid);
        }

        [Test]
        public void ErrorMessage_DefaultMessage_AreEqual() {
            string column = "欄位";
            string value = "1";
            string comparisonColumn = "比較欄位";
            string comparisonValue = "0";
            bool allowedEqual = false;
            string expected = ErrorMessageProvider.ValueLessThanAnotherColumnValueAccessor(column, value, comparisonColumn, comparisonValue, allowedEqual);

            IntegerLessThanValidator validator = new IntegerLessThanValidator(column, value, comparisonColumn, comparisonValue, allowedEqual);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_CustomMessage_AreEqual() {
            string column = "欄位";
            string value = "1";
            string comparisonColumn = "比較欄位";
            string comparisonValue = "0";
            bool allowedEqual = false;
            string expected = column + value + comparisonColumn + comparisonValue + allowedEqual;

            IntegerLessThanValidator validator = new IntegerLessThanValidator(
                column, value, comparisonColumn, comparisonValue, allowedEqual, (c, v, cc, cv, b) => c + v + cc + cv + b
            );
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }
    }
}
