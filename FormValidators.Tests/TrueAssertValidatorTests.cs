﻿using System;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class TrueAssertValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase(true)]
        [TestCase(false)]
        public void Validate_ReturnValue_IsTrue(bool value) {
            TrueAssertValidator validator = new TrueAssertValidator(value, "");
            bool actual = validator.Validate() == value;

            Assert.IsTrue(actual);
        }

        [Test]
        public void ErrorMessage_Value_AreEqual() {
            string expected = "測試TrueAssert";
            TrueAssertValidator validator = new TrueAssertValidator(false, expected);
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, expected);
        }

        [Test]
        public void Predicate_Exception_Timing() {
            int dividend = 0;
            int division = 1;

            Assert.DoesNotThrow(() => new TrueAssertValidator(() => (division / dividend) == 0, ""));

            Assert.Throws<DivideByZeroException>(() => new TrueAssertValidator(() => (division / dividend) == 0, "").Validate());
        }
    }
}