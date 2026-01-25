using System;
using NUnit.Framework;


namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class BulkValidatorTests {
    [Test]
    public void Validate_AllTrue_IsTrue() {
        BulkValidator validators = new BulkValidator {
            new TrueAssertValidator(true, ""),
            new TrueAssertValidator(true, ""),
            new TrueAssertValidator(true, "")
        };

        Assert.That(validators.Validate(), Is.True);
    }

    [Test]
    public void Validate_AnyFalse_IsFasle() {
        BulkValidator validators = new BulkValidator {
            new TrueAssertValidator(true, ""),
            new TrueAssertValidator(false, ""),
            new TrueAssertValidator(true, "")
        };

        Assert.That(validators.Validate(), Is.False);
    }

    [Test]
    public void Validate_AllFalse_IsFasle() {
        BulkValidator validators = new BulkValidator {
            new TrueAssertValidator(false, ""),
            new TrueAssertValidator(false, ""),
            new TrueAssertValidator(false, "")
        };

        Assert.That(validators.Validate(), Is.False);
    }

    [Test]
    public void ErrorMessage_ErrorMessage_AreEqual() {
        IFormValidator validate1 = new TrueAssertValidator(false, "1");
        IFormValidator validate2 = new TrueAssertValidator(true, "2");
        IFormValidator validate3 = new TrueAssertValidator(false, "3");

        BulkValidator validators = new BulkValidator {
            validate1, validate2, validate3
        };

        validators.Validate();

        Assert.That(validators.ErrorMessage, Is.EqualTo($"{validate1.ErrorMessage}<br />{validate3.ErrorMessage}"));
    }

    [Test]
    public void ErrorMessage_ErrorMessageWithBR_AreEqual() {
        IFormValidator validate1 = new TrueAssertValidator(false, "1");
        IFormValidator validate2 = new TrueAssertValidator(true, "2");
        IFormValidator validate3 = new TrueAssertValidator(false, "3");

        BulkValidator validators = new BulkValidator {
            validate1, validate2, validate3
        };
        validators.Validate();

        string excepted = $"{validate1.ErrorMessage}<br />{validate3.ErrorMessage}";

        Assert.That(validators.ErrorMessageWithBR, Is.EqualTo(excepted));
    }

    [Test]
    public void ErrorMessage_ErrorMessageWithLF_AreEqual() {
        IFormValidator validate1 = new TrueAssertValidator(false, "1");
        IFormValidator validate2 = new TrueAssertValidator(true, "2");
        IFormValidator validate3 = new TrueAssertValidator(false, "3");

        BulkValidator validators = new BulkValidator {
            validate1, validate2, validate3
        };
        validators.Validate();

        string excepted = $"{validate1.ErrorMessage}\n{validate3.ErrorMessage}";

        Assert.That(validators.ErrorMessageWithLF, Is.EqualTo(excepted));
    }

    [Test]
    public void ErrorMessage_ErrorMessageWithNewLine_AreEqual() {
        IFormValidator validate1 = new TrueAssertValidator(false, "1");
        IFormValidator validate2 = new TrueAssertValidator(true, "2");
        IFormValidator validate3 = new TrueAssertValidator(false, "3");

        BulkValidator validators = new BulkValidator {
            validate1, validate2, validate3
        };
        validators.Validate();

        string excepted = $"{validate1.ErrorMessage}{Environment.NewLine}{validate3.ErrorMessage}";

        Assert.That(validators.ErrorMessageWithNewLine, Is.EqualTo(excepted));
    }

    [Test]
    public void ValidateStoppedIfFail_AllTrue_IsTrue() {
        BulkValidator validators = new BulkValidator(true) {
            new TrueAssertValidator(true, ""),
            new TrueAssertValidator(true, ""),
            new TrueAssertValidator(true, "")
        };

        Assert.That(validators.Validate(), Is.True);
    }

    [Test]
    public void ValidateStoppedIfFail_AnyFalse_IsFalse() {
        BulkValidator validators = new BulkValidator(true) {
            new TrueAssertValidator(true, ""),
            new TrueAssertValidator(false, ""),
            new TrueAssertValidator(true, "")
        };

        Assert.That(validators.Validate(), Is.False);
    }

    [Test]
    public void ValidateStoppedIfFail_AllFalse_IsFalse() {
        BulkValidator validators = new BulkValidator(true) {
            new TrueAssertValidator(false, ""),
            new TrueAssertValidator(false, ""),
            new TrueAssertValidator(false, "")
        };

        Assert.That(validators.Validate(), Is.False);
    }

    [Test]
    public void ErrorMessageStoppedIfFail_ErrorMessage_AreEqual() {
        IFormValidator validate1 = new TrueAssertValidator(false, "1");
        IFormValidator validate2 = new TrueAssertValidator(true, "2");
        IFormValidator validate3 = new TrueAssertValidator(false, "3");
        BulkValidator validators = new BulkValidator(true) {
            validate1, validate2, validate3
        };
        validators.Validate();

        Assert.That(validators.ErrorMessage, Is.EqualTo(validate1.ErrorMessage));
    }
}
