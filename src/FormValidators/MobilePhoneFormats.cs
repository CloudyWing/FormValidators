using System;

namespace CloudyWing.FormValidators;

/// <summary>The mobile phone formats.</summary>
[Flags]
public enum MobilePhoneFormats {
    /// <summary>The allow contain dashes</summary>
    AllowContainDashes = 1,

    /// <summary>The allow without dashes</summary>
    AllowWithoutDashes = 2,

    /// <summary>All</summary>
    All = AllowContainDashes | AllowWithoutDashes
}
