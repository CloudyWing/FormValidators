using System;

namespace CloudyWing.FormValidators;

/// <summary>
/// The IP address types.
/// </summary>
[Flags]
public enum IPAddressTypes {
    /// <summary>
    /// IPv4.
    /// </summary>
    IPv4 = 1,

    /// <summary>
    /// IPv6.
    /// </summary>
    IPv6 = 2,

    /// <summary>
    /// All.
    /// </summary>
    All = IPv4 | IPv6
}
