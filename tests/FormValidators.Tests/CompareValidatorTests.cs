using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class CompareValidatorTests {
    [TestCase(null, "", true)]
    [TestCase("", "", true)]
    [TestCase(" ", "", true)]
    [TestCase("123", "123", true)]
    [TestCase("123", "456", false)]
    public void Validate_ReturnValue_AreEqual(string value, string comparisonValue, bool isValid) {
        CompareValidator validator = new CompareValidator("", value, "", comparisonValue);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_DefaultMessage_AreEqual() {
        const string column = "測試欄位";
        const string value = "123";
        const string comparisonColumn = "比較欄位";
        const string comparisonValue = "456";
        string expected = ErrorMessageProvider.ValueCompareAnotherColumnValueAccessor(column, value, comparisonColumn, comparisonValue);

        CompareValidator validator = new CompareValidator(column, "123", comparisonColumn, "456");
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_CustomMessage_AreEqual() {
        const string column = "測試欄位";
        const string value = "123";
        const string comparisonColumn = "比較欄位";
        const string comparisonValue = "456";
        string expected = column + value + comparisonColumn + comparisonValue;

        CompareValidator validator = new CompareValidator(column, "123", comparisonColumn, "456", (c, v, cc, cv) => c + v + cc + cv);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }
}
