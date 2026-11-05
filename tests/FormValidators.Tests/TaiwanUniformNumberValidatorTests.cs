using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class TaiwanUniformNumberValidatorTests {
    [TestCase(null, true)]
    [TestCase("", true)]
    [TestCase("22099131", true)] // 台灣積體電路製造股份有限公司
    [TestCase("96979933", true)] // 中華電信股份有限公司
    [TestCase("04541302", true)] // 鴻海精密工業股份有限公司
    [TestCase("12345675", true)] // 第 7 碼為 7，加權和為 39，加 1 後可被 10 整除
    [TestCase("00000119", true)] // 加權和為 15，只符合可被 5 整除的新制
    [TestCase("00000378", true)] // 第 7 碼為 7，加權和為 24，加 1 後只符合可被 5 整除的新制
    [TestCase("22099132", false)]
    [TestCase("00000007", false)]
    [TestCase("2209913", false)]
    [TestCase("220991311", false)]
    [TestCase("2209913a", false)]
    [TestCase("２２０９９１３１", false)]
    [TestCase("22099131\n", false)]
    public void Validate_WithVariousNumbers_ReturnsExpectedResult(string? value, bool isValid) {
        TaiwanUniformNumberValidator validator = new("", value);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        TaiwanUniformNumberValidator validator = new("統一編號", "12345678");

        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("「統一編號」必須為正確的統一編號。"));
    }

    [Test]
    public void ValidationProviderTaiwanUniformNumber_WithMessageFormat_ReturnsFormattedMessage() {
        ValidationProvider provider = new();

        TaiwanUniformNumberValidator validator = provider.TaiwanUniformNumber("{0}錯誤")("統一編號", "12345678");
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("統一編號錯誤"));
    }
}
