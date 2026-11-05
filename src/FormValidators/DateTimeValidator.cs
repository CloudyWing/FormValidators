using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// Validation constrains the date time format of a value.
/// </summary>
/// <remarks>
/// The value is parsed with the current culture, such as the decimal separator and the date order, unless a format provider is specified.
/// </remarks>
public sealed class DateTimeValidator : ComparableTypeValidator<DateTime> {
    private static readonly ReadOnlyCollection<string> EmptyFormats = new([]);
    private readonly string[] exactFormats = [];

    /// <summary>
    /// Initializes a new instance of the <see cref="DateTimeValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    public DateTimeValidator(string column, string? value, Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor = null)
        : this(column, value, null, null, customErrorMessageAccessor) { }

    /// <inheritdoc/>
    public DateTimeValidator(string column, string? value, DateTime? min, DateTime? max, Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor = null)
        : base(column, value, min, max, customErrorMessageAccessor) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="DateTimeValidator" /> class with the format provider used to parse the value.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    public DateTimeValidator(
        string column, string? value, DateTime? min, DateTime? max, IFormatProvider? formatProvider,
        Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor
    ) : this(column, value, min, max, [], formatProvider, customErrorMessageAccessor) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="DateTimeValidator" /> class with the exact formats and the format provider used to parse the value.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="formats">The allowed exact formats, such as <c>yyyy/MM/dd</c>. An empty collection allows any format recognized by the format provider.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <exception cref="ArgumentNullException"><paramref name="formats" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException"><paramref name="formats" /> contains a <see langword="null" /> or empty format.</exception>
    public DateTimeValidator(
        string column, string? value, DateTime? min, DateTime? max, IEnumerable<string> formats, IFormatProvider? formatProvider,
        Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor
    ) : base(column, value, min, max, customErrorMessageAccessor) {
        if (formats is null) {
            throw new ArgumentNullException(nameof(formats));
        }

        List<string> formatList = [];

        foreach (string format in formats) {
            if (string.IsNullOrEmpty(format)) {
                throw new ArgumentException("Format cannot be null or empty.", nameof(formats));
            }

            formatList.Add(format);
        }

        exactFormats = [.. formatList];
        Formats = new ReadOnlyCollection<string>(exactFormats);
        FormatProvider = formatProvider;
    }

    /// <summary>
    /// Gets the allowed exact formats.
    /// </summary>
    /// <value>The allowed exact formats. An empty collection allows any format recognized by the format provider.</value>
    public IReadOnlyList<string> Formats { get; } = EmptyFormats;

    /// <summary>
    /// Gets the format provider used to parse the value.
    /// </summary>
    /// <value>The format provider. <see langword="null" /> means the current culture.</value>
    public IFormatProvider? FormatProvider { get; }

    /// <inheritdoc/>
    protected override Func<string, string?, string> CastErrorMessageAccessor => ErrorMessageProvider.ValueIsDateTimeAccessor;

    /// <inheritdoc/>
    protected override bool TryParse(string value, out DateTime result) {
        return exactFormats.Length == 0
            ? DateTime.TryParse(value, FormatProvider, DateTimeStyles.None, out result)
            : DateTime.TryParseExact(value, exactFormats, FormatProvider, DateTimeStyles.None, out result);
    }
}
