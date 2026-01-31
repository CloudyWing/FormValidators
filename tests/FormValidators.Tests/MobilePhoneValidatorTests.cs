using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class MobilePhoneValidatorTests {
    [TestCase(null, MobilePhoneFormats.AllowContainDashes, true)]
    [TestCase(null, MobilePhoneFormats.AllowWithoutDashes, true)]
    [TestCase(null, MobilePhoneFormats.All, true)]
    [TestCase("", MobilePhoneFormats.AllowContainDashes, true)]
    [TestCase("", MobilePhoneFormats.AllowWithoutDashes, true)]
    [TestCase("", MobilePhoneFormats.All, true)]
    [TestCase("0912345678", MobilePhoneFormats.AllowContainDashes, false)]
    [TestCase("0912345678", MobilePhoneFormats.AllowWithoutDashes, true)]
    [TestCase("0912345678", MobilePhoneFormats.All, true)]
    [TestCase("0912-345678", MobilePhoneFormats.AllowContainDashes, false)]
    [TestCase("0912-345678", MobilePhoneFormats.AllowWithoutDashes, false)]
    [TestCase("0912-345678", MobilePhoneFormats.All, true)]
    [TestCase("0912-345-678", MobilePhoneFormats.AllowContainDashes, true)]
    [TestCase("0912-345-678", MobilePhoneFormats.AllowWithoutDashes, false)]
    [TestCase("0912-345-678", MobilePhoneFormats.All, true)]
    [TestCase("09123456789", MobilePhoneFormats.AllowContainDashes, false)]
    [TestCase("09123456789", MobilePhoneFormats.AllowWithoutDashes, false)]
    [TestCase("09123456789", MobilePhoneFormats.All, false)]
    [TestCase("091234567", MobilePhoneFormats.AllowContainDashes, false)]
    [TestCase("091234567", MobilePhoneFormats.AllowWithoutDashes, false)]
    [TestCase("091234567", MobilePhoneFormats.All, false)]
    [TestCase("0812345678", MobilePhoneFormats.AllowContainDashes, false)]
    [TestCase("0812345678", MobilePhoneFormats.AllowWithoutDashes, false)]
    [TestCase("0812345678", MobilePhoneFormats.All, false)]
    [TestCase("1912345678", MobilePhoneFormats.AllowContainDashes, false)]
    [TestCase("1912345678", MobilePhoneFormats.AllowWithoutDashes, false)]
    [TestCase("1912345678", MobilePhoneFormats.All, false)]
    public void Validate_WhenComparingValues_ReturnsExpectedResult(string value, MobilePhoneFormats formats, bool isValid) {
        MobilePhoneValidator validator = new("", value, formats);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "error";
        MobilePhoneFormats formats = MobilePhoneFormats.All;
        string expexted = ErrorMessageProvider.ValueIsMobilePhoneAccessor(column, value, formats);

        MobilePhoneValidator validator = new(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expexted));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "error";
        MobilePhoneFormats formats = MobilePhoneFormats.All;
        string expexted = column + value + formats;

        MobilePhoneValidator validator = new(column, value, formats, (c, v, f) => c + v + f);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expexted));
    }
}
