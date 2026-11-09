using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// The bulk validator.
/// </summary>
/// <remarks>
/// The results of the last validation are stored in <see cref="IsValid" />, <see cref="ErrorMessages" /> and <see cref="Errors" />.
/// An instance is not thread-safe; do not validate or modify the same instance from multiple threads at the same time.
/// </remarks>
public class BulkValidator : Collection<IFormValidator>, IFormValidator {
    private readonly List<string> errorMessages = [];
    private readonly ReadOnlyCollection<string> readOnlyErrorMessages;
    private readonly List<ValidationError> errors = [];
    private readonly ReadOnlyCollection<ValidationError> readOnlyErrors;

    /// <summary>
    /// Initializes a new instance of the <see cref="BulkValidator" /> class.
    /// </summary>
    /// <param name="isStoppedIfFail">if set to <c>true</c> [is stopped if fail].</param>
    public BulkValidator(bool isStoppedIfFail = false) {
        readOnlyErrorMessages = new ReadOnlyCollection<string>(errorMessages);
        readOnlyErrors = new ReadOnlyCollection<ValidationError>(errors);
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
        readOnlyErrors = new ReadOnlyCollection<ValidationError>(errors);
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
    /// Gets the structured errors of the last validation.
    /// </summary>
    /// <value>
    /// The errors in the same order as <see cref="ErrorMessages" />. Errors of a nested <see cref="BulkValidator" /> are flattened.
    /// </value>
    public IReadOnlyList<ValidationError> Errors => readOnlyErrors;

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
        ClearResult();

        foreach (IFormValidator item in Items) {
            if (!item.Validate()) {
                AddFailure(item);

                if (IsStoppedIfFail) {
                    break;
                }
            }
        }

        return CompleteResult();
    }

    internal async Task<bool> ValidateCoreAsync(CancellationToken cancellationToken) {
        ClearResult();

        foreach (IFormValidator item in Items) {
            cancellationToken.ThrowIfCancellationRequested();

            bool isValid = item switch {
                BulkValidator innerItems => await innerItems.ValidateCoreAsync(cancellationToken).ConfigureAwait(false),
                IAsyncFormValidator asyncItem => await asyncItem.ValidateAsync(cancellationToken).ConfigureAwait(false),
                _ => item.Validate()
            };

            if (!isValid) {
                AddFailure(item);

                if (IsStoppedIfFail) {
                    break;
                }
            }
        }

        return CompleteResult();
    }

    private void ClearResult() {
        errorMessages.Clear();
        errors.Clear();
    }

    private void AddFailure(IFormValidator item) {
        if (item is BulkValidator innerItems) {
            errorMessages.AddRange(innerItems.errorMessages);
            errors.AddRange(innerItems.errors);
        } else {
            errorMessages.Add(item.ErrorMessage);

            // 自訂 IFormValidator 可能在未啟用 NRT 的專案回傳 null，結構化結果以空字串保存
            errors.Add(new ValidationError((item as FormValidatorBase)?.Column, item.ErrorMessage ?? "", item));
        }
    }

    private bool CompleteResult() {
        IsValid = errorMessages.Count == 0;

        return IsValid;
    }

    private string GetErrorMessage(string separator) {
        return string.Join(separator, errorMessages);
    }
}
