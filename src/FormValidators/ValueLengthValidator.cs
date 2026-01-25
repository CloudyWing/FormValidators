using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>Validation constraints a value does not exceed the length range.</summary>
/// <seealso cref="FormValidatorBase" />
public sealed class ValueLengthValidator : FormValidatorBase {
    private string defaultErrorMessage;

    /// <summary>Initializes a new instance of the <see cref="ValueLengthValidator" /> class.</summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    public ValueLengthValidator(
        string column, string value, long max,
        Func<string, string, long, long, string> customErrorMessageAccessor = null
    ) : this(column, value, 0, max, customErrorMessageAccessor) { }

    /// <summary>Initializes a new instance of the <see cref="ValueLengthValidator" /> class.</summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="min">The minimum. Less than or equal to 0 means unlimited.</param>
    /// <param name="max">The maximum. Less than or equal to 0 means unlimited.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    public ValueLengthValidator(
        string column, string value,
        long min, long max,
        Func<string, string, long, long, string> customErrorMessageAccessor = null
    ) : base(column, value) {
        MinLength = min < 0 ? 0 : min;
        MaxLength = max < 0 ? 0 : max;
        CustomErrorMessageAccessor = customErrorMessageAccessor;
    }

    /// <summary>Gets the minimum length.</summary>
    /// <value>The minimum length.</value>
    public long MinLength { get; }

    /// <summary>Gets the maximum length.</summary>
    /// <value>The maximum length.</value>
    public long MaxLength { get; }

    /// <summary>Gets the custom range message format.</summary>
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
        return Value.Length >= MinLength && Value.Length <= MaxLength;
    }

    private bool ValidateMinLength() {
        return Value.Length >= MinLength;
    }

    private bool ValidateMaxLength() {
        return Value.Length <= MaxLength;
    }
}
