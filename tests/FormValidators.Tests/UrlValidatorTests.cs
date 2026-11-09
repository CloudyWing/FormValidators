using System;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class UrlValidatorTests {
    [TestCase(null, true)]
    [TestCase("", true)]
    [TestCase(" ", true)]
    [TestCase("http://www.google.com", true)]
    [TestCase("https://www.google.com", true)]
    [TestCase("ftp://ftp.google.com", true)]
    [TestCase("www.google.com", false)] // Missing scheme (Absolute by default)
    [TestCase("google.com", false)]
    [TestCase("not a url", false)]
    public void Validate_WhenAbsoluteUrlIsUsed_ReturnsExpectedResult(string value, bool expected) {
        UrlValidator validator = new("Column", value);
        Assert.That(validator.Validate(), Is.EqualTo(expected));
    }

    [TestCase("/relative/path", true)]
    [TestCase("relative/path", true)]
    [TestCase("http://www.google.com", false)]
    public void Validate_WhenRelativeUrlIsUsed_ReturnsExpectedResult(string value, bool expected) {
        UrlValidator validator = new("Column", value, UriKind.Relative);
        Assert.That(validator.Validate(), Is.EqualTo(expected));
    }

    [TestCase("http://www.google.com", true)]
    [TestCase("/relative/path", true)]
    public void Validate_WhenRelativeOrAbsoluteUrlIsUsed_ReturnsExpectedResult(string value, bool expected) {
        UrlValidator validator = new("Column", value, UriKind.RelativeOrAbsolute);
        Assert.That(validator.Validate(), Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "invalid";
        string expected = ErrorMessageProvider.ValueIsUrlAccessor(column, value);

        UrlValidator validator = new(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [TestCase("/path")]
    [TestCase("/usr/local/bin")]
    [TestCase(@"C:\path\file.txt")]
    [TestCase(@"\\server\share")]
    public void Validate_WhenAbsoluteUrlIsUsedWithImplicitFilePath_ReturnsFalse(string value) {
        UrlValidator validator = new("Column", value);

        Assert.That(validator.Validate(), Is.False);
    }

    [Test]
    public void Validate_WhenRelativeOrAbsoluteUrlIsUsedWithUnixPath_ReturnsTrue() {
        UrlValidator validator = new("Column", "/usr/local/bin", UriKind.RelativeOrAbsolute);

        Assert.That(validator.Validate(), Is.True);
    }

    [TestCase("file:///etc/passwd")]
    [TestCase("javascript:alert(1)")]
    [TestCase("mailto:wing@example.com")]
    public void Validate_WhenAbsoluteUrlIsUsedWithExplicitScheme_ReturnsTrue(string value) {
        UrlValidator validator = new("Column", value);

        Assert.That(validator.Validate(), Is.True);
    }

    [TestCase("http://www.google.com", true)]
    [TestCase("HTTPS://www.google.com", true)]
    [TestCase("ftp://ftp.google.com", false)]
    [TestCase("javascript:alert(1)", false)]
    [TestCase("file:///etc/passwd", false)]
    public void Validate_WhenAllowedSchemesAreSpecified_ReturnsExpectedResult(string value, bool expected) {
        UrlValidator validator = new("Column", value, UriKind.Absolute, ["http", "https"]);

        Assert.That(validator.Validate(), Is.EqualTo(expected));
    }

    [TestCase("/relative/path", true)]
    [TestCase("https://www.google.com", true)]
    [TestCase("javascript:alert(1)", false)]
    public void Validate_WhenRelativeOrAbsoluteWithAllowedSchemes_ReturnsExpectedResult(string value, bool expected) {
        UrlValidator validator = new("Column", value, UriKind.RelativeOrAbsolute, ["https"]);

        Assert.That(validator.Validate(), Is.EqualTo(expected));
    }

    [Test]
    public void Constructor_NullAllowedSchemes_ThrowsArgumentNullException() {
        Assert.Throws<ArgumentNullException>(() => new UrlValidator("Column", "", UriKind.Absolute, (string[])null!));
    }

    [Test]
    public void Constructor_EmptyScheme_ThrowsArgumentException() {
        Assert.Throws<ArgumentException>(() => new UrlValidator("Column", "", UriKind.Absolute, ["http", " "]));
    }

    [Test]
    public void AllowedSchemes_WhenNotSpecified_IsEmpty() {
        UrlValidator validator = new("Column", "http://www.google.com");

        Assert.That(validator.AllowedSchemes, Is.Empty);
    }

    [Test]
    public void ValidationProviderUrl_WithAllowedSchemes_CreatesValidatorWithSchemes() {
        ValidationProvider provider = new();

        UrlValidator validator = provider.Url(UriKind.Absolute, ["https"])("Column", "http://www.google.com");

        using (Assert.EnterMultipleScope()) {
            Assert.That(validator.AllowedSchemes, Is.EqualTo(new[] { "https" }));
            Assert.That(validator.Validate(), Is.False);
        }
    }
}
