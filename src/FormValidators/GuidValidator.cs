using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// Validates that a value is a GUID.
/// </summary>
/// <remarks>
/// The value is parsed by <see cref="Guid.TryParse(string, out Guid)" />, which accepts the <c>N</c>, <c>D</c>, <c>B</c>, <c>P</c> and <c>X</c> formats and ignores leading and trailing white space.
/// </remarks>
public sealed class GuidValidator : BasicFormValidator {
    /// <summary>
    /// Initializes a new instance of the <see cref="GuidValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    public GuidValidator(string column, string? value, Func<string, string?, string>? customErrorMessageAccessor = null)
        : base(column, value, customErrorMessageAccessor) {
    }

    /// <inheritdoc/>
    protected override Func<string, string?, string> DefaultErrorMessageAccessor => ErrorMessageProvider.ValueIsGuidAccessor;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        return StringUtils.IsNullOrWhiteSpace(Value) || Guid.TryParse(Value, out _);
    }
}
