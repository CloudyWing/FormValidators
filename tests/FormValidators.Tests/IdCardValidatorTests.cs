using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class IdCardValidatorTests {
    [TestCase("A188222138", true)] // 國民身份證號男生
    [TestCase("A213788383", true)] // 國民身份證號女生
    [TestCase("AA00036116", false)] // 臺灣地區居留證統一證號男生
    [TestCase("AB90001505", false)] // 臺灣地區居留證統一證號女生
    [TestCase("AC02065646", false)] // 外僑居留證統一證號男生
    [TestCase("AD01915363", false)] // 外僑居留證統一證號女生
    [TestCase("AY90001505", false)] // 遊民證號男生
    [TestCase("AX00036116", false)] // 遊民證號女生
    [TestCase("A894677652", false)] // 新式外來人口統一證號男生
    [TestCase("A926268625", false)] // 新式外來人口統一證號女生
    [TestCase("A126", false)] // 非10碼
    [TestCase("AE88222138", false)] // 第二碼錯誤
    [TestCase("A111111111", false)] // 格式錯誤
    [TestCase("A111111111", false)] // 格式錯誤
    public void Validate_WhenNationalIdIsUsed_ReturnsExpectedResult(string id, bool expected) {
        string column = "測試欄位";

        IdCardValidator validator = new(column, id, IdCardTypes.National);
        bool actual = validator.Validate();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase("A188222138", false)] // 國民身份證號男生
    [TestCase("A213788383", false)] // 國民身份證號女生
    [TestCase("AA00036116", true)] // 臺灣地區居留證統一證號男生
    [TestCase("AB90001505", true)] // 臺灣地區居留證統一證號女生
    [TestCase("AC02065646", false)] // 外僑居留證統一證號男生
    [TestCase("AD01915363", false)] // 外僑居留證統一證號女生
    [TestCase("AY90001505", false)] // 遊民證號男生
    [TestCase("AX00036116", false)] // 遊民證號女生
    [TestCase("A894677652", false)] // 新式外來人口統一證號男生
    [TestCase("A926268625", false)] // 新式外來人口統一證號女生
    [TestCase("A126", false)] // 非10碼
    [TestCase("AE88222138", false)] // 第二碼錯誤
    [TestCase("A111111111", false)] // 格式錯誤
    public void Validate_WhenResidentIdIsUsed_ReturnsExpectedResult(string id, bool expected) {
        string column = "測試欄位";

        IdCardValidator validator = new(column, id, IdCardTypes.Resident);
        bool actual = validator.Validate();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase("A188222138", false)] // 國民身份證號男生
    [TestCase("A213788383", false)] // 國民身份證號女生
    [TestCase("AA00036116", false)] // 臺灣地區居留證統一證號男生
    [TestCase("AB90001505", false)] // 臺灣地區居留證統一證號女生
    [TestCase("AC02065646", true)] // 外僑居留證統一證號男生
    [TestCase("AD01915363", true)] // 外僑居留證統一證號女生
    [TestCase("AY90001505", false)] // 遊民證號男生
    [TestCase("AX00036116", false)] // 遊民證號女生
    [TestCase("A894677652", false)] // 新式外來人口統一證號男生
    [TestCase("A926268625", false)] // 新式外來人口統一證號女生
    [TestCase("A126", false)] // 非10碼
    [TestCase("AE88222138", false)] // 第二碼錯誤
    [TestCase("A111111111", false)] // 格式錯誤
    public void Validate_WhenAlienResidentIdIsUsed_ReturnsExpectedResult(string id, bool expected) {
        string column = "測試欄位";

        IdCardValidator validator = new(column, id, IdCardTypes.AlienResident);
        bool actual = validator.Validate();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase("A188222138", false)] // 國民身份證號男生
    [TestCase("A213788383", false)] // 國民身份證號女生
    [TestCase("AA00036116", false)] // 臺灣地區居留證統一證號男生
    [TestCase("AB90001505", false)] // 臺灣地區居留證統一證號女生
    [TestCase("AC02065646", false)] // 外僑居留證統一證號男生
    [TestCase("AD01915363", false)] // 外僑居留證統一證號女生
    [TestCase("AY90001505", true)] // 遊民證號男生
    [TestCase("AX00036116", true)] // 遊民證號女生
    [TestCase("A894677652", false)] // 新式外來人口統一證號男生
    [TestCase("A926268625", false)] // 新式外來人口統一證號女生
    [TestCase("A126", false)] // 非10碼
    [TestCase("AE88222138", false)] // 第二碼錯誤
    [TestCase("A111111111", false)] // 格式錯誤
    public void Validate_WhenHomelessIdIsUsed_ReturnsExpectedResult(string id, bool expected) {
        string column = "測試欄位";

        IdCardValidator validator = new(column, id, IdCardTypes.Homeless);
        bool actual = validator.Validate();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase("A188222138", false)] // 國民身份證號男生
    [TestCase("A213788383", false)] // 國民身份證號女生
    [TestCase("AA00036116", false)] // 臺灣地區居留證統一證號男生
    [TestCase("AB90001505", false)] // 臺灣地區居留證統一證號女生
    [TestCase("AC02065646", false)] // 外僑居留證統一證號男生
    [TestCase("AD01915363", false)] // 外僑居留證統一證號女生
    [TestCase("AY90001505", false)] // 遊民證號男生
    [TestCase("AX00036116", false)] // 遊民證號女生
    [TestCase("A894677652", true)] // 新式外來人口統一證號男生
    [TestCase("A926268625", true)] // 新式外來人口統一證號女生
    [TestCase("A126", false)] // 非10碼
    [TestCase("AE88222138", false)] // 第二碼錯誤
    [TestCase("A111111111", false)] // 格式錯誤
    public void Validate_WhenNewResidentIdIsUsed_ReturnsExpectedResult(string id, bool expected) {
        string column = "測試欄位";

        IdCardValidator validator = new(column, id, IdCardTypes.NewResident);
        bool actual = validator.Validate();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "123";
        IdCardTypes types = IdCardTypes.All;
        string expected = ErrorMessageProvider.ValueIsIdCardAccessor(column, value, types);

        IdCardValidator validator = new(column, value, types);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "123";
        string expected = column + value + IdCardTypes.All;

        IdCardValidator validator = new(column, value, IdCardTypes.All, (c, v, f) => c + v + f);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }
}
