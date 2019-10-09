using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class FalseAssertValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase(true)]
        [TestCase(false)]
        public void Validate_ReturnValue_IsFalse(bool value) {
            FalseAssertValidator validator = new FalseAssertValidator(value, "");
            bool actual = validator.Validate() == value;

            Assert.IsFalse(actual);
        }

        [Test]
        public void ErrorMessage_Value_AreEqual() {
            string expected = "´ú¸ÕFalseAssert";

            FalseAssertValidator validator = new FalseAssertValidator(true, expected);
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, expected);
        }
    }
}