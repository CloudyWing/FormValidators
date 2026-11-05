using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// Validates a value with a custom predicate.
/// </summary>
/// <remarks>
/// The predicate is not called when the value is <see langword="null" />, empty or white space; such a value is valid.
/// Use <see cref="RequiredValidator" /> to require a value.
/// </remarks>
public sealed class CustomValidator : BasicFormValidator {
    private readonly Func<string, bool> predicate;

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="predicate">The predicate that returns <see langword="true" /> when the value is valid.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException"><paramref name="predicate" /> is <see langword="null" />.</exception>
    public CustomValidator(string column, string? value, Func<string, bool> predicate, Func<string, string?, string>? customErrorMessageAccessor = null)
        : base(column, value, customErrorMessageAccessor) {
        this.predicate = predicate ?? throw new ArgumentNullException(nameof(predicate));
    }

    /// <inheritdoc/>
    protected override Func<string, string?, string> DefaultErrorMessageAccessor => ErrorMessageProvider.ValueMatchCustomRuleAccessor;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        return StringUtils.IsNullOrWhiteSpace(Value) || predicate(Value);
    }
}
