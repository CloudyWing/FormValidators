using System;
using System.Globalization;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// Validate that an integer value is less than another column value.
/// </summary>
/// <remarks>
/// Both values are parsed with the current culture. When either value cannot be parsed, the comparison is skipped and the validation succeeds.
/// </remarks>
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
        string column, string? value, string comparisonColumn, string? comparisonValue,
        bool allowedEqual = true, Func<string, string?, string, string?, bool, string>? customErrorMessageAccessor = null)
        : base(column, value, comparisonColumn, comparisonValue, allowedEqual, customErrorMessageAccessor) { }

    /// <inheritdoc/>
    protected override bool TryParse(string? value, out long result) {
        // 與 IntegerValidator 一致只接受整數格式，保留千分位以免既有含千分位的輸入失去比較
        return long.TryParse(value, NumberStyles.Integer | NumberStyles.AllowThousands, null, out result);
    }
}
