using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// Validation constrains the date time format of a value.
/// </summary>
public sealed class DateTimeValidator : ComparableTypeValidator<DateTime> {
    /// <summary>
    /// Initializes a new instance of the <see cref="DateTimeValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    public DateTimeValidator(string column, string value, Func<string, string, DateTime?, DateTime?, string> customErrorMessageAccessor = null)
        : this(column, value, null, null, customErrorMessageAccessor) { }

    /// <inheritdoc/>
    public DateTimeValidator(string column, string value, DateTime? min, DateTime? max, Func<string, string, DateTime?, DateTime?, string> customErrorMessageAccessor = null)
        : base(column, value, min, max, customErrorMessageAccessor) { }

    /// <inheritdoc/>
    protected override Func<string, string, string> CastErrorMessageAccessor => ErrorMessageProvider.ValueIsDateTimeAccessor;

    /// <inheritdoc/>
    protected override bool TryParse(string value, out DateTime result) {
        return DateTime.TryParse(value, out result);
    }
}
