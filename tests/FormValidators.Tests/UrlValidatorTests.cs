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
}
