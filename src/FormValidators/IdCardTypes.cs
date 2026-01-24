using System;

namespace CloudyWing.FormValidators;

/// <summary>The identity card Tyoe.</summary>
[Flags]
public enum IdCardTypes {
    /// <summary>國民身分證號</summary>
    National = 1,

    /// <summary>臺灣地區居留證統一證號</summary>
    Resident = 2,

    /// <summary>外僑居留證統一證號</summary>
    AlienResident = 4,

    /// <summary>遊民證號</summary>
    Homeless = 8,

    /// <summary>新式外來人口統一證號</summary>
    NewResident = 16,

    /// <summary>All</summary>
    All = National | Resident | AlienResident | Homeless | NewResident
}
