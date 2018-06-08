using System;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {

    [TestFixture]
    public class FormValidatorCollectionTests {

        [SetUp]
        public void SetUp() { }

        [Test]
        public void Validate_AllTrue_IsTrue() {
            FormValidatorCollection fvc = new FormValidatorCollection {
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(true, "")
            };

            Assert.IsTrue(fvc.Validate());
        }

        [Test]
        public void Validate_AnyFalse_IsFalse() {
            FormValidatorCollection fvc = new FormValidatorCollection {
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(false, ""),
                new TrueAssertValidator(true, "")
            };

            Assert.IsFalse(fvc.Validate());
        }
        
        [Test]
        public void Validate_AllFalse_IsFalse() {
            FormValidatorCollection fvc = new FormValidatorCollection {
                new TrueAssertValidator(false, ""),
                new TrueAssertValidator(false, ""),
                new TrueAssertValidator(false, "")
            };

            Assert.IsFalse(fvc.Validate());
        }
        
        [Test]
        public void ErrorMessage_ErrorMessage_AreEqual() {
            IFormValidatable validate1 = new TrueAssertValidator(false, "1");
            IFormValidatable validate2 = new TrueAssertValidator(true, "2");
            IFormValidatable validate3 = new TrueAssertValidator(false, "3");
            FormValidatorCollection fvc = new FormValidatorCollection {
                validate1, validate2, validate3
            };
            fvc.Validate();

            Assert.AreEqual(fvc.ErrorMessage, $"{validate1.ErrorMessage}<br />{validate3.ErrorMessage}");
        }
        
        [Test]
        public void ErrorMessage_ErrorMessageWithBR_AreEqual() {
            IFormValidatable validate1 = new TrueAssertValidator(false, "1");
            IFormValidatable validate2 = new TrueAssertValidator(true, "2");
            IFormValidatable validate3 = new TrueAssertValidator(false, "3");
            FormValidatorCollection fvc = new FormValidatorCollection {
                validate1, validate2, validate3
            };
            fvc.Validate();

            Assert.AreEqual(fvc.ErrorMessageWithBR, $"{validate1.ErrorMessage}<br />{validate3.ErrorMessage}");
        }
        
        [Test]
        public void ErrorMessage_ErrorMessageWithLF_AreEqual() {
            IFormValidatable validate1 = new TrueAssertValidator(false, "1");
            IFormValidatable validate2 = new TrueAssertValidator(true, "2");
            IFormValidatable validate3 = new TrueAssertValidator(false, "3");
            FormValidatorCollection fvc = new FormValidatorCollection {
                validate1, validate2, validate3
            };
            fvc.Validate();

            Assert.AreEqual(fvc.ErrorMessageWithLF, $"{validate1.ErrorMessage}\n{validate3.ErrorMessage}");
        }
        
        [Test]
        public void ErrorMessage_ErrorMessageWithNewLine_AreEqual() {
            IFormValidatable validate1 = new TrueAssertValidator(false, "1");
            IFormValidatable validate2 = new TrueAssertValidator(true, "2");
            IFormValidatable validate3 = new TrueAssertValidator(false, "3");
            FormValidatorCollection fvc = new FormValidatorCollection {
                validate1, validate2, validate3
            };
            fvc.Validate();

            Assert.AreEqual(fvc.ErrorMessageWithNewLine, $"{validate1.ErrorMessage}{Environment.NewLine}{validate3.ErrorMessage}");
        }
    }
}
