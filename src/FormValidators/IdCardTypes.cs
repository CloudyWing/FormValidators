using System;

namespace CloudyWing.FormValidators;

/// <summary>
/// The identity card type.
/// </summary>
[Flags]
public enum IdCardTypes {
    /// <summary>
    /// National.
    /// </summary>
    National = 1,

    /// <summary>
    /// Resident.
    /// </summary>
    Resident = 2,

    /// <summary>
    /// Alien resident.
    /// </summary>
    AlienResident = 4,

    /// <summary>
    /// Homeless.
    /// </summary>
    Homeless = 8,

    /// <summary>
    /// New resident.
    /// </summary>
    NewResident = 16,

    /// <summary>
    /// All.
    /// </summary>
    All = National | Resident | AlienResident | Homeless | NewResident
}
