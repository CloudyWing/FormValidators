using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests.Core;

[TestFixture]
public class FormValidatorBaseTests {
    [TestCase("0", true)]
    [TestCase("1", true)]
    [TestCase(null, false)]
    [TestCase("", false)]
    [TestCase(" ", false)]
    public void IsValid_Value_AreEqual(string value, bool isValid) {
        FormValidatorBase validator = new RequiredValidator("", value);
        validator.Validate();

        Assert.That(validator.IsValid, Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_BeforeValidate_IsEmpty() {
        RequiredValidator validator = new("欄位", null);

        Assert.That(validator.ErrorMessage, Is.Empty);
    }
}
