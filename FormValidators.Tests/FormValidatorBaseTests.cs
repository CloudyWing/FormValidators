using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class FormValidatorBaseTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase("0", true)]
        [TestCase("1", true)]
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase(" ", false)]
        public void IsValid_Value_AreEqual(string value, bool isValid) {
            FormValidatorBase validator = new RequiredValidator("", value);
            validator.Validate();

            Assert.AreEqual(validator.IsValid, isValid);
        }
    }
}