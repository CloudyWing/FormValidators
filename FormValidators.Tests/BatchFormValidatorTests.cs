using System;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {

    [TestFixture]
    public class FormValidatorCollectionTests {

        [SetUp]
        public void SetUp() { }

        [Test]
        public void Validate_AllTrue_IsTrue() {
            BatchFormValidator batchs = new BatchFormValidator {
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(true, "")
            };

            Assert.IsTrue(batchs.Validate());
        }

        [Test]
        public void Validate_AnyFalse_IsFalse() {
            BatchFormValidator batchs = new BatchFormValidator {
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(false, ""),
                new TrueAssertValidator(true, "")
            };

            Assert.IsFalse(batchs.Validate());
        }
        
        [Test]
        public void Validate_AllFalse_IsFalse() {
            BatchFormValidator batchs = new BatchFormValidator {
                new TrueAssertValidator(false, ""),
                new TrueAssertValidator(false, ""),
                new TrueAssertValidator(false, "")
            };

            Assert.IsFalse(batchs.Validate());
        }
        
        [Test]
        public void ErrorMessage_ErrorMessage_AreEqual() {
            IFormValidatable validate1 = new TrueAssertValidator(false, "1");
            IFormValidatable validate2 = new TrueAssertValidator(true, "2");
            IFormValidatable validate3 = new TrueAssertValidator(false, "3");
            BatchFormValidator batchs = new BatchFormValidator {
                validate1, validate2, validate3
            };
            batchs.Validate();

            Assert.AreEqual(batchs.ErrorMessage, $"{validate1.ErrorMessage}<br />{validate3.ErrorMessage}");
        }
        
        [Test]
        public void ErrorMessage_ErrorMessageWithBR_AreEqual() {
            IFormValidatable validate1 = new TrueAssertValidator(false, "1");
            IFormValidatable validate2 = new TrueAssertValidator(true, "2");
            IFormValidatable validate3 = new TrueAssertValidator(false, "3");
            BatchFormValidator batchs = new BatchFormValidator {
                validate1, validate2, validate3
            };
            batchs.Validate();

            Assert.AreEqual(batchs.ErrorMessageWithBR, $"{validate1.ErrorMessage}<br />{validate3.ErrorMessage}");
        }
        
        [Test]
        public void ErrorMessage_ErrorMessageWithLF_AreEqual() {
            IFormValidatable validate1 = new TrueAssertValidator(false, "1");
            IFormValidatable validate2 = new TrueAssertValidator(true, "2");
            IFormValidatable validate3 = new TrueAssertValidator(false, "3");
            BatchFormValidator batchs = new BatchFormValidator {
                validate1, validate2, validate3
            };
            batchs.Validate();

            Assert.AreEqual(batchs.ErrorMessageWithLF, $"{validate1.ErrorMessage}\n{validate3.ErrorMessage}");
        }
        
        [Test]
        public void ErrorMessage_ErrorMessageWithNewLine_AreEqual() {
            IFormValidatable validate1 = new TrueAssertValidator(false, "1");
            IFormValidatable validate2 = new TrueAssertValidator(true, "2");
            IFormValidatable validate3 = new TrueAssertValidator(false, "3");
            BatchFormValidator batchs = new BatchFormValidator {
                validate1, validate2, validate3
            };
            batchs.Validate();

            Assert.AreEqual(batchs.ErrorMessageWithNewLine, $"{validate1.ErrorMessage}{Environment.NewLine}{validate3.ErrorMessage}");
        }
    }
}
