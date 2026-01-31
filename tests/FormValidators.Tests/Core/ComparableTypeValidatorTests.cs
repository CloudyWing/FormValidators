using System;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests.Core;

[TestFixture]
public class ComparableTypeValidatorTests {
    private class TestComparableValidator : ComparableTypeValidator<int> {
        public TestComparableValidator(
            string column, string value, int? min, int? max,
            Func<string, string, int?, int?, string> customErrorMessageAccessor
        ) : base(column, value, min, max, customErrorMessageAccessor) { }

        protected override Func<string, string, string> CastErrorMessageAccessor =>
            (col, val) => $"{col} must be int.";

        protected override bool TryParse(string value, out int result) {
            return int.TryParse(value, out result);
        }
    }

    [TestCase("10", 5, 15, true)]
    [TestCase("5", 5, 15, true)]
    [TestCase("15", 5, 15, true)]
    [TestCase("4", 5, 15, false)]
    [TestCase("16", 5, 15, false)]
    public void Validate_Range_ReturnsExpected(string value, int? min, int? max, bool expected) {
        var validator = new TestComparableValidator("Col", value, min, max, null);
        Assert.That(validator.Validate(), Is.EqualTo(expected));
    }

    [Test]
    public void Validate_InvalidFormat_ReturnsFalseAndErrorMessage() {
        var validator = new TestComparableValidator("Col", "abc", null, null, null);
        Assert.That(validator.Validate(), Is.False);
        Assert.That(validator.ErrorMessage, Is.EqualTo("Col must be int."));
    }

    [Test]
    public void ErrorMessage_InRange_DefaultMessage() {
        var validator = new TestComparableValidator("Col", "4", 5, 10, null);
        validator.Validate();
        Assert.That(validator.ErrorMessage, Does.Contain("介於「5」和「10」之間"));
    }

    [Test]
    public void ErrorMessage_MinOnly_DefaultMessage() {
        var validator = new TestComparableValidator("Col", "4", 5, null, null);
        validator.Validate();
        Assert.That(validator.ErrorMessage, Does.Contain("大於等於「5」"));
    }

    [Test]
    public void ErrorMessage_MaxOnly_DefaultMessage() {
        var validator = new TestComparableValidator("Col", "11", null, 10, null);
        validator.Validate();
        Assert.That(validator.ErrorMessage, Does.Contain("小於等於「10」"));
    }
}
