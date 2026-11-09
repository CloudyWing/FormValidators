using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// Validates that a value is one of the allowed values.
/// </summary>
/// <remarks>
/// The value is compared as is, without trimming. A <see langword="null" />, empty or white space value is valid.
/// </remarks>
public sealed class AllowedValuesValidator : FormValidatorBase {
    private readonly string[] allowedValues;

    /// <summary>
    /// Initializes a new instance of the <see cref="AllowedValuesValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="allowedValues">The allowed values.</param>
    /// <param name="comparisonType">The rule used to compare the value with the allowed values. The default is <see cref="StringComparison.Ordinal" />, which is case-sensitive.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, allowed values.</param>
    /// <exception cref="ArgumentNullException"><paramref name="allowedValues" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException"><paramref name="allowedValues" /> contains a <see langword="null" /> value.</exception>
    public AllowedValuesValidator(
        string column, string? value, IEnumerable<string> allowedValues,
        StringComparison comparisonType = StringComparison.Ordinal,
        Func<string, string?, IReadOnlyList<string>, string>? customErrorMessageAccessor = null
    ) : base(column, value) {
        if (allowedValues is null) {
            throw new ArgumentNullException(nameof(allowedValues));
        }

        List<string> values = [];

        foreach (string allowedValue in allowedValues) {
            if (allowedValue is null) {
                throw new ArgumentException("Allowed values cannot contain null.", nameof(allowedValues));
            }

            values.Add(allowedValue);
        }

        this.allowedValues = [.. values];
        AllowedValues = new ReadOnlyCollection<string>(this.allowedValues);
        ComparisonType = comparisonType;
        CustomErrorMessageAccessor = customErrorMessageAccessor;
    }

    /// <summary>
    /// Gets the allowed values.
    /// </summary>
    /// <value>The allowed values.</value>
    public IReadOnlyList<string> AllowedValues { get; }

    /// <summary>
    /// Gets the rule used to compare the value with the allowed values.
    /// </summary>
    /// <value>The rule used to compare the value with the allowed values.</value>
    public StringComparison ComparisonType { get; }

    /// <summary>
    /// Gets the custom error message accessor.
    /// </summary>
    /// <value>The custom error message accessor.</value>
    public Func<string, string?, IReadOnlyList<string>, string>? CustomErrorMessageAccessor { get; }

    /// <inheritdoc/>
    protected override string DefaultErrorMessage => ErrorMessageProvider.ValueIsInAllowedValuesAccessor(Column, Value, AllowedValues);

    /// <inheritdoc/>
    protected override string CustomErrorMessage => CustomErrorMessageAccessor!(Column, Value, AllowedValues);

    /// <inheritdoc/>
    protected override bool HasCustomErrorMessage => CustomErrorMessageAccessor != null;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        if (StringUtils.IsNullOrWhiteSpace(Value)) {
            return true;
        }

        foreach (string allowedValue in allowedValues) {
            if (string.Equals(Value, allowedValue, ComparisonType)) {
                return true;
            }
        }

        return false;
    }
}
