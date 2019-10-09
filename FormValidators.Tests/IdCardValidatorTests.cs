using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class IdCardValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase("A188222138", true)] // 國民身份證男生
        [TestCase("A213788383", true)] // 國民身份證女生
        [TestCase("AA00036116", false)] // 臺灣地區居留證男生
        [TestCase("AB90001505", false)] // 臺灣地區居留證女生
        [TestCase("AC02065646", false)] // 外僑居留證男生
        [TestCase("AD01915363", false)] // 外僑居留證女生
        [TestCase("AY90001505", false)] // 遊民男生
        [TestCase("AX00036116", false)] // 遊民女生
        [TestCase("A126", false)] // 非10碼
        [TestCase("AE88222138", false)] // 第二碼錯誤
        [TestCase("A111111111", false)] // 格式錯誤
        public void ValidateNational_ReturnValue_AreEqual(string id, bool expected) {
            string column = "測試欄位";

            IdCardValidator validator = new IdCardValidator(column, id, IdCardTypes.National);
            bool actual = validator.Validate();

            Assert.AreEqual(actual, expected);
        }

        [TestCase("A188222138", false)] // 國民身份證男生
        [TestCase("A213788383", false)] // 國民身份證女生
        [TestCase("AA00036116", true)] // 臺灣地區居留證男生
        [TestCase("AB90001505", true)] // 臺灣地區居留證女生
        [TestCase("AC02065646", false)] // 外僑居留證男生
        [TestCase("AD01915363", false)] // 外僑居留證女生
        [TestCase("AY90001505", false)] // 遊民男生
        [TestCase("AX00036116", false)] // 遊民女生
        [TestCase("A126", false)] // 非10碼
        [TestCase("AE88222138", false)] // 第二碼錯誤
        [TestCase("A111111111", false)] // 格式錯誤
        public void ValidateResident_ReturnValue_AreEqual(string id, bool expected) {
            string column = "測試欄位";

            IdCardValidator validator = new IdCardValidator(column, id, IdCardTypes.Resident);
            bool actual = validator.Validate();

            Assert.AreEqual(actual, expected);
        }

        [TestCase("A188222138", false)] // 國民身份證男生
        [TestCase("A213788383", false)] // 國民身份證女生
        [TestCase("AA00036116", false)] // 臺灣地區居留證男生
        [TestCase("AB90001505", false)] // 臺灣地區居留證女生
        [TestCase("AC02065646", true)] // 外僑居留證男生
        [TestCase("AD01915363", true)] // 外僑居留證女生
        [TestCase("AY90001505", false)] // 遊民男生
        [TestCase("AX00036116", false)] // 遊民女生
        [TestCase("A126", false)] // 非10碼
        [TestCase("AE88222138", false)] // 第二碼錯誤
        [TestCase("A111111111", false)] // 格式錯誤
        public void ValidateAlienResident_ReturnValue_AreEqual(string id, bool expected) {
            string column = "測試欄位";

            IdCardValidator validator = new IdCardValidator(column, id, IdCardTypes.AlienResident);
            bool actual = validator.Validate();

            Assert.AreEqual(actual, expected);
        }

        [TestCase("A188222138", false)] // 國民身份證男生
        [TestCase("A213788383", false)] // 國民身份證女生
        [TestCase("AA00036116", false)] // 臺灣地區居留證男生
        [TestCase("AB90001505", false)] // 臺灣地區居留證女生
        [TestCase("AC02065646", false)] // 外僑居留證男生
        [TestCase("AD01915363", false)] // 外僑居留證女生
        [TestCase("AY90001505", true)] // 遊民男生
        [TestCase("AX00036116", true)] // 遊民女生
        [TestCase("A126", false)] // 非10碼
        [TestCase("AE88222138", false)] // 第二碼錯誤
        [TestCase("A111111111", false)] // 格式錯誤
        public void ValidateHomeless_ReturnValue_AreEqual(string id, bool expected) {
            string column = "測試欄位";

            IdCardValidator validator = new IdCardValidator(column, id, IdCardTypes.Homeless);
            bool actual = validator.Validate();

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void ErrorMessage_Value_AreEqual() {
            string column = "測試欄位";
            string format = "{0}IdentityNumber";
            string expected = string.Format(format, column);

            IdCardValidator validator = new IdCardValidator(column, "123", IdCardTypes.All, format);
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, expected);
        }
    }
}