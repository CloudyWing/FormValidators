using System;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class CreditCardValidatorTests {
    [TestCase(null, true)]
    [TestCase("", true)]
    [TestCase(" ", true)] // Treated as empty
    [TestCase("4111111111111111", true)] // Visa (Valid, 16 digits)
    [TestCase("4111-1111-1111-1111", true)] // Valid with hyphens
    [TestCase("4111 1111 1111 1111", true)] // Valid with spaces
    [TestCase("4111111111111112", false)] // Invalid check digit
    [TestCase("1234567812345678", false)] // Invalid (Simple sequence check)
    [TestCase("123", false)] // Too short
    [TestCase("not a credit card", false)]
    public void Validate_WhenLuhnCheckUsed_ReturnsExpectedResult(string value, bool expected) {
        CreditCardValidator validator = new("Column", value);
        Assert.That(validator.Validate(), Is.EqualTo(expected));
    }


    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "invalid";
        string expected = ErrorMessageProvider.ValueIsCreditCardAccessor(column, value);

        CreditCardValidator validator = new(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }
}
