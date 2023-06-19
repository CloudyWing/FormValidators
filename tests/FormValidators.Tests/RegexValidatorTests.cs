﻿using CloudyWing.FormValidators.Core;
using FluentAssertions;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class RegexValidatorTests {
        [TestCase(null, "", true)]
        [TestCase("", "", true)]
        [TestCase(" ", "", true)]
        [TestCase("1234567", @"^\d{7}$", true)]
        [TestCase("a123456", @"^\d{7}$", false)]
        public void Validate_ReturnValue_AreEqual(string value, string pattern, bool isValid) {
            RegexValidator validator = new RegexValidator("", value, pattern);

            validator.Validate().Should().Be(isValid);
        }

        [Test]
        public void ErrorMessage_DefaultMessage_AreEqual() {
            string column = "測試欄位";
            string value = "123456";
            string expected = ErrorMessageProvider.ValueMatchRegexAccessor(column, value);

            RegexValidator validator = new RegexValidator(column, value, @"\D+");
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }

        [Test]
        public void ErrorMessage_CustomMessage_AreEqual() {
            string column = "測試欄位";
            string value = "123456";
            string expected = column + value;

            RegexValidator validator = new RegexValidator(column, value, @"\D+", (c, v) => c + v);
            validator.Validate();

            validator.ErrorMessage.Should().Be(expected);
        }
    }
}
