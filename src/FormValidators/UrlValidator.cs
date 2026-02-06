using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// The URL validator.
/// </summary>
public sealed class UrlValidator : BasicFormValidator {
    /// <summary>
    /// Initializes a new instance of the <see cref="UrlValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    public UrlValidator(string column, string value, Func<string, string, string> customErrorMessageAccessor = null)
        : base(column, value, customErrorMessageAccessor) {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UrlValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="kind">The kind.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    public UrlValidator(string column, string value, UriKind kind, Func<string, string, string> customErrorMessageAccessor = null)
        : this(column, value, customErrorMessageAccessor) {
        Kind = kind;
    }

    /// <summary>
    /// Gets the kind.
    /// </summary>
    /// <value>The kind.</value>
    public UriKind Kind { get; } = UriKind.Absolute;

    /// <inheritdoc/>
    protected override Func<string, string, string> DefaultErrorMessageAccessor => ErrorMessageProvider.ValueIsUrlAccessor;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        if (string.IsNullOrWhiteSpace(Value)) {
            return true;
        }

        return Uri.TryCreate(Value, Kind, out _);
    }
}
