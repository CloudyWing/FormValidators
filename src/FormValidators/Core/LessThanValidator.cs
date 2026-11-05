using System;

namespace CloudyWing.FormValidators.Core;

/// <summary>
/// The less than other column value validator abstract class.
/// </summary>
/// <typeparam name="T">The value type.</typeparam>
public abstract class LessThanValidator<T> : FormValidatorBase
    where T : struct, IConvertible, IComparable<T>, IEquatable<T> {
    /// <summary>
    /// Initializes a new instance of the <see cref="LessThanValidator{T}" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, comparison column, comparison value, allowed equal.</param>
    protected LessThanValidator(
        string column, string value, string comparisonColumn, string comparisonValue,
        bool allowedEqual = true, Func<string, string, string, string, bool, string> customErrorMessageAccessor = null
    ) : base(column, value) {
        ComparisonColumn = comparisonColumn;
        ComparisonValue = comparisonValue;
        AllowedEqual = allowedEqual;
        CustomErrorMessageAccessor = customErrorMessageAccessor;
    }

    /// <summary>
    /// Gets or sets the comparison column.
    /// </summary>
    /// <value>The comparison column.</value>
    public string ComparisonColumn { get; }

    /// <summary>
    /// Gets or sets the comparison value.
    /// </summary>
    /// <value>The comparison value.</value>
    public string ComparisonValue { get; }

    /// <summary>
    /// Gets or sets a value indicating whether [allowed equal].
    /// </summary>
    /// <value>
    ///   <c>true</c> if [allowed equal]; otherwise, <c>false</c>.</value>
    public bool AllowedEqual { get; }

    /// <summary>
    /// Gets the custom range message format.
    /// </summary>
    /// <value>The custom range message format.</value>
    public Func<string, string, string, string, bool, string> CustomErrorMessageAccessor { get; set; }

    /// <inheritdoc/>
    protected override string DefaultErrorMessage => ErrorMessageProvider.ValueLessThanAnotherColumnValueAccessor(Column, Value, ComparisonColumn, ComparisonValue, AllowedEqual);

    /// <inheritdoc/>
    protected override string CustomErrorMessage => CustomErrorMessageAccessor(Column, Value, ComparisonColumn, ComparisonValue, AllowedEqual);

    /// <inheritdoc/>
    protected override bool HasCustomErrorMessage => CustomErrorMessageAccessor != null;

    /// <inheritdoc />
    protected override bool ValidateValue() {
        // 格式不正確就不驗證
        if (!TryParse(Value, out T _value)
            || !TryParse(ComparisonValue, out T _comparisonValue)
        ) {
            return true;
        } else {
            return _value.CompareTo(_comparisonValue) < 0
                || (AllowedEqual && _value.Equals(_comparisonValue));
        }
    }

    /// <summary>
    /// Tries the parse.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="result">The result.</param>
    /// <returns>Parse value to type <c>T</c> result.</returns>
    protected abstract bool TryParse(string value, out T result);
}
