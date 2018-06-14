using System;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {

    [TestFixture]
    public class BatchStopIfErrorValidatorTests {

        [SetUp]
        public void SetUp() { }

        [Test]
        public void Validate_AllTrue_IsTrue() {
            BatchStopIfErrorValidator batchs = new BatchStopIfErrorValidator {
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(true, "")
            };

            Assert.IsTrue(batchs.Validate());
        }

        [Test]
        public void Validate_AnyFalse_IsFalse() {
            BatchStopIfErrorValidator batchs = new BatchStopIfErrorValidator {
                new TrueAssertValidator(true, ""),
                new TrueAssertValidator(false, ""),
                new TrueAssertValidator(true, "")
            };

            Assert.IsFalse(batchs.Validate());
        }
        
        [Test]
        public void Validate_AllFalse_IsFalse() {
            BatchStopIfErrorValidator batchs = new BatchStopIfErrorValidator {
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
            BatchStopIfErrorValidator batchs = new BatchStopIfErrorValidator {
                validate1, validate2, validate3
            };
            batchs.Validate();

            Assert.AreEqual(batchs.ErrorMessage, validate1.ErrorMessage);
        }
    }
}
