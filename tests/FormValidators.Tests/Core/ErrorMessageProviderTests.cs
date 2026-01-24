using System;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;


namespace CloudyWing.FormValidators.Tests.Core {
    [TestFixture()]
    public class ErrorMessageProviderTests {
        [Test]
        public void SetValueIsRequiredAccessor() {
            Func<string, string, string> expected = (c, v) => c + v;
            ErrorMessageProvider.SetValueIsRequiredAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueIsRequiredAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueGreaterOrEqualAccessor() {
            Func<string, string, object, string> expected = (c, v, min) => c + v + min;
            ErrorMessageProvider.SetValueGreaterOrEqualAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueGreaterOrEqualAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueLessOrEqualAccessor() {
            Func<string, string, object, string> expected = (c, v, max) => c + v + max;
            ErrorMessageProvider.SetValueLessOrEqualAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueLessOrEqualAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueInRangeAccessor() {
            Func<string, string, object, object, string> expected = (c, v, min, max) => c + v + min + max;
            ErrorMessageProvider.SetValueInRangeAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueInRangeAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueIsIntegerAccessor() {
            Func<string, string, string> expected = (c, v) => c + v;
            ErrorMessageProvider.SetValueIsIntegerAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueIsIntegerAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueIsNumberAccessor() {
            Func<string, string, string> expected = (c, v) => c + v;
            ErrorMessageProvider.SetValueIsNumberAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueIsNumberAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueIsDateTimeAccessor() {
            Func<string, string, string> expected = (c, v) => c + v;
            ErrorMessageProvider.SetValueIsDateTimeAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueIsDateTimeAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueLengthGreaterOrEqualAccessor() {
            Func<string, string, long, string> expected = (c, v, min) => c + v + min;
            ErrorMessageProvider.SetValueLengthGreaterOrEqualAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueLengthGreaterOrEqualAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueLengthLessOrEqualAccessor() {
            Func<string, string, long, string> expected = (c, v, max) => c + v + max;
            ErrorMessageProvider.SetValueLengthLessOrEqualAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueLengthLessOrEqualAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueLengthInRangeAccessor() {
            Func<string, string, long, long, string> expected = (c, v, min, max) => c + v + min + max;
            ErrorMessageProvider.SetValueLengthInRangeAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueLengthInRangeAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueMatchRegexAccessor() {
            Func<string, string, string> expected = (c, v) => c + v;
            ErrorMessageProvider.SetValueMatchRegexAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueMatchRegexAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueIsEmailAccessor() {
            Func<string, string, string> expected = (c, v) => c + v;
            ErrorMessageProvider.SetValueIsEmailAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueIsEmailAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueIsMobilePhoneAccessor() {
            Func<string, string, MobilePhoneFormats, string> expected = (c, v, f) => c + v + f;
            ErrorMessageProvider.SetValueIsMobilePhoneAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueIsMobilePhoneAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueIsIdCardAccessor() {
            Func<string, string, IdCardTypes, string> expected = (c, v, t) => c + v + t;
            ErrorMessageProvider.SetValueIsIdCardAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueIsIdCardAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueCompareAnotherColumnValueAccessor() {
            Func<string, string, string, string, string> expected = (c, v, cc, cv) => c + v + cc + cv;
            ErrorMessageProvider.SetValueCompareAnotherColumnValueAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueCompareAnotherColumnValueAccessor, Is.SameAs(expected));
        }

        [Test]
        public void SetValueLessThanAnotherColumnValueAccessor() {
            Func<string, string, string, string, bool, string> expected = (c, v, cc, cv, b) => c + v + cc + cv + b;
            ErrorMessageProvider.SetValueLessThanAnotherColumnValueAccessor(expected);

            Assert.That(ErrorMessageProvider.ValueLessThanAnotherColumnValueAccessor, Is.SameAs(expected));
        }
    }
}
