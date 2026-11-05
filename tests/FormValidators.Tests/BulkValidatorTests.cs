using System;
using System.Collections.Generic;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class BulkValidatorTests {
    [Test]
    public void Validate_WhenAllValidatorsAreTrue_ReturnsTrue() {
        BulkValidator validators = [
            new TrueAssertValidator(true, ""),
            new TrueAssertValidator(true, ""),
            new TrueAssertValidator(true, "")
        ];

        Assert.That(validators.Validate(), Is.True);
    }

    [Test]
    public void Validate_WhenAnyValidatorIsFalse_ReturnsFalse() {
        BulkValidator validators = [
            new TrueAssertValidator(true, ""),
            new TrueAssertValidator(false, ""),
            new TrueAssertValidator(true, "")
        ];

        Assert.That(validators.Validate(), Is.False);
    }

    [Test]
    public void Validate_WhenAllValidatorsAreFalse_ReturnsFalse() {
        BulkValidator validators = [
            new TrueAssertValidator(false, ""),
            new TrueAssertValidator(false, ""),
            new TrueAssertValidator(false, "")
        ];

        Assert.That(validators.Validate(), Is.False);
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCombinedErrorMessage() {
        IFormValidator validate1 = new TrueAssertValidator(false, "1");
        IFormValidator validate2 = new TrueAssertValidator(true, "2");
        IFormValidator validate3 = new TrueAssertValidator(false, "3");

        BulkValidator validators = [
            validate1,
            validate2,
            validate3
        ];

        validators.Validate();

        Assert.That(validators.ErrorMessage, Is.EqualTo($"{validate1.ErrorMessage}<br />{validate3.ErrorMessage}"));
    }

    [Test]
    public void ErrorMessageWithBR_WhenValidationFails_ReturnsMessageWithHtmlBreak() {
        IFormValidator validate1 = new TrueAssertValidator(false, "1");
        IFormValidator validate2 = new TrueAssertValidator(true, "2");
        IFormValidator validate3 = new TrueAssertValidator(false, "3");

        BulkValidator validators = [
            validate1,
            validate2,
            validate3
        ];
        validators.Validate();

        string excepted = $"{validate1.ErrorMessage}<br />{validate3.ErrorMessage}";

        Assert.That(validators.ErrorMessageWithBR, Is.EqualTo(excepted));
    }

    [Test]
    public void ErrorMessageWithLF_WhenValidationFails_ReturnsMessageWithLineFeed() {
        IFormValidator validate1 = new TrueAssertValidator(false, "1");
        IFormValidator validate2 = new TrueAssertValidator(true, "2");
        IFormValidator validate3 = new TrueAssertValidator(false, "3");

        BulkValidator validators = [
            validate1,
            validate2,
            validate3
        ];
        validators.Validate();

        string excepted = $"{validate1.ErrorMessage}\n{validate3.ErrorMessage}";

        Assert.That(validators.ErrorMessageWithLF, Is.EqualTo(excepted));
    }

    [Test]
    public void ErrorMessageWithNewLine_WhenValidationFails_ReturnsMessageWithEnvironmentNewLine() {
        IFormValidator validate1 = new TrueAssertValidator(false, "1");
        IFormValidator validate2 = new TrueAssertValidator(true, "2");
        IFormValidator validate3 = new TrueAssertValidator(false, "3");

        BulkValidator validators = [
            validate1,
            validate2,
            validate3
        ];
        validators.Validate();

        string excepted = $"{validate1.ErrorMessage}{Environment.NewLine}{validate3.ErrorMessage}";

        Assert.That(validators.ErrorMessageWithNewLine, Is.EqualTo(excepted));
    }

    [Test]
    public void Validate_WhenStoppedIfFailIsSetAndAllTrue_ReturnsTrue() {
        BulkValidator validators = new(true) {
            new TrueAssertValidator(true, ""),
            new TrueAssertValidator(true, ""),
            new TrueAssertValidator(true, "")
        };

        Assert.That(validators.Validate(), Is.True);
    }

    [Test]
    public void Validate_WhenStoppedIfFailIsSetAndAnyFalse_ReturnsFalse() {
        BulkValidator validators = new(true) {
            new TrueAssertValidator(true, ""),
            new TrueAssertValidator(false, ""),
            new TrueAssertValidator(true, "")
        };

        Assert.That(validators.Validate(), Is.False);
    }

    [Test]
    public void Validate_WhenStoppedIfFailIsSetAndAllFalse_ReturnsFalse() {
        BulkValidator validators = new(true) {
            new TrueAssertValidator(false, ""),
            new TrueAssertValidator(false, ""),
            new TrueAssertValidator(false, "")
        };

        Assert.That(validators.Validate(), Is.False);
    }

    [Test]
    public void ErrorMessage_WhenStoppedIfFailIsSetAndValidationFails_ReturnsFirstErrorMessage() {
        IFormValidator validate1 = new TrueAssertValidator(false, "1");
        IFormValidator validate2 = new TrueAssertValidator(true, "2");
        IFormValidator validate3 = new TrueAssertValidator(false, "3");
        BulkValidator validators = new(true) {
            validate1,
            validate2,
            validate3
        };
        validators.Validate();

        Assert.That(validators.ErrorMessage, Is.EqualTo(validate1.ErrorMessage));
    }

    [Test]
    public void Constructor_NullConfigure_ThrowsArgumentNullException() {
        ArgumentNullException? exception = Assert.Throws<ArgumentNullException>(() => new BulkValidator((Action<ValidatorConfiguration>)null!));

        Assert.That(exception?.ParamName, Is.EqualTo("configure"));
    }

    [Test]
    public void ErrorMessages_AfterRevalidate_ReflectsLatestResult() {
        bool isValid = false;
        BulkValidator validators = [
            new TrueAssertValidator(() => isValid, "1")
        ];
        IReadOnlyCollection<string> messages = validators.ErrorMessages;

        validators.Validate();
        int failedCount = messages.Count;
        isValid = true;
        validators.Validate();

        using (Assert.EnterMultipleScope()) {
            Assert.That(failedCount, Is.EqualTo(1));
            Assert.That(validators.ErrorMessages, Is.Empty);
            Assert.That(validators.ErrorMessages, Is.SameAs(messages));
        }
    }

    [Test]
    public void ErrorMessages_WhenNestedBulkWithStoppedIfFail_CollectsInnerFirstErrorAndOuterErrors() {
        BulkValidator validators = [
            new BulkValidator(true) {
                new TrueAssertValidator(true, "1"),
                new TrueAssertValidator(false, "2"),
                new TrueAssertValidator(false, "3")
            },
            new TrueAssertValidator(true, "4"),
            new TrueAssertValidator(false, "5"),
            new TrueAssertValidator(false, "6")
        ];

        validators.Validate();

        Assert.That(validators.ErrorMessages, Is.EqualTo(new[] { "2", "5", "6" }));
    }

    [Test]
    public void ErrorMessages_WhenOuterStoppedIfFailAndInnerBulkFails_StopsAfterInnerBulk() {
        BulkValidator validators = new(true) {
            new BulkValidator {
                new TrueAssertValidator(false, "1"),
                new TrueAssertValidator(false, "2")
            },
            new TrueAssertValidator(false, "3")
        };

        validators.Validate();

        Assert.That(validators.ErrorMessages, Is.EqualTo(new[] { "1", "2" }));
    }
}
