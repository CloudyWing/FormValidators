using System;
using CloudyWing.FormValidators.Core;
using FluentAssertions;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests.Core {
    [TestFixture()]
    public class ErrorMessageProviderTests {
        [Test]
        public void SetValueIsRequiredAccessor() {
            Func<string, string, string> expected = (c, v) => c + v;
            ErrorMessageProvider.SetValueIsRequiredAccessor(expected);

            ErrorMessageProvider.ValueIsRequiredAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueGreaterOrEqualAccessor() {
            Func<string, string, object, string> expected = (c, v, min) => c + v + min;
            ErrorMessageProvider.SetValueGreaterOrEqualAccessor(expected);

            ErrorMessageProvider.ValueGreaterOrEqualAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueLessOrEqualAccessor() {
            Func<string, string, object, string> expected = (c, v, max) => c + v + max;
            ErrorMessageProvider.SetValueLessOrEqualAccessor(expected);

            ErrorMessageProvider.ValueLessOrEqualAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueInRangeAccessor() {
            Func<string, string, object, object, string> expected = (c, v, min, max) => c + v + min + max;
            ErrorMessageProvider.SetValueInRangeAccessor(expected);

            ErrorMessageProvider.ValueInRangeAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueIsIntegerAccessor() {
            Func<string, string, string> expected = (c, v) => c + v;
            ErrorMessageProvider.SetValueIsIntegerAccessor(expected);

            ErrorMessageProvider.ValueIsIntegerAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueIsNumberAccessor() {
            Func<string, string, string> expected = (c, v) => c + v;
            ErrorMessageProvider.SetValueIsNumberAccessor(expected);

            ErrorMessageProvider.ValueIsNumberAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueIsDateTimeAccessor() {
            Func<string, string, string> expected = (c, v) => c + v;
            ErrorMessageProvider.SetValueIsDateTimeAccessor(expected);

            ErrorMessageProvider.ValueIsDateTimeAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueLengthGreaterOrEqualAccessor() {
            Func<string, string, long, string> expected = (c, v, min) => c + v + min;
            ErrorMessageProvider.SetValueLengthGreaterOrEqualAccessor(expected);

            ErrorMessageProvider.ValueLengthGreaterOrEqualAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueLengthLessOrEqualAccessor() {
            Func<string, string, long, string> expected = (c, v, max) => c + v + max;
            ErrorMessageProvider.SetValueLengthLessOrEqualAccessor(expected);

            ErrorMessageProvider.ValueLengthLessOrEqualAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueLengthInRangeAccessor() {
            Func<string, string, long, long, string> expected = (c, v, min, max) => c + v + min + max;
            ErrorMessageProvider.SetValueLengthInRangeAccessor(expected);

            ErrorMessageProvider.ValueLengthInRangeAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueMatchRegexAccessor() {
            Func<string, string, string> expected = (c, v) => c + v;
            ErrorMessageProvider.SetValueMatchRegexAccessor(expected);

            ErrorMessageProvider.ValueMatchRegexAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueIsEmailAccessor() {
            Func<string, string, string> expected = (c, v) => c + v;
            ErrorMessageProvider.SetValueIsEmailAccessor(expected);

            ErrorMessageProvider.ValueIsEmailAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueIsMobilePhoneAccessor() {
            Func<string, string, MobilePhoneFormats, string> expected = (c, v, f) => c + v + f;
            ErrorMessageProvider.SetValueIsMobilePhoneAccessor(expected);

            ErrorMessageProvider.ValueIsMobilePhoneAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueIsIdCardAccessor() {
            Func<string, string, IdCardTypes, string> expected = (c, v, t) => c + v + t;
            ErrorMessageProvider.SetValueIsIdCardAccessor(expected);

            ErrorMessageProvider.ValueIsIdCardAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueCompareAnotherColumnValueAccessor() {
            Func<string, string, string, string, string> expected = (c, v, cc, cv) => c + v + cc + cv;
            ErrorMessageProvider.SetValueCompareAnotherColumnValueAccessor(expected);

            ErrorMessageProvider.ValueCompareAnotherColumnValueAccessor.Should().BeSameAs(expected);
        }

        [Test]
        public void SetValueLessThanAnotherColumnValueAccessor() {
            Func<string, string, string, string, bool, string> expected = (c, v, cc, cv, b) => c + v + cc + cv + b;
            ErrorMessageProvider.SetValueLessThanAnotherColumnValueAccessor(expected);

            ErrorMessageProvider.ValueLessThanAnotherColumnValueAccessor.Should().BeSameAs(expected);
        }
    }
}
