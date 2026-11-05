using System;
using System.Text.RegularExpressions;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests.Core;

[TestFixture]
public class ValidatorDefaultsTests {
    [TearDown]
    public void TearDown() {
        ValidatorDefaults.ResetToDefaults();
    }

    [Test]
    public void RegexTimeout_Default_IsInfinite() {
        Assert.That(ValidatorDefaults.RegexTimeout, Is.EqualTo(Regex.InfiniteMatchTimeout));
    }

    [Test]
    public void RegexTimeout_WhenSet_AppliesToPatternValidator() {
        ValidatorDefaults.RegexTimeout = TimeSpan.FromMilliseconds(1);
        RegexValidator validator = new("", new string('a', 64) + "!", @"^(a+)+$");

        bool isValid = validator.Validate();

        using (Assert.EnterMultipleScope()) {
            Assert.That(ValidatorDefaults.RegexTimeout, Is.EqualTo(TimeSpan.FromMilliseconds(1)));
            Assert.That(isValid, Is.False);
        }
    }

    [Test]
    public void RegexTimeout_WhenSet_DoesNotChangeMatchResult() {
        ValidatorDefaults.RegexTimeout = TimeSpan.FromSeconds(1);
        RegexValidator validator = new("", "1234567", @"^\d{7}$");

        Assert.That(validator.Validate(), Is.True);
    }

    [TestCase(0)]
    [TestCase(-5)]
    public void RegexTimeout_InvalidValue_ThrowsArgumentOutOfRangeException(int milliseconds) {
        Assert.Throws<ArgumentOutOfRangeException>(() => ValidatorDefaults.RegexTimeout = TimeSpan.FromMilliseconds(milliseconds));
    }
}
