using System;
using System.Globalization;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// Validation constraints a value does not exceed the length range.
/// </summary>
/// <seealso cref="FormValidatorBase" />
public sealed class ValueLengthValidator : FormValidatorBase {
    private string defaultErrorMessage;

    /// <summary>
    /// Initializes a new instance of the <see cref="ValueLengthValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    public ValueLengthValidator(
        string column, string value, long max,
        Func<string, string, long, long, string> customErrorMessageAccessor = null
    ) : this(column, value, 0, max, customErrorMessageAccessor) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ValueLengthValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="min">The minimum. Less than or equal to 0 means unlimited.</param>
    /// <param name="max">The maximum. Less than or equal to 0 means unlimited.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <exception cref="ArgumentException">Both <paramref name="min" /> and <paramref name="max" /> are greater than 0 and <paramref name="min" /> is greater than <paramref name="max" />.</exception>
    public ValueLengthValidator(
        string column, string value,
        long min, long max,
        Func<string, string, long, long, string> customErrorMessageAccessor = null
    ) : base(column, value) {
        MinLength = min < 0 ? 0 : min;
        MaxLength = max < 0 ? 0 : max;

        // min 大於 max 時任何非空值都無法通過，屬設定錯誤
        if (MinLength > 0 && MaxLength > 0 && MinLength > MaxLength) {
            throw new ArgumentException($"The minimum length {min} cannot be greater than the maximum length {max}.", nameof(min));
        }

        CustomErrorMessageAccessor = customErrorMessageAccessor;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ValueLengthValidator" /> class with the length unit.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="min">The minimum. Less than or equal to 0 means unlimited.</param>
    /// <param name="max">The maximum. Less than or equal to 0 means unlimited.</param>
    /// <param name="unit">The unit used to count the length.</param>
    /// <exception cref="ArgumentException">Both <paramref name="min" /> and <paramref name="max" /> are greater than 0 and <paramref name="min" /> is greater than <paramref name="max" />.</exception>
    public ValueLengthValidator(string column, string value, long min, long max, TextLengthUnit unit)
        : this(column, value, min, max, unit, null) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ValueLengthValidator" /> class with the length unit.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="min">The minimum. Less than or equal to 0 means unlimited.</param>
    /// <param name="max">The maximum. Less than or equal to 0 means unlimited.</param>
    /// <param name="unit">The unit used to count the length.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <exception cref="ArgumentException">Both <paramref name="min" /> and <paramref name="max" /> are greater than 0 and <paramref name="min" /> is greater than <paramref name="max" />.</exception>
    public ValueLengthValidator(
        string column, string value, long min, long max, TextLengthUnit unit,
        Func<string, string, long, long, string> customErrorMessageAccessor
    ) : this(column, value, min, max, customErrorMessageAccessor) {
        Unit = unit;
    }

    /// <summary>
    /// Gets the minimum length.
    /// </summary>
    /// <value>The minimum length.</value>
    public long MinLength { get; }

    /// <summary>
    /// Gets the maximum length.
    /// </summary>
    /// <value>The maximum length.</value>
    public long MaxLength { get; }

    /// <summary>
    /// Gets the unit used to count the length.
    /// </summary>
    /// <value>The unit used to count the length. The default is <see cref="TextLengthUnit.Utf16CodeUnit" />.</value>
    public TextLengthUnit Unit { get; } = TextLengthUnit.Utf16CodeUnit;

    /// <summary>
    /// Gets the custom range message format.
    /// </summary>
    /// <value>The custom range message format.</value>
    public Func<string, string, long, long, string> CustomErrorMessageAccessor { get; set; }

    /// <inheritdoc/>
    protected override string DefaultErrorMessage => defaultErrorMessage;

    /// <inheritdoc/>
    protected override string CustomErrorMessage => CustomErrorMessageAccessor(Column, Value, MinLength, MaxLength);

    /// <inheritdoc/>
    protected override bool HasCustomErrorMessage => CustomErrorMessageAccessor != null;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        defaultErrorMessage = "";

        if (string.IsNullOrWhiteSpace(Value)) {
            return true;
        } else if (MinLength > 0 && MaxLength > 0) {
            defaultErrorMessage = ErrorMessageProvider.ValueLengthInRangeAccessor(Column, Value, MinLength, MaxLength);
            return ValidateRange();
        } else if (MinLength > 0) {
            defaultErrorMessage = ErrorMessageProvider.ValueLengthGreaterOrEqualAccessor(Column, Value, MinLength);
            return ValidateMinLength();
        } else if (MaxLength > 0) {
            defaultErrorMessage = ErrorMessageProvider.ValueLengthLessOrEqualAccessor(Column, Value, MaxLength);
            return ValidateMaxLength();
        } else {
            return true;
        }
    }

    private bool ValidateRange() {
        long length = GetLength();
        return length >= MinLength && length <= MaxLength;
    }

    private bool ValidateMinLength() {
        return GetLength() >= MinLength;
    }

    private bool ValidateMaxLength() {
        return GetLength() <= MaxLength;
    }

    private long GetLength() {
        return Unit switch {
            TextLengthUnit.UnicodeScalar => CountUnicodeScalars(Value),
            TextLengthUnit.TextElement => new StringInfo(Value).LengthInTextElements,
            _ => Value.Length
        };
    }

    private static long CountUnicodeScalars(string value) {
        long count = 0;

        for (int i = 0; i < value.Length; i++) {
            // 成對的 surrogate 視為一個字元，落單的 surrogate 仍各算一個
            if (char.IsHighSurrogate(value[i]) && i + 1 < value.Length && char.IsLowSurrogate(value[i + 1])) {
                i++;
            }

            count++;
        }

        return count;
    }
}
