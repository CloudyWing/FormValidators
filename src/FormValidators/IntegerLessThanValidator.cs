using System;
using System.Globalization;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// Validate that an integer value is less than another column value.
/// </summary>
public sealed class IntegerLessThanValidator : LessThanValidator<long> {
    /// <summary>
    /// Initializes a new instance of the <see cref="IntegerLessThanValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, comparison column, comparison value, allowed equal.</param>
    public IntegerLessThanValidator(
        string column, string value, string comparisonColumn, string comparisonValue,
        bool allowedEqual = true, Func<string, string, string, string, bool, string> customErrorMessageAccessor = null)
        : base(column, value, comparisonColumn, comparisonValue, allowedEqual, customErrorMessageAccessor) { }

    /// <inheritdoc/>
    protected override bool TryParse(string value, out long result) {
        return long.TryParse(value, NumberStyles.Any, null, out result);
    }
}
