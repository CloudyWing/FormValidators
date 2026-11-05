using System.Diagnostics;
using System.Linq;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class EmailValidatorTests {
    [TestCase(null, true)]
    [TestCase("", true)]
    [TestCase(" ", true)]
    [TestCase("wing@gmail.com", true)]
    [TestCase("wing@gmail", false)]
    [TestCase("wing.com", false)]
    public void Validate_WhenComparingValues_ReturnsExpectedResult(string value, bool isValid) {
        EmailValidator validator = new("", value);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "error";

        EmailValidator validator = new(column, value);
        validator.Validate();

        string expected = ErrorMessageProvider.ValueIsEmailAccessor(column, value);

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsCustomMessage() {
        string column = "測試欄位";
        string value = "error";
        string expected = column + value;

        EmailValidator validator = new(column, value, (c, v) => c + v);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [TestCase("wing@gmail.com\n")]
    [TestCase("wing@gmail.com\r\n")]
    public void Validate_TrailingNewLine_ReturnsFalse(string value) {
        EmailValidator validator = new("", value);

        Assert.That(validator.Validate(), Is.False);
    }

    [TestCase("a.b@c.d", true)]
    [TestCase("a-b@c-d.e", true)]
    [TestCase("a@b-c.d.e", true)]
    [TestCase("a'b+c@x.y", true)]
    [TestCase("_a@_b._c", true)]
    [TestCase("a@.b", false)]
    [TestCase("a@b..c", false)]
    [TestCase("a@b-.c", false)]
    [TestCase("a@b.c.", false)]
    [TestCase("a.@b.c", false)]
    public void Validate_WithVariousFormats_ReturnsExpectedResult(string value, bool isValid) {
        EmailValidator validator = new("", value);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void Validate_LongInputWithoutTopLevelDomain_CompletesWithinTimeLimit() {
        string value = "a@" + string.Concat(Enumerable.Repeat("a-a.", 8000)) + "-";
        EmailValidator validator = new("", value);
        Stopwatch stopwatch = Stopwatch.StartNew();

        bool isValid = validator.Validate();
        stopwatch.Stop();

        using (Assert.EnterMultipleScope()) {
            Assert.That(isValid, Is.False);
            Assert.That(stopwatch.ElapsedMilliseconds, Is.LessThan(500));
        }
    }
}
