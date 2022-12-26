using CloudyWing.FormValidators.Core;
using FluentAssertions;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class RequiredValidatorTests {
        [TestCase("0", true)]
        [TestCase("1", true)]
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase(" ", false)]
        public void Validate_ReturnValue_AreEqual(string value, bool isValid) {
            RequiredValidator validator = new RequiredValidator("", value);

            validator.Validate().Should().Be(isValid);
        }

        [Test]
        public void ErrorMessage_DefaultMessage_AreEqual() {
            string column = "測試欄位";
            string value = null;
            string expected = ErrorMessageProvider.ValueIsRequiredAccessor(column, value);

            RequiredValidator validator = new RequiredValidator(column, value);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_CustomMessage_AreEqual() {
            string column = "測試欄位";
            string value = null;
            string expected = column + value;

            RequiredValidator validator = new RequiredValidator(column, null, (c, v) => c + v);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }
    }
}
