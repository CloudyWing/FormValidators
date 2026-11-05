using System;
using System.Collections.Generic;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests.Core;

[TestFixture()]
public class ErrorMessageProviderTests {
    private static readonly TestCaseData[] NullAccessorSetters = [
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsRequiredAccessor(null!))).SetName("SetValueIsRequiredAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueGreaterOrEqualAccessor(null!))).SetName("SetValueGreaterOrEqualAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueLessOrEqualAccessor(null!))).SetName("SetValueLessOrEqualAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueInRangeAccessor(null!))).SetName("SetValueInRangeAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsIntegerAccessor(null!))).SetName("SetValueIsIntegerAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsNumberAccessor(null!))).SetName("SetValueIsNumberAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsDateTimeAccessor(null!))).SetName("SetValueIsDateTimeAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueLengthGreaterOrEqualAccessor(null!))).SetName("SetValueLengthGreaterOrEqualAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueLengthLessOrEqualAccessor(null!))).SetName("SetValueLengthLessOrEqualAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueLengthInRangeAccessor(null!))).SetName("SetValueLengthInRangeAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueMatchRegexAccessor(null!))).SetName("SetValueMatchRegexAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsEmailAccessor(null!))).SetName("SetValueIsEmailAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsMobilePhoneAccessor(null!))).SetName("SetValueIsMobilePhoneAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsIdCardAccessor(null!))).SetName("SetValueIsIdCardAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueCompareAnotherColumnValueAccessor(null!))).SetName("SetValueCompareAnotherColumnValueAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueLessThanAnotherColumnValueAccessor(null!))).SetName("SetValueLessThanAnotherColumnValueAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsUrlAccessor(null!))).SetName("SetValueIsUrlAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsIPAddressAccessor(null!))).SetName("SetValueIsIPAddressAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsCreditCardAccessor(null!))).SetName("SetValueIsCreditCardAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueMatchCustomRuleAccessor(null!))).SetName("SetValueMatchCustomRuleAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsInAllowedValuesAccessor(null!))).SetName("SetValueIsInAllowedValuesAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsGuidAccessor(null!))).SetName("SetValueIsGuidAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsTaiwanUniformNumberAccessor(null!))).SetName("SetValueIsTaiwanUniformNumberAccessor_NullAccessor_ThrowsArgumentNullException"),
        new TestCaseData(new Action(() => ErrorMessageProvider.SetValueIsPhoneAccessor(null!))).SetName("SetValueIsPhoneAccessor_NullAccessor_ThrowsArgumentNullException")
    ];

    [TearDown]
    public void TearDown() {
        ErrorMessageProvider.ResetToDefaults();
    }

    [Test]
    public void SetValueIsRequiredAccessor() {
        Func<string, string?, string> expected = (c, v) => c + v;
        ErrorMessageProvider.SetValueIsRequiredAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueIsRequiredAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueGreaterOrEqualAccessor() {
        Func<string, string?, object, string> expected = (c, v, min) => c + v + min;
        ErrorMessageProvider.SetValueGreaterOrEqualAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueGreaterOrEqualAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueLessOrEqualAccessor() {
        Func<string, string?, object, string> expected = (c, v, max) => c + v + max;
        ErrorMessageProvider.SetValueLessOrEqualAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueLessOrEqualAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueInRangeAccessor() {
        Func<string, string?, object, object, string> expected = (c, v, min, max) => c + v + min + max;
        ErrorMessageProvider.SetValueInRangeAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueInRangeAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueIsIntegerAccessor() {
        Func<string, string?, string> expected = (c, v) => c + v;
        ErrorMessageProvider.SetValueIsIntegerAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueIsIntegerAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueIsNumberAccessor() {
        Func<string, string?, string> expected = (c, v) => c + v;
        ErrorMessageProvider.SetValueIsNumberAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueIsNumberAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueIsDateTimeAccessor() {
        Func<string, string?, string> expected = (c, v) => c + v;
        ErrorMessageProvider.SetValueIsDateTimeAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueIsDateTimeAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueLengthGreaterOrEqualAccessor() {
        Func<string, string?, long, string> expected = (c, v, min) => c + v + min;
        ErrorMessageProvider.SetValueLengthGreaterOrEqualAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueLengthGreaterOrEqualAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueLengthLessOrEqualAccessor() {
        Func<string, string?, long, string> expected = (c, v, max) => c + v + max;
        ErrorMessageProvider.SetValueLengthLessOrEqualAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueLengthLessOrEqualAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueLengthInRangeAccessor() {
        Func<string, string?, long, long, string> expected = (c, v, min, max) => c + v + min + max;
        ErrorMessageProvider.SetValueLengthInRangeAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueLengthInRangeAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueMatchRegexAccessor() {
        Func<string, string?, string> expected = (c, v) => c + v;
        ErrorMessageProvider.SetValueMatchRegexAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueMatchRegexAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueIsEmailAccessor() {
        Func<string, string?, string> expected = (c, v) => c + v;
        ErrorMessageProvider.SetValueIsEmailAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueIsEmailAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueIsMobilePhoneAccessor() {
        Func<string, string?, MobilePhoneFormats, string> expected = (c, v, f) => c + v + f;
        ErrorMessageProvider.SetValueIsMobilePhoneAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueIsMobilePhoneAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueIsIdCardAccessor() {
        Func<string, string?, IdCardTypes, string> expected = (c, v, t) => c + v + t;
        ErrorMessageProvider.SetValueIsIdCardAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueIsIdCardAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueCompareAnotherColumnValueAccessor() {
        Func<string, string?, string, string?, string> expected = (c, v, cc, cv) => c + v + cc + cv;
        ErrorMessageProvider.SetValueCompareAnotherColumnValueAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueCompareAnotherColumnValueAccessor, Is.SameAs(expected));
    }

    [Test]
    public void SetValueLessThanAnotherColumnValueAccessor() {
        Func<string, string?, string, string?, bool, string> expected = (c, v, cc, cv, b) => c + v + cc + cv + b;
        ErrorMessageProvider.SetValueLessThanAnotherColumnValueAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueLessThanAnotherColumnValueAccessor, Is.SameAs(expected));
    }

    [Test]
    public void ResetToDefaults_AfterSetAccessor_RestoresDefaultAccessor() {
        Func<string, string?, string> original = ErrorMessageProvider.ValueIsRequiredAccessor;
        ErrorMessageProvider.SetValueIsRequiredAccessor((c, v) => c + v);

        ErrorMessageProvider.ResetToDefaults();

        Assert.That(ErrorMessageProvider.ValueIsRequiredAccessor, Is.SameAs(original));
    }

    [TestCaseSource(nameof(NullAccessorSetters))]
    public void SetAccessor_NullAccessor_ThrowsArgumentNullException(Action setter) {
        ArgumentNullException? exception = Assert.Throws<ArgumentNullException>(() => setter());

        Assert.That(exception?.ParamName, Is.EqualTo("accessor"));
    }

    [Test]
    public void SetValueIsPhoneAccessor_ValidAccessor_ReplacesAccessorUsedByValidator() {
        ErrorMessageProvider.SetValueIsPhoneAccessor((c, v) => $"{c}:{v}");
        PhoneValidator validator = new("電話", "123");

        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("電話:123"));
    }

    [Test]
    public void SetValueIsInAllowedValuesAccessor_ValidAccessor_ReplacesAccessor() {
        Func<string, string?, IReadOnlyList<string>, string> expected = (c, v, values) => c;

        ErrorMessageProvider.SetValueIsInAllowedValuesAccessor(expected);

        Assert.That(ErrorMessageProvider.ValueIsInAllowedValuesAccessor, Is.SameAs(expected));
    }
}
