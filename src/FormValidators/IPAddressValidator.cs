using System;
using System.Net;
using System.Net.Sockets;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// The IP address validator.
/// </summary>
public sealed class IPAddressValidator : FormValidatorBase {
    /// <summary>
    /// Initializes a new instance of the <see cref="IPAddressValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, IP address types.</param>
    public IPAddressValidator(string column, string? value, Func<string, string?, IPAddressTypes, string>? customErrorMessageAccessor = null)
        : this(column, value, IPAddressTypes.All, customErrorMessageAccessor) {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="IPAddressValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="types">The types.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, IP address types.</param>
    public IPAddressValidator(string column, string? value, IPAddressTypes types, Func<string, string?, IPAddressTypes, string>? customErrorMessageAccessor = null)
        : base(column, value) {
        Types = types;
        CustomErrorMessageAccessor = customErrorMessageAccessor;
    }

    /// <summary>
    /// Gets the types.
    /// </summary>
    /// <value>The types.</value>
    public IPAddressTypes Types { get; }

    /// <summary>
    /// Gets or sets the custom error message accessor.
    /// </summary>
    /// <value>The custom error message accessor.</value>
    public Func<string, string?, IPAddressTypes, string>? CustomErrorMessageAccessor { get; }

    /// <inheritdoc/>
    protected override string DefaultErrorMessage => ErrorMessageProvider.ValueIsIPAddressAccessor(Column, Value, Types);

    /// <inheritdoc/>
    protected override string CustomErrorMessage => CustomErrorMessageAccessor!(Column, Value, Types);

    /// <inheritdoc/>
    protected override bool HasCustomErrorMessage => CustomErrorMessageAccessor != null;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        if (StringUtils.IsNullOrWhiteSpace(Value)) {
            return true;
        }

        // IPAddress.TryParse 會接受「1」、「192.168.1」等簡寫與八進位、十六進位寫法，IPv4 改為自行檢查
        if (Value.IndexOf(':') < 0) {
            return Types.HasFlag(IPAddressTypes.IPv4) && IsDottedDecimalIPv4(Value);
        }

        return Types.HasFlag(IPAddressTypes.IPv6)
            && IPAddress.TryParse(Value, out IPAddress? ip)
            && ip?.AddressFamily == AddressFamily.InterNetworkV6;
    }

    private static bool IsDottedDecimalIPv4(string value) {
        string[] parts = value.Split('.');

        if (parts.Length != 4) {
            return false;
        }

        foreach (string part in parts) {
            if (!IsOctet(part)) {
                return false;
            }
        }

        return true;
    }

    private static bool IsOctet(string part) {
        if (part.Length == 0 || part.Length > 3) {
            return false;
        }

        // 前導零在部分解析器代表八進位，語意不明確，因此不接受
        if (part.Length > 1 && part[0] == '0') {
            return false;
        }

        int number = 0;

        foreach (char c in part) {
            if (c < '0' || c > '9') {
                return false;
            }

            number = (number * 10) + (c - '0');
        }

        return number <= 255;
    }
}
