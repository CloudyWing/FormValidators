using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class PhoneValidatorTests {
    [TestCase(null)]
    [TestCase("")]
    [TestCase("0223456789")]
    [TestCase("02-2345-6789")]
    [TestCase("02 2345 6789")]
    [TestCase("(02)2345-6789")]
    [TestCase("(02) 2345-6789")]
    [TestCase("03-345-6789")]
    [TestCase("04-2345-6789")]
    [TestCase("049-234-5678")]
    [TestCase("037-123456")]
    [TestCase("089-123456")]
    [TestCase("0836-12345")]
    [TestCase("07-123-4567")]
    public void Validate_TaiwanLandline_ReturnsTrue(string? value) {
        PhoneValidator validator = new("", value);

        Assert.That(validator.Validate(), Is.True);
    }

    [TestCase("0912345678")] // 手機
    [TestCase("0912-345-678")]
    [TestCase("0800-123-456")] // 免付費電話
    [TestCase("+886-2-2345-6789")]
    [TestCase("02-2345-6789#123")]
    [TestCase("012345678")] // 第二碼不是區碼
    [TestCase("03-3456-7890")] // 03 只有 9 碼
    [TestCase("02-234-567")] // 碼數不足
    [TestCase("02--2345-6789")]
    [TestCase("02-2345-67-89")]
    [TestCase("-0223456789")]
    [TestCase("0223456789-")]
    [TestCase("(02-2345-6789")]
    [TestCase("()2345-6789")]
    [TestCase("０２２３４５６７８９")]
    [TestCase("0223456789\n")]
    public void Validate_NotTaiwanLandline_ReturnsFalse(string value) {
        PhoneValidator validator = new("", value);

        Assert.That(validator.Validate(), Is.False);
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        PhoneValidator validator = new("電話", "123");

        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("「電話」必須為正確市話號碼格式。"));
    }

    [Test]
    public void ValidationProviderPhone_WithCustomAccessor_ReturnsCustomMessage() {
        ValidationProvider provider = new();

        PhoneValidator validator = provider.Phone((c, v) => c + v)("電話", "123");
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("電話123"));
    }
}
