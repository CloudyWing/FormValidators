using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class GuidValidatorTests {
    [TestCase(null, true)]
    [TestCase("", true)]
    [TestCase("1d3e7a0c-5b8f-4c2e-9a6d-0f1e2d3c4b5a", true)]
    [TestCase("1D3E7A0C5B8F4C2E9A6D0F1E2D3C4B5A", true)]
    [TestCase("{1d3e7a0c-5b8f-4c2e-9a6d-0f1e2d3c4b5a}", true)]
    [TestCase("(1d3e7a0c-5b8f-4c2e-9a6d-0f1e2d3c4b5a)", true)]
    [TestCase("1d3e7a0c-5b8f-4c2e-9a6d-0f1e2d3c4b5", false)]
    [TestCase("1d3e7a0c-5b8f-4c2e-9a6d-0f1e2d3c4b5g", false)]
    [TestCase("not a guid", false)]
    public void Validate_WithVariousFormats_ReturnsExpectedResult(string? value, bool isValid) {
        GuidValidator validator = new("", value);

        Assert.That(validator.Validate(), Is.EqualTo(isValid));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        GuidValidator validator = new("識別碼", "x");

        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("「識別碼」必須為正確的GUID格式。"));
    }

    [Test]
    public void ValidationProviderGuid_WithCustomAccessor_ReturnsCustomMessage() {
        ValidationProvider provider = new();

        GuidValidator validator = provider.Guid((c, v) => c + v)("識別碼", "x");
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo("識別碼x"));
    }
}
