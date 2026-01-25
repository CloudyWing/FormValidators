using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>Validation indicate that a value is required.</summary>
public sealed class RequiredValidator : BasicFormValidator {
    /// <summary>Initializes a new instance of the <see cref="RequiredValidator" /> class.</summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value.</param>
    public RequiredValidator(string column, string value, Func<string, string, string> customErrorMessageAccessor = null)
        : base(column, value, customErrorMessageAccessor) { }

    /// <inheritdoc/>
    protected override Func<string, string, string> DefaultErrorMessageAccessor => ErrorMessageProvider.ValueIsRequiredAccessor;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        return !string.IsNullOrWhiteSpace(Value);
    }
}
