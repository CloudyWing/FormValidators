using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class IntegerValidatorTests {
    [TestCase(null, true, true)]
    [TestCase("", true, true)]
    [TestCase(" ", true, true)]
    [TestCase("0", true, true)]
    [TestCase("1", true, true)]
    [TestCase("-1", true, true)]
    [TestCase("1.1", true, false)]
    [TestCase("1,000", true, true)]
    [TestCase("1,000", false, false)]
    [TestCase("string", true, false)]
    public void Validate_Message_AreEqual(string value, bool allowedThousands, bool isValid) {
        IntegerValidator validator = new IntegerValidator("", value, allowedThousands);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [TestCase("3", 2, 4, true, true)]
    [TestCase("3", 3, 3, true, true)]
    [TestCase("3", 2, 2, true, false)]
    [TestCase("3", 4, 4, true, false)]
    [TestCase("1,000", 1000, 1000, true, true)]
    [TestCase("1,000", 1000, 1000, false, false)]
    public void Validate_Range_AreEqual(string value, long min, long max, bool allowedThousands, bool isValid) {
        IntegerValidator validator = new IntegerValidator("", value, min, max, allowedThousands);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [TestCase("3", 2, true, true)]
    [TestCase("3", 3, true, true)]
    [TestCase("3", 4, true, false)]
    [TestCase("3,000", 3000, true, true)]
    [TestCase("3,000", 3000, false, false)]
    public void Validate_Min_AreEqual(string value, long min, bool allowedThousands, bool isValid) {
        IntegerValidator validator = new IntegerValidator("", value, min, null, allowedThousands);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [TestCase("3", 4, true, true)]
    [TestCase("3", 3, true, true)]
    [TestCase("3", 2, true, false)]
    [TestCase("3,000", 3000, true, true)]
    [TestCase("3,000", 3000, false, false)]
    public void Validate_Max_AreEqual(string value, long max, bool allowedThousands, bool isValid) {
        IntegerValidator validator = new IntegerValidator("", value, null, max, allowedThousands);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_DefaultMessage_AreEqual() {
        string column = "測試欄位";
        string value = "error";
        string expected = ErrorMessageProvider.ValueIsIntegerAccessor(column, value);

        IntegerValidator validator = new IntegerValidator(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_CustomMessage_AreEqual() {
        string column = "測試欄位";
        string value = "error";
        string expected = column + value;

        IntegerValidator validator = new IntegerValidator(column, value, false, (c, v, _, _) => c + v);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_MinDefaultMessage_AreEqual() {
        string column = "測試欄位";
        string value = "0";
        int min = 1;
        string expected = ErrorMessageProvider.ValueGreaterOrEqualAccessor(column, value, min);

        IntegerValidator validator = new IntegerValidator(column, value, min, null);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_MinCustomMessage_AreEqual() {
        string column = "測試欄位";
        string value = "0";
        int min = 1;
        string expected = column + value + min;

        IntegerValidator validator = new IntegerValidator(column, value, min, null, false, (c, v, _min, _) => c + v + _min);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_MaxDefaultMessage_AreEqual() {
        string column = "測試欄位";
        string value = "1";
        int max = 0;
        string expected = ErrorMessageProvider.ValueLessOrEqualAccessor(column, value, max);

        IntegerValidator validator = new IntegerValidator(column, value, null, max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_MaxCustomMessage_AreEqual() {
        string column = "測試欄位";
        string value = "1";
        int max = 0;
        string expected = column + value + max;

        IntegerValidator validator = new IntegerValidator(column, value, null, max, false, (c, v, _, _max) => c + v + _max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_RangeDefaultMessage_AreEqual() {
        string column = "測試欄位";
        string value = "0";
        int min = 1;
        int max = 2;
        string expected = ErrorMessageProvider.ValueInRangeAccessor(column, value, min, max);

        IntegerValidator validator = new IntegerValidator(column, value, min, max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_RangeCustomMessage_AreEqual() {
        string column = "測試欄位";
        string value = "0";
        int min = 1;
        int max = 2;
        string expected = column + value + min + max;

        IntegerValidator validator = new IntegerValidator(column, value, min, max, false, (c, v, _min, _max) => c + v + _min + _max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }
}
