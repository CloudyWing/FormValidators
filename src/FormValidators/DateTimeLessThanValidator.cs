using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// Validate that an date time value is less than another column value.
/// </summary>
public sealed class DateTimeLessThanValidator : LessThanValidator<DateTime> {
    /// <summary>
    /// Initializes a new instance of the <see cref="DateTimeLessThanValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, comparison column, comparison value, allowed equal.</param>
    public DateTimeLessThanValidator(
        string column, string value, string comparisonColumn, string comparisonValue,
        bool allowedEqual = true, Func<string, string, string, string, bool, string> customErrorMessageAccessor = null)
        : base(column, value, comparisonColumn, comparisonValue, allowedEqual, customErrorMessageAccessor) { }

    /// <inheritdoc/>
    protected override bool TryParse(string value, out DateTime result) {
        return DateTime.TryParse(value, out result);
    }
}
