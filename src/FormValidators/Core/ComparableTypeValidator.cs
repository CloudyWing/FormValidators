using System;

namespace CloudyWing.FormValidators.Core;

/// <summary>
/// The comparable type validator abstract class.
/// </summary>
/// <typeparam name="T">The compare value type.</typeparam>
/// <seealso cref="FormValidatorBase" />
public abstract class ComparableTypeValidator<T> : FormValidatorBase
    where T : struct, IConvertible, IComparable<T>, IEquatable<T> {
    private string defaultErrorMessage = null;

    /// <summary>Initializes a new instance of the <see cref="ComparableTypeValidator{T}" /> class.</summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    protected ComparableTypeValidator(
        string column, string value, T? min, T? max, Func<string, string, T?, T?, string> customErrorMessageAccessor
    ) : base(column, value) {
        MinValue = min;
        MaxValue = max;
        CustomErrorMessageAccessor = customErrorMessageAccessor;
    }

    /// <summary>Gets the minimum value.</summary>
    /// <value>The minimum value.</value>
    public T? MinValue { get; }

    /// <summary>Gets the maximum value.</summary>
    /// <value>The maximum value.</value>
    public T? MaxValue { get; }

    /// <summary>Gets the cast error message accessor.</summary>
    /// <value>The cast error message accessor.</value>
    protected abstract Func<string, string, string> CastErrorMessageAccessor { get; }

    /// <summary>Gets the custom range message format.</summary>
    /// <value>The custom range message format.</value>
    public Func<string, string, T?, T?, string> CustomErrorMessageAccessor { get; }

    /// <inheritdoc/>
    protected override string DefaultErrorMessage => defaultErrorMessage;

    /// <inheritdoc/>
    protected override string CustomErrorMessage => CustomErrorMessageAccessor(Column, Value, MinValue, MaxValue);

    /// <inheritdoc/>
    protected override bool HasCustomErrorMessage => CustomErrorMessageAccessor != null;

    /// <inheritdoc />
    protected override bool ValidateValue() {
        defaultErrorMessage = "";

        if (string.IsNullOrWhiteSpace(Value)) {
            return true;
        } else if (TryParse(Value, out T value)) {
            if (MinValue.HasValue && MaxValue.HasValue) {
                defaultErrorMessage = ErrorMessageProvider.ValueInRangeAccessor(Column, Value, MinValue.Value, MaxValue.Value);
                return ValidateRange(value);
            } else if (MinValue.HasValue) {
                defaultErrorMessage = ErrorMessageProvider.ValueGreaterOrEqualAccessor(Column, Value, MinValue.Value);
                return ValidateMinValue(value);
            } else if (MaxValue.HasValue) {
                defaultErrorMessage = ErrorMessageProvider.ValueLessOrEqualAccessor(Column, Value, MaxValue.Value);
                return ValidateMaxValue(value);
            } else {
                return true;
            }
        } else {
            defaultErrorMessage = CastErrorMessageAccessor(Column, Value);
            return false;
        }
    }

    /// <summary>Tries the parse.</summary>
    /// <param name="value">The value.</param>
    /// <param name="result">The result.</param>
    /// <returns>Parse value to type <c>T</c> result.</returns>
    protected abstract bool TryParse(string value, out T result);

    private bool ValidateRange(T value) {
        return value.CompareTo(MinValue.Value) >= 0 && value.CompareTo(MaxValue.Value) <= 0;
    }

    private bool ValidateMinValue(T value) {
        return value.CompareTo(MinValue.Value) >= 0;
    }

    private bool ValidateMaxValue(T value) {
        return value.CompareTo(MaxValue.Value) <= 0;
    }
}
