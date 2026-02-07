using CloudyWing.FormValidators;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class IdCardValidatorEdgeCaseTests {
    [Test]
    public void Validate_WithNoneType_ReturnsFalse() {
        // Arrange
        var validator = new IdCardValidator("col", "A123456789", (IdCardTypes)0);

        // Act
        bool result = validator.Validate();

        // Assert
        Assert.That(result, Is.False);
    }
}
