using System;

namespace CloudyWing.FormValidators {
    /// <summary>The identity card Tyoe.</summary>
    [Flags]
    public enum IdCardTypes {
        /// <summary>The none</summary>
        None = 0,

        /// <summary>國民身分證</summary>
        National = 1,

        /// <summary>臺灣地區居留證</summary>
        Resident = 2,

        /// <summary>外僑居留證</summary>
        AlienResident = 4,

        /// <summary>遊民證</summary>
        Homeless = 8,

        /// <summary>All</summary>
        All = National | Resident | AlienResident | Homeless
    }
}
