using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// The email validator.
/// </summary>
/// <seealso cref="RegexValidator" />
public sealed class EmailValidator : RegexValidator {
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    public EmailValidator(string column, string value, Func<string, string, string> customErrorMessageAccessor = null)
        : base(column, value, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", customErrorMessageAccessor) {
    }

    /// <inheritdoc/>
    protected override Func<string, string, string> DefaultErrorMessageAccessor => ErrorMessageProvider.ValueIsEmailAccessor;
}
