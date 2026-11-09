namespace CloudyWing.FormValidators;

/// <summary>
/// The unit used to count the length of a text value.
/// </summary>
public enum TextLengthUnit {
    /// <summary>
    /// Counts UTF-16 code units, the same as <see cref="string.Length" />. A character outside the Basic Multilingual Plane, such as most emoji, counts as 2.
    /// </summary>
    Utf16CodeUnit = 0,

    /// <summary>
    /// Counts Unicode scalar values (code points). A surrogate pair counts as 1.
    /// </summary>
    UnicodeScalar = 1,

    /// <summary>
    /// Counts text elements (user-perceived characters) by <see cref="System.Globalization.StringInfo" />.
    /// On .NET 5 or later, an emoji sequence joined by zero-width joiners counts as 1; on .NET Framework and .NET Standard 2.0 runtimes older than .NET 5, it may count as more than 1.
    /// </summary>
    TextElement = 2
}
