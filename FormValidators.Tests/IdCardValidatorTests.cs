using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests {
    [TestFixture]
    public class IdCardValidatorTests {
        [SetUp]
        public void Setup() {
        }

        [TestCase("A188222138", true)] // ��������Ҩk��
        [TestCase("A213788383", true)] // ��������Ҥk��
        [TestCase("AA00036116", false)] // �O�W�a�ϩ~�d�Ҩk��
        [TestCase("AB90001505", false)] // �O�W�a�ϩ~�d�Ҥk��
        [TestCase("AC02065646", false)] // �~���~�d�Ҩk��
        [TestCase("AD01915363", false)] // �~���~�d�Ҥk��
        [TestCase("AY90001505", false)] // �C���k��
        [TestCase("AX00036116", false)] // �C���k��
        [TestCase("A126", false)] // �D10�X
        [TestCase("AE88222138", false)] // �ĤG�X���~
        [TestCase("A111111111", false)] // �榡���~
        public void ValidateNational_ReturnValue_AreEqual(string id, bool expected) {
            string column = "�������";

            IdCardValidator validator = new IdCardValidator(column, id, IdCardTypes.National);
            bool actual = validator.Validate();

            Assert.AreEqual(actual, expected);
        }

        [TestCase("A188222138", false)] // ��������Ҩk��
        [TestCase("A213788383", false)] // ��������Ҥk��
        [TestCase("AA00036116", true)] // �O�W�a�ϩ~�d�Ҩk��
        [TestCase("AB90001505", true)] // �O�W�a�ϩ~�d�Ҥk��
        [TestCase("AC02065646", false)] // �~���~�d�Ҩk��
        [TestCase("AD01915363", false)] // �~���~�d�Ҥk��
        [TestCase("AY90001505", false)] // �C���k��
        [TestCase("AX00036116", false)] // �C���k��
        [TestCase("A126", false)] // �D10�X
        [TestCase("AE88222138", false)] // �ĤG�X���~
        [TestCase("A111111111", false)] // �榡���~
        public void ValidateResident_ReturnValue_AreEqual(string id, bool expected) {
            string column = "�������";

            IdCardValidator validator = new IdCardValidator(column, id, IdCardTypes.Resident);
            bool actual = validator.Validate();

            Assert.AreEqual(actual, expected);
        }

        [TestCase("A188222138", false)] // ��������Ҩk��
        [TestCase("A213788383", false)] // ��������Ҥk��
        [TestCase("AA00036116", false)] // �O�W�a�ϩ~�d�Ҩk��
        [TestCase("AB90001505", false)] // �O�W�a�ϩ~�d�Ҥk��
        [TestCase("AC02065646", true)] // �~���~�d�Ҩk��
        [TestCase("AD01915363", true)] // �~���~�d�Ҥk��
        [TestCase("AY90001505", false)] // �C���k��
        [TestCase("AX00036116", false)] // �C���k��
        [TestCase("A126", false)] // �D10�X
        [TestCase("AE88222138", false)] // �ĤG�X���~
        [TestCase("A111111111", false)] // �榡���~
        public void ValidateAlienResident_ReturnValue_AreEqual(string id, bool expected) {
            string column = "�������";

            IdCardValidator validator = new IdCardValidator(column, id, IdCardTypes.AlienResident);
            bool actual = validator.Validate();

            Assert.AreEqual(actual, expected);
        }

        [TestCase("A188222138", false)] // ��������Ҩk��
        [TestCase("A213788383", false)] // ��������Ҥk��
        [TestCase("AA00036116", false)] // �O�W�a�ϩ~�d�Ҩk��
        [TestCase("AB90001505", false)] // �O�W�a�ϩ~�d�Ҥk��
        [TestCase("AC02065646", false)] // �~���~�d�Ҩk��
        [TestCase("AD01915363", false)] // �~���~�d�Ҥk��
        [TestCase("AY90001505", true)] // �C���k��
        [TestCase("AX00036116", true)] // �C���k��
        [TestCase("A126", false)] // �D10�X
        [TestCase("AE88222138", false)] // �ĤG�X���~
        [TestCase("A111111111", false)] // �榡���~
        public void ValidateHomeless_ReturnValue_AreEqual(string id, bool expected) {
            string column = "�������";

            IdCardValidator validator = new IdCardValidator(column, id, IdCardTypes.Homeless);
            bool actual = validator.Validate();

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void ErrorMessage_Value_AreEqual() {
            string column = "�������";
            string format = "{0}IdentityNumber";
            string expected = string.Format(format, column);

            IdCardValidator validator = new IdCardValidator(column, "123", IdCardTypes.All, format);
            validator.Validate();

            Assert.AreEqual(validator.ErrorMessage, expected);
        }
    }
}