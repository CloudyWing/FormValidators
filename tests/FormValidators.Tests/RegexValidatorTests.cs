using System;
using System.Text.RegularExpressions;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class RegexValidatorTests {
    [TestCase(null, "", true)]
    [TestCase("", "", true)]
    [TestCase(" ", "", true)]
    [TestCase("1234567", @"^\d{7}$", true)]
    [TestCase("a123456", @"^\d{7}$", false)]
    public void Validate_WhenComparingValues_ReturnsExpectedResult(string value, string pattern, bool isValid) {
        RegexValidator validator = new("", value, pattern);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "123456";
        string expected = ErrorMessageProvider.ValueMatchRegexAccessor(column, value);

        RegexValidator validator = new(column, value, @"\D+");
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "123456";
        string expected = column + value;

        RegexValidator validator = new(column, value, @"\D+", (c, v) => c + v);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void Validate_WhenRegexInstanceIsUsed_ReturnsExpectedResult() {
        string value = "1234567";
        System.Text.RegularExpressions.Regex regex = new(@"^\d{7}$");
        RegexValidator validator = new("", value, regex);

        Assert.That(validator.Validate(), Is.True);
    }

    [Test]
    public void Constructor_NullPattern_ThrowsArgumentNullException() {
        ArgumentNullException? exception = Assert.Throws<ArgumentNullException>(() => new RegexValidator("", "", (string)null!));

        Assert.That(exception?.ParamName, Is.EqualTo("pattern"));
    }

    [Test]
    public void Constructor_NullRegex_ThrowsArgumentNullException() {
        ArgumentNullException? exception = Assert.Throws<ArgumentNullException>(() => new RegexValidator("", "", (Regex)null!));

        Assert.That(exception?.ParamName, Is.EqualTo("regex"));
    }

    [Test]
    public void Validate_RegexMatchTimesOut_ReturnsFalse() {
        Regex regex = new(@"^(a+)+$", RegexOptions.None, TimeSpan.FromMilliseconds(1));
        RegexValidator validator = new("", new string('a', 64) + "!", regex);

        bool isValid = validator.Validate();

        Assert.That(isValid, Is.False);
    }

    [TestCase("ABC", RegexOptions.IgnoreCase, true)]
    [TestCase("ABC", RegexOptions.None, false)]
    public void Validate_WithRegexOptions_AppliesOptions(string value, RegexOptions options, bool isValid) {
        RegexValidator validator = new("", value, "^abc$", options, Regex.InfiniteMatchTimeout, null);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void Validate_WithMatchTimeoutAndCatastrophicPattern_ReturnsFalse() {
        RegexValidator validator = new("", new string('a', 64) + "!", @"^(a+)+$", RegexOptions.None, TimeSpan.FromMilliseconds(1), null);

        Assert.That(validator.Validate(), Is.False);
    }

    [TestCase(0)]
    [TestCase(-5)]
    public void Constructor_InvalidMatchTimeout_ThrowsArgumentOutOfRangeException(int milliseconds) {
        Assert.Throws<ArgumentOutOfRangeException>(() => new RegexValidator("", "", "a", RegexOptions.None, TimeSpan.FromMilliseconds(milliseconds), null));
    }

    [Test]
    public void ValidationProviderRegex_WithRegexInstance_UsesInstance() {
        ValidationProvider provider = new();
        Regex regex = new("^abc$", RegexOptions.IgnoreCase);

        RegexValidator validator = provider.Regex(regex)("", "ABC");

        using (Assert.EnterMultipleScope()) {
            Assert.That(validator.Validate(), Is.True);
            Assert.That(validator.Pattern, Is.EqualTo("^abc$"));
        }
    }

    [Test]
    public void ValidationProviderRegex_WithOptionsAndTimeout_CreatesValidatorWithCustomMessage() {
        ValidationProvider provider = new();

        RegexValidator validator = provider.Regex("^abc$", RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1), "{0}格式錯誤")("欄位", "abd");
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("欄位格式錯誤"));
    }

    [Test]
    public void ValidationProviderRegex_NullRegex_ThrowsArgumentNullException() {
        ValidationProvider provider = new();

        Assert.Throws<ArgumentNullException>(() => provider.Regex((Regex)null!));
    }
}
