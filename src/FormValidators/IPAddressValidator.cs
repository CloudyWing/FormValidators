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
    public IPAddressValidator(string column, string value, Func<string, string, IPAddressTypes, string> customErrorMessageAccessor = null)
        : this(column, value, IPAddressTypes.All, customErrorMessageAccessor) {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="IPAddressValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="types">The types.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, IP address types.</param>
    public IPAddressValidator(string column, string value, IPAddressTypes types, Func<string, string, IPAddressTypes, string> customErrorMessageAccessor = null)
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
    public Func<string, string, IPAddressTypes, string> CustomErrorMessageAccessor { get; }

    /// <inheritdoc/>
    protected override string DefaultErrorMessage => ErrorMessageProvider.ValueIsIPAddressAccessor(Column, Value, Types);

    /// <inheritdoc/>
    protected override string CustomErrorMessage => CustomErrorMessageAccessor(Column, Value, Types);

    /// <inheritdoc/>
    protected override bool HasCustomErrorMessage => CustomErrorMessageAccessor != null;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        if (string.IsNullOrWhiteSpace(Value)) {
            return true;
        }

        if (!IPAddress.TryParse(Value, out IPAddress ip)) {
            return false;
        }

        if (Types.HasFlag(IPAddressTypes.IPv4) && ip.AddressFamily == AddressFamily.InterNetwork) {
            return true;
        }

        if (Types.HasFlag(IPAddressTypes.IPv6) && ip.AddressFamily == AddressFamily.InterNetworkV6) {
            return true;
        }

        return false;
    }
}
