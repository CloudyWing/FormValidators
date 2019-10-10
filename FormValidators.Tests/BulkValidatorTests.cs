using System;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class BulkValidatorTests {
        [SetUp]
        public void SetUp() { }

        [Test]
        public void Validate_AllTrue_IsTrue() {
            BulkValidator validators = new BulkValidator {
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(true, "")
            };

            Assert.IsTrue(validators.Validate());
        }

        [Test]
        public void Validate_AnyFalse_IsFalse() {
            BulkValidator validators = new BulkValidator {
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(false, ""),
                new TrueAssertValidator(true, "")
            };

            Assert.IsFalse(validators.Validate());
        }

        [Test]
        public void Validate_AllFalse_IsFalse() {
            BulkValidator validators = new BulkValidator {
                new TrueAssertValidator(false, ""),
                new TrueAssertValidator(false, ""),
                new TrueAssertValidator(false, "")
            };

            Assert.IsFalse(validators.Validate());
        }

        [Test]
        public void ErrorMessage_ErrorMessage_AreEqual() {
            IFormValidatable validate1 = new TrueAssertValidator(false, "1");
            IFormValidatable validate2 = new TrueAssertValidator(true, "2");
            IFormValidatable validate3 = new TrueAssertValidator(false, "3");

            BulkValidator validators = new BulkValidator {
                validate1, validate2, validate3
            };
            validators.Validate();

            Assert.AreEqual(validators.ErrorMessage, $"{validate1.ErrorMessage}<br />{validate3.ErrorMessage}");
        }

        [Test]
        public void ErrorMessage_ErrorMessageWithBR_AreEqual() {
            IFormValidatable validate1 = new TrueAssertValidator(false, "1");
            IFormValidatable validate2 = new TrueAssertValidator(true, "2");
            IFormValidatable validate3 = new TrueAssertValidator(false, "3");

            BulkValidator validators = new BulkValidator {
                validate1, validate2, validate3
            };
            validators.Validate();

            Assert.AreEqual(validators.ErrorMessageWithBreak, $"{validate1.ErrorMessage}<br />{validate3.ErrorMessage}");
        }

        [Test]
        public void ErrorMessage_ErrorMessageWithLF_AreEqual() {
            IFormValidatable validate1 = new TrueAssertValidator(false, "1");
            IFormValidatable validate2 = new TrueAssertValidator(true, "2");
            IFormValidatable validate3 = new TrueAssertValidator(false, "3");

            BulkValidator validators = new BulkValidator {
                validate1, validate2, validate3
            };
            validators.Validate();

            Assert.AreEqual(validators.ErrorMessageWithLF, $"{validate1.ErrorMessage}\n{validate3.ErrorMessage}");
        }

        [Test]
        public void ErrorMessage_ErrorMessageWithNewLine_AreEqual() {
            IFormValidatable validate1 = new TrueAssertValidator(false, "1");
            IFormValidatable validate2 = new TrueAssertValidator(true, "2");
            IFormValidatable validate3 = new TrueAssertValidator(false, "3");

            BulkValidator validators = new BulkValidator {
                validate1, validate2, validate3
            };
            validators.Validate();

            Assert.AreEqual(validators.ErrorMessageWithNewLine, $"{validate1.ErrorMessage}{Environment.NewLine}{validate3.ErrorMessage}");
        }

        [Test]
        public void ValidateStoppedIfFail_AllTrue_IsTrue() {
            BulkValidator validators = new BulkValidator(true) {
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(true, "")
            };

            Assert.IsTrue(validators.Validate());
        }

        [Test]
        public void ValidateStoppedIfFail_AnyFalse_IsFalse() {
            BulkValidator validators = new BulkValidator(true) {
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(false, ""),
                new TrueAssertValidator(true, "")
            };

            Assert.IsFalse(validators.Validate());
        }

        [Test]
        public void ValidateStoppedIfFail_AllFalse_IsFalse() {
            BulkValidator validators = new BulkValidator(true) {
                new TrueAssertValidator(false, ""),
                new TrueAssertValidator(false, ""),
                new TrueAssertValidator(false, "")
            };

            Assert.IsFalse(validators.Validate());
        }

        [Test]
        public void ErrorMessageStoppedIfFail_ErrorMessage_AreEqual() {
            IFormValidatable validate1 = new TrueAssertValidator(false, "1");
            IFormValidatable validate2 = new TrueAssertValidator(true, "2");
            IFormValidatable validate3 = new TrueAssertValidator(false, "3");
            BulkValidator validators = new BulkValidator(true) {
                validate1, validate2, validate3
            };
            validators.Validate();

            Assert.AreEqual(validators.ErrorMessage, validate1.ErrorMessage);
        }
    }
}