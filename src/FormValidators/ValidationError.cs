using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// The structured result of a failed validation.
/// </summary>
public sealed class ValidationError {
    /// <summary>
    /// Initializes a new instance of the <see cref="ValidationError" /> class.
    /// </summary>
    /// <param name="column">The column, or <see langword="null" /> when the validator does not have a column.</param>
    /// <param name="message">The error message.</param>
    /// <param name="validator">The validator that failed.</param>
    /// <exception cref="ArgumentNullException"><paramref name="message" /> or <paramref name="validator" /> is <see langword="null" />.</exception>
    public ValidationError(string? column, string message, IFormValidator validator) {
        Column = column;
        Message = message ?? throw new ArgumentNullException(nameof(message));
        Validator = validator ?? throw new ArgumentNullException(nameof(validator));
    }

    /// <summary>
    /// Gets the column.
    /// </summary>
    /// <value>
    /// The column of a <see cref="FormValidatorBase" />, or <see langword="null" /> for validators without a column,
    /// such as <see cref="TrueAssertValidator" /> and <see cref="FalseAssertValidator" />.
    /// </value>
    public string? Column { get; }

    /// <summary>
    /// Gets the error message.
    /// </summary>
    /// <value>The error message.</value>
    public string Message { get; }

    /// <summary>
    /// Gets the validator that failed.
    /// </summary>
    /// <value>The validator that failed. Errors of a nested <see cref="BulkValidator" /> refer to the inner validators.</value>
    public IFormValidator Validator { get; }

    /// <summary>
    /// Gets the type of the validator that failed.
    /// </summary>
    /// <value>The type of the validator that failed.</value>
    public Type ValidatorType => Validator.GetType();
}
