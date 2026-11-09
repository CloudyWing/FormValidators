using System;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class IPAddressValidatorTests {
    [TestCase(null, true)]
    [TestCase("", true)]
    [TestCase("192.168.1.1", true)]
    [TestCase("255.255.255.255", true)]
    [TestCase("0.0.0.0", true)]
    [TestCase("256.0.0.1", false)] // Invalid IPv4
    [TestCase("::1", true)] // IPv6
    [TestCase("2001:0db8:85a3:0000:0000:8a2e:0370:7334", true)]
    [TestCase("not an ip", false)]
    public void Validate_WhenDefaultValidationUsed_ReturnsExpectedResult(string value, bool expected) {
        IPAddressValidator validator = new("Column", value);
        Assert.That(validator.Validate(), Is.EqualTo(expected));
    }

    [TestCase("192.168.1.1", true)]
    [TestCase("::1", false)]
    public void Validate_WhenIPv4OnlyUsed_ReturnsExpectedResult(string value, bool expected) {
        IPAddressValidator validator = new("Column", value, IPAddressTypes.IPv4);
        Assert.That(validator.Validate(), Is.EqualTo(expected));
    }

    [TestCase("192.168.1.1", false)]
    [TestCase("::1", true)]
    public void Validate_WhenIPv6OnlyUsed_ReturnsExpectedResult(string value, bool expected) {
        IPAddressValidator validator = new("Column", value, IPAddressTypes.IPv6);
        Assert.That(validator.Validate(), Is.EqualTo(expected));
    }

    [Test]
    public void ErrorMessage_WhenValidationFails_ReturnsDefaultMessage() {
        string column = "測試欄位";
        string value = "invalid";
        string expected = ErrorMessageProvider.ValueIsIPAddressAccessor(column, value, IPAddressTypes.All);

        IPAddressValidator validator = new(column, value);
        validator.Validate();

        Assert.That(validator.ErrorMessage, Is.EqualTo(expected));
    }

    [TestCase("1")]
    [TestCase("192.168.1")]
    [TestCase("192.168")]
    [TestCase("3232235777")]
    [TestCase("0x7f.0.0.1")]
    [TestCase("010.0.0.1")]
    [TestCase("192.168.001.1")]
    [TestCase("1.2.3.4.5")]
    [TestCase("1.2.3.")]
    [TestCase("１.2.3.4")]
    [TestCase("1.2.3.4\n")]
    [TestCase(" 1.2.3.4")]
    public void Validate_NonDottedDecimalIPv4_ReturnsFalse(string value) {
        IPAddressValidator validator = new("Column", value);

        Assert.That(validator.Validate(), Is.False);
    }

    [TestCase("10.0.0.1")]
    [TestCase("1.2.3.4")]
    [TestCase("100.200.250.255")]
    public void Validate_DottedDecimalIPv4_ReturnsTrue(string value) {
        IPAddressValidator validator = new("Column", value, IPAddressTypes.IPv4);

        Assert.That(validator.Validate(), Is.True);
    }

    [TestCase("::ffff:192.168.1.1", true)]
    [TestCase("fe80::1", true)]
    [TestCase("1::2::3", false)]
    public void Validate_WhenIPv6OnlyUsedWithVariousFormats_ReturnsExpectedResult(string value, bool expected) {
        IPAddressValidator validator = new("Column", value, IPAddressTypes.IPv6);

        Assert.That(validator.Validate(), Is.EqualTo(expected));
    }
}
