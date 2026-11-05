using System;
using System.Globalization;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
[SetCulture("zh-TW")]
public class DateTimeValidatorTests {
    [TestCase(null, true)]
    [TestCase("", true)]
    [TestCase(" ", true)]
    [TestCase("1912/3/4", true)]
    [TestCase("1912/03/04", true)]
    [TestCase("1912/03/04 12:34", true)]
    [TestCase("1912/03/04 25:00", false)]
    [TestCase("1912/03/04 00:61", false)]
    [TestCase("1913/02/29 00:00", false)]
    [TestCase("error", false)]
    public void Validate_WithFormatCheck_ReturnsExpectedResult(string value, bool isValid) {
        DateTimeValidator validator = new("", value);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [TestCase("1912/3/2", true)]
    [TestCase("1912/3/3", true)]
    [TestCase("1912/3/1", false)]
    public void Validate_WithMinConstraint_ReturnsExpectedResult(string value, bool isValid) {
        DateTimeValidator validator = new("", value, new(1912, 3, 2), null);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [TestCase("1912/3/1", true)]
    [TestCase("1912/3/2", true)]
    [TestCase("1912/3/3", false)]
    public void Validate_WithMaxConstraint_ReturnsExpectedResult(string value, bool isValid) {
        DateTimeValidator validator = new("", value, null, new(1912, 3, 2));

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [TestCase("1912/3/2", true)]
    [TestCase("1912/3/3", true)]
    [TestCase("1912/3/4", true)]
    [TestCase("1912/3/1", false)]
    [TestCase("1912/3/5", false)]
    public void Validate_WithRangeConstraint_ReturnsExpectedResult(string value, bool isValid) {
        DateTimeValidator validator = new("", value, new(1912, 3, 2), new(1912, 3, 4));

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "error";
        string expected = ErrorMessageProvider.ValueIsDateTimeAccessor(column, value);

        DateTimeValidator validator = new(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "error";
        string expected = column + value;

        DateTimeValidator validator = new(column, value, (c, v, _, _) => c + v);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMinConstraintFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "1912/03/04";
        DateTime min = new(1912, 3, 5);
        string expected = ErrorMessageProvider.ValueGreaterOrEqualAccessor(column, value, min);

        DateTimeValidator validator = new(column, value, min, null);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMinConstraintFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "1912/03/04";
        DateTime min = new(1912, 3, 5);
        string expected = column + value + min;

        DateTimeValidator validator = new(column, value, min, null, (c, v, _min, _) => c + v + min);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMaxConstraintFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "1912/03/04";
        DateTime max = new(1912, 3, 3);
        string expected = ErrorMessageProvider.ValueLessOrEqualAccessor(column, value, max);

        DateTimeValidator validator = new(column, value, null, max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMaxConstraintFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "1912/03/04";
        DateTime max = new(1912, 3, 3);
        string expected = column + value + max;

        DateTimeValidator validator = new(column, value, null, max, (c, v, _, _max) => c + v + _max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenRangeConstraintFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "1912/03/04";
        DateTime min = new(1912, 3, 5);
        DateTime max = new(1912, 3, 3);
        string expected = ErrorMessageProvider.ValueInRangeAccessor(column, value, min, max);

        DateTimeValidator validator = new(column, value, min, max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenRangeConstraintFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "1912/03/04";
        DateTime min = new(1912, 3, 5);
        DateTime max = new(1912, 3, 3);
        string expected = column + value + min + max;

        DateTimeValidator validator = new(column, value, min, max, (c, v, _min, _max) => c + v + _min + _max);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenMinConstraintFails_ReturnsFixedDateFormat() {
        DateTimeValidator validator = new("測試欄位", "1912/03/04", new DateTime(1912, 3, 5), null);

        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("「測試欄位」必須大於等於「1912/03/05」。"));
    }

    [Test]
    public void ErrorMessage_WhenRangeConstraintFails_ReturnsFixedDateFormat() {
        DateTimeValidator validator = new("測試欄位", "1912/03/01", new DateTime(1912, 3, 2), new DateTime(1912, 3, 4));

        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("「測試欄位」必須介於「1912/03/02」和「1912/03/04」之間。"));
    }

    [TestCase("de-DE")]
    [TestCase("th-TH")]
    [TestCase("ar-SA")]
    [TestCase("en-US")]
    public void ValueLessOrEqualAccessor_WithDifferentCulture_ReturnsGregorianDateWithSlash(string cultureName) {
        CultureInfo original = CultureInfo.CurrentCulture;
        CultureInfo.CurrentCulture = new CultureInfo(cultureName);

        string message;
        try {
            message = ErrorMessageProvider.ValueLessOrEqualAccessor("欄位", "", new DateTime(2024, 1, 31));
        } finally {
            CultureInfo.CurrentCulture = original;
        }

        Assert.That(message, Is.EqualTo("「欄位」必須小於等於「2024/01/31」。"));
    }

    [Test]
    [SetCulture("en-US")]
    public void Validate_WithEnUsCulture_ParsesMonthFirst() {
        DateTimeValidator validator = new("", "03/04/1912", new DateTime(1912, 3, 4), new DateTime(1912, 3, 4));

        Assert.That(validator.Validate(), Is.True);
    }

    [Test]
    [SetCulture("en-GB")]
    public void Validate_WithEnGbCulture_ParsesDayFirst() {
        DateTimeValidator validator = new("", "03/04/1912", new DateTime(1912, 4, 3), new DateTime(1912, 4, 3));

        Assert.That(validator.Validate(), Is.True);
    }

    [TestCase("2024/01/31", true)]
    [TestCase("2024/1/31", false)]
    [TestCase("01/31/2024", false)]
    [TestCase("2024-01-31", false)]
    public void Validate_WithExactFormats_AcceptsOnlyListedFormats(string value, bool isValid) {
        DateTimeValidator validator = new("", value, null, null, ["yyyy/MM/dd"], CultureInfo.InvariantCulture, null);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    [SetCulture("en-US")]
    public void Validate_WithFormatProvider_IgnoresCurrentCulture() {
        DateTimeValidator validator = new("", "03/04/1912", new DateTime(1912, 4, 3), new DateTime(1912, 4, 3), new CultureInfo("en-GB"), null);

        Assert.That(validator.Validate(), Is.True);
    }

    [Test]
    public void Constructor_NullFormats_ThrowsArgumentNullException() {
        Assert.Throws<ArgumentNullException>(() => new DateTimeValidator("", "", null, null, null!, null, null));
    }

    [Test]
    public void Formats_WhenNotSpecified_IsEmpty() {
        DateTimeValidator validator = new("", "2024/01/31");

        using (Assert.EnterMultipleScope()) {
            Assert.That(validator.Formats, Is.Empty);
            Assert.That(validator.FormatProvider, Is.Null);
        }
    }

    [Test]
    public void ValidationProviderDateTimeMethods_WithFormatProvider_CreateValidatorWithFormatProvider() {
        ValidationProvider provider = new();
        CultureInfo culture = CultureInfo.InvariantCulture;
        string[] formats = ["yyyyMMdd"];

        DateTimeValidator any = provider.DateTime(culture)("", "2024-01-31");
        DateTimeValidator exact = provider.DateTime(formats, culture)("", "2024-01-31");
        DateTimeValidator min = provider.MinDateTime(new DateTime(2024, 2, 1), formats, culture)("", "20240131");
        DateTimeValidator max = provider.MaxDateTime(new DateTime(2024, 1, 1), culture)("", "2024-01-31");
        DateTimeValidator range = provider.DateTimeRange(new DateTime(2024, 1, 1), new DateTime(2024, 12, 31), formats, culture, (c, v, _min, _max) => c)("欄位", "20250101");

        using (Assert.EnterMultipleScope()) {
            Assert.That(any.Validate(), Is.True);
            Assert.That(exact.Validate(), Is.False);
            Assert.That(exact.Formats, Is.EqualTo(formats));
            Assert.That(min.Validate(), Is.False);
            Assert.That(max.Validate(), Is.False);
            Assert.That(range.Validate(), Is.False);
            Assert.That(range.ErrorMessage, Is.EqualTo("欄位"));
        }
    }
}
