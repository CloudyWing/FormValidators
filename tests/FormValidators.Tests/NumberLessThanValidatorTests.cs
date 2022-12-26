using CloudyWing.FormValidators.Core;
using FluentAssertions;
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
        public void Validate_Value_LessThan(string value, string comparisonValue, bool allowedEqual, bool isValid) {
            NumberLessThanValidator validator = new NumberLessThanValidator("", value, "", comparisonValue, allowedEqual);
            Assert.AreEqual(validator.Validate(), isValid);
        }

        [Test]
        public void ErrorMessage_DefaultMessage_AreEqual() {
            string column = "欄位";
            string value = "1.1";
            string comparisonColumn = "比較欄位";
            string comparisonValue = "0.1";
            bool allowedEqual = false;
            string expected = ErrorMessageProvider.ValueLessThanAnotherColumnValueAccessor(column, value, comparisonColumn, comparisonValue, allowedEqual);

            NumberLessThanValidator validator = new NumberLessThanValidator(column, value, comparisonColumn, comparisonValue, allowedEqual);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_CustomMessage_AreEqual() {
            string column = "欄位";
            string value = "1.1";
            string comparisonColumn = "比較欄位";
            string comparisonValue = "0.1";
            bool allowedEqual = false;
            string expected = column + value + comparisonColumn + comparisonValue + allowedEqual;

            NumberLessThanValidator validator = new NumberLessThanValidator(
                column, value, comparisonColumn, comparisonValue, allowedEqual,
                (c, v, cc, cv, b) => c + v + cc + cv + b
            );
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }
    }
}
