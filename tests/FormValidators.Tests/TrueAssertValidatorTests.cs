using System;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class TrueAssertValidatorTests {
    [TestCase(true)]
    [TestCase(false)]
    public void Validate_WhenConditionIsProvided_ReturnsConditionResult(bool value) {
        TrueAssertValidator validator = new TrueAssertValidator(value, "");
        bool actual = validator.Validate() == value;

        Assert.That(actual, Is.True);
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string expected = "測試TrueAssert";
        TrueAssertValidator validator = new TrueAssertValidator(false, expected);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void Validate_WhenPredicateMatches_ThrowsExceptionLazyLoading() {
        int dividend = 0;
        int division = 1;

        Assert.DoesNotThrow(() => new TrueAssertValidator(() => (division / dividend) == 0, ""));

        Assert.Throws<DivideByZeroException>(() => new TrueAssertValidator(() => (division / dividend) == 0, "").Validate());
    }
}
