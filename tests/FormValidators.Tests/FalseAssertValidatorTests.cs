using System;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

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

        Assert.That(actual, Is.False);
    }

    [Test]
    public void ErrorMessage_Value_AreEqual() {
        string expected = "測試FalseAssert";

        FalseAssertValidator validator = new FalseAssertValidator(true, expected);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void Predicate_Exception_Timing() {
        int dividend = 0;
        int division = 1;

        Assert.DoesNotThrow(() => new FalseAssertValidator(() => (division / dividend) == 0, ""));

        Assert.Throws<DivideByZeroException>(() => new FalseAssertValidator(() => (division / dividend) == 0, "").Validate());
    }
}
