using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// The bulk validator.
/// </summary>
public class BulkValidator : Collection<IFormValidator>, IFormValidator {
    private readonly List<string> errorMessages = [];
    private readonly ReadOnlyCollection<string> readOnlyErrorMessages;

    /// <summary>
    /// Initializes a new instance of the <see cref="BulkValidator" /> class.
    /// </summary>
    /// <param name="isStoppedIfFail">if set to <c>true</c> [is stopped if fail].</param>
    public BulkValidator(bool isStoppedIfFail = false) {
        readOnlyErrorMessages = new ReadOnlyCollection<string>(errorMessages);
        IsStoppedIfFail = isStoppedIfFail;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BulkValidator" /> class.
    /// </summary>
    /// <param name="configure">The configure.</param>
    /// <param name="isStoppedIfFail">if set to <c>true</c> [is stopped if fail].</param>
    /// <exception cref="ArgumentNullException"><paramref name="configure" /> is <see langword="null" />.</exception>
    public BulkValidator(Action<ValidatorConfiguration> configure, bool isStoppedIfFail = false) {
        if (configure is null) {
            throw new ArgumentNullException(nameof(configure));
        }

        readOnlyErrorMessages = new ReadOnlyCollection<string>(errorMessages);
        IsStoppedIfFail = isStoppedIfFail;
        configure(new ValidatorConfiguration(this));
    }

    /// <summary>
    /// Gets the error message, separated by br.
    /// </summary>
    /// <value>The error message.</value>
    public string ErrorMessage => ErrorMessageWithBR;

    /// <summary>
    /// Gets the error message, separated by br.
    /// </summary>
    /// <value>The error message separated by br.</value>
    public string ErrorMessageWithBR => GetErrorMessage("<br />");

    /// <summary>
    /// Gets the error message, separated by newlines.
    /// </summary>
    /// <value>The error message separated by new line.</value>
    public string ErrorMessageWithNewLine => GetErrorMessage(Environment.NewLine);

    /// <summary>
    /// Gets the error message, separated by <c>\n</c>.
    /// </summary>
    /// <value>The error message separated by <c>\n</c>.</value>
    public string ErrorMessageWithLF => GetErrorMessage("\n");

    /// <summary>
    /// Gets the error messages.
    /// </summary>
    /// <value>The error messages.</value>
    public IReadOnlyCollection<string> ErrorMessages => readOnlyErrorMessages;

    /// <summary>
    /// Returns true if ... is valid.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
    public bool IsValid { get; private set; } = false;

    /// <summary>
    /// Gets a value indicating whether this instance is stopped if fail.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is stopped if fail; otherwise, <c>false</c>.</value>
    public bool IsStoppedIfFail { get; }

    /// <inheritdoc/>
    public bool Validate() {
        errorMessages.Clear();

        foreach (IFormValidator item in Items) {
            if (!item.Validate()) {
                if (item is BulkValidator innerItems) {
                    errorMessages.AddRange(innerItems.errorMessages);
                } else {
                    errorMessages.Add(item.ErrorMessage);
                }
                if (IsStoppedIfFail) {
                    break;
                }
            }
        }
        IsValid = errorMessages.Count == 0;

        return IsValid;
    }

    private string GetErrorMessage(string separator) {
        return string.Join(separator, errorMessages);
    }
}
