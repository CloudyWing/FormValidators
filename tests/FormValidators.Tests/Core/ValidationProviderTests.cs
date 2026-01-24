using System;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;


namespace CloudyWing.FormValidators.Tests.Core;
[TestFixture()]
public class ValidationProviderTests {
    private ValidationProvider provider;

    [SetUp]
    public void Setup() {
        provider = new ValidationProvider();
    }

    [Test]
    public void Required_Message_AreEqual() {
        string column = "Required";
        string format = "測試{0}";
        string expected = string.Format(format, column);

        IFormValidator validator = provider.Required(format)(column, null);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void Integer_Message_AreEqual() {
        string column = "Integer";
        string value = "N/A";
        string format = "測試{0}{1}";
        string expected = string.Format(format, column, value);

        IFormValidator validator = provider.Integer(false, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void MinInt_Message_AreEqual() {
        string column = "MinInt";
        string value = "2";
        int min = 3;
        string format = "測試{0}{1}{2}";
        string expected = string.Format(format, column, value, min);

        IFormValidator validator = provider.MinInt(min, false, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void MaxInt_Message_AreEqual() {
        string column = "MaxInt";
        string value = "4";
        int max = 3;
        string format = "測試{0}{1}{3}";
        string expected = string.Format(format, column, value, null, max);

        IFormValidator validator = provider.MaxInt(max, false, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void IntRange_Message_AreEqual() {
        string column = "IntRange";
        string value = "1";
        int min = 2;
        int max = 4;
        string format = "測試{0}{1}{2}{3}";
        string expected = string.Format(format, column, value, min, max);

        IFormValidator validator = provider.IntRange(min, max, false, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void DateTime_Message_AreEqual() {
        string column = "DateTime";
        string value = "NotDateTime";
        string format = "測試{0}{1}";
        string expected = string.Format(format, column, value);

        IFormValidator validator = provider.DateTime(format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void MinDateTime_Message_AreEqual() {
        string column = "MinDateTime";
        DateTime min = DateTime.Today;
        string value = min.AddDays(-1).ToString("yyyy/MM/dd");
        string format = "測試{0}{1}{2}";
        string expected = string.Format(format, column, value, min);

        IFormValidator validator = provider.MinDateTime(min, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void MaxDateTime_Message_AreEqual() {
        string column = "MaxDateTime";
        DateTime max = DateTime.Today;
        string value = max.AddDays(1).ToString("yyyy/MM/dd");
        string format = "測試{0}{1}{3}";
        string expected = string.Format(format, column, value, null, max);

        IFormValidator validator = provider.MaxDateTime(max, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void DateTimeRange_Message_AreEqual() {
        string column = "DateTimeRange";
        DateTime min = DateTime.Today.AddDays(-1);
        DateTime max = DateTime.Today.AddDays(1);
        string value = max.AddDays(1).ToString("yyyy/MM/dd");
        string format = "測試{0}{1}{2}{3}";
        string expected = string.Format(format, column, value, min, max);

        IFormValidator validator = provider.DateTimeRange(min, max, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }
    [Test]
    public void MinLength_Message_AreEqual() {
        string column = "MinLength";
        string value = "12";
        int min = 3;
        string format = "測試{0}{1}{2}";
        string expected = string.Format(format, column, value, min);

        IFormValidator validator = provider.MinLength(min, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void MaxLength_Message_AreEqual() {
        string column = "MaxLength";
        string value = "1234";
        int max = 3;
        string format = "測試{0}{1}{3}";
        string expected = string.Format(format, column, value, null, max);

        IFormValidator validator = provider.MaxLength(max, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void LengthRange_Message_AreEqual() {
        string column = "LengthRange";
        string value = "12345";
        int min = 2;
        int max = 4;
        string format = "測試{0}{1}{2}{3}";
        string expected = string.Format(format, column, value, min, max);

        IFormValidator validator = provider.LengthRange(min, max, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void Regex_Message_AreEqual() {
        string column = "Regex";
        string value = "a";
        string format = "測試{0}{1}";
        string expected = string.Format(format, column, value);

        IFormValidator validator = provider.Regex(@"\d", format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void Email_Message_AreEqual() {
        string column = "Email";
        string value = "NotEmail";
        string format = "測試{0}{1}";
        string expected = string.Format(format, column, value);

        IFormValidator validator = provider.Email(format)(column, "NotEmail");
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void MobilePhone_Message_AreEqual() {
        string column = "MobilePhone";
        string value = "NotPhone";
        MobilePhoneFormats phoneFormats = MobilePhoneFormats.All;
        string format = "測試{0}{1}{2}";
        string expected = string.Format(format, column, value, phoneFormats);

        IFormValidator validator = provider.MobilePhone(phoneFormats, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void IdCard_Message_AreEqual() {
        string column = "IdCard";
        string value = "NotIdCard";
        IdCardTypes types = IdCardTypes.All;
        string format = "測試{0}{1}{2}";
        string expected = string.Format(format, column, value, types);

        IFormValidator validator = provider.IdCard(types, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void Compare_Message_AreEqual() {
        string column = "Compare";
        string value = "124";
        string comparisonColumn = "ComparisonColumn";
        string comparisonValue = "321";
        string format = "測試{0}{1}{2}{3}";
        string expected = string.Format(format, column, value, comparisonColumn, comparisonValue);

        IFormValidator validator = provider.Compare(comparisonColumn, comparisonValue, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void IntegerLessThan_Message_AreEqual() {
        string column = "Column";
        string value = "2";
        string comparisonColumn = "Comparison Column";
        string comparisonValue = "1";
        bool allowedEqual = false;
        string format = "測試{0}({1})必須小於{2}({3})，是否允許等於為{4}";
        string expected = string.Format(format, column, value, comparisonColumn, comparisonValue, allowedEqual);

        IFormValidator validator = provider.IntegerLessThan(comparisonColumn, comparisonValue, allowedEqual, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void NumberLessThan_Message_AreEqual() {
        string column = "Column";
        string value = "1.2";
        string comparisonColumn = "Comparison Column";
        string comparisonValue = "1.1";
        bool allowedEqual = false;
        string format = "測試{0}({1})必須小於{2}({3})，是否允許等於為{4}";
        string expected = string.Format(format, column, value, comparisonColumn, comparisonValue, allowedEqual);

        IFormValidator validator = provider.NumberLessThan(comparisonColumn, comparisonValue, allowedEqual, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void DateTimeLessThan_Message_AreEqual() {
        string column = "Column";
        string value = "2020/01/02";
        string comparisonColumn = "Comparison Column";
        string comparisonValue = "2020/01/01";
        bool allowedEqual = false;
        string format = "測試{0}({1})必須小於{2}({3})，是否允許等於為{4}";
        string expected = string.Format(format, column, value, comparisonColumn, comparisonValue, allowedEqual);

        IFormValidator validator = provider.DateTimeLessThan(comparisonColumn, comparisonValue, allowedEqual, format)(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }
}
