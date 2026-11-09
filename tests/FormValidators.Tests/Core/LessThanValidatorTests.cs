using System;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests.Core;

[TestFixture]
public class LessThanValidatorTests {
    private class TestLessThanValidator : LessThanValidator<int> {
        public TestLessThanValidator(
            string column, string? value, string comparisonColumn, string? comparisonValue,
            bool allowedEqual, Func<string, string?, string, string?, bool, string>? customErrorMessageAccessor
        ) : base(column, value, comparisonColumn, comparisonValue, allowedEqual, customErrorMessageAccessor) { }

        protected override bool TryParse(string? value, out int result) {
            return int.TryParse(value, out result);
        }
    }

    [TestCase("5", "10", true, true)]
    [TestCase("10", "10", true, true)]
    [TestCase("10", "10", false, false)]
    [TestCase("15", "10", false, false)]
    [TestCase("abc", "10", false, true)]
    [TestCase("5", "abc", false, true)]
    public void Validate_WhenComparingDateTimes_ReturnsExpectedResult(string value, string comparisonValue, bool allowedEqual, bool isValid) {
        TestLessThanValidator validator = new("", value, "", comparisonValue, allowedEqual, null);
        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "欄位";
        string value = "15";
        string comparisonColumn = "比較欄位";
        string comparisonValue = "10";
        bool allowedEqual = true;

        TestLessThanValidator validator = new(column, value, comparisonColumn, comparisonValue, allowedEqual, null);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("「欄位」必須要小於等於「比較欄位」。"));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "欄位";
        string value = "15";
        string comparisonColumn = "比較欄位";
        string comparisonValue = "10";
        bool allowedEqual = false;
        string expected = column + value + comparisonColumn + comparisonValue + allowedEqual;

        TestLessThanValidator validator = new(
            column, value, comparisonColumn, comparisonValue, allowedEqual,
            (c, v, cc, cv, b) => c + v + cc + cv + b
        );
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenNotAllowedEqualAndFails_ReturnsDefaultMessageWithoutEqual() {
        TestLessThanValidator validator = new("欄位", "10", "比較欄位", "10", false, null);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("「欄位」必須要小於「比較欄位」。"));
    }

    [Test]
    public void ErrorMessage_WhenGlobalAccessorIsSet_ReceivesDocumentedArgumentOrder() {
        string? actual = null;
        ErrorMessageProvider.SetValueLessThanAnotherColumnValueAccessor((c, v, cc, cv, b) => actual = $"{c}|{v}|{cc}|{cv}|{b}");

        try {
            TestLessThanValidator validator = new("欄位", "15", "比較欄位", "10", true, null);
            validator.Validate();
        } finally {
            ErrorMessageProvider.ResetToDefaults();
        }

        Assert.That(actual, Is.EqualTo("欄位|15|比較欄位|10|True"));
    }
}
