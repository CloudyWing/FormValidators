using System;
using System.Threading;
using System.Threading.Tasks;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// Validates a value with a custom asynchronous predicate, such as checking whether an account already exists.
/// </summary>
/// <remarks>
/// The predicate is not called when the value is <see langword="null" />, empty or white space; such a value is valid.
/// This validator only supports <see cref="ValidateAsync(CancellationToken)" /> and
/// <see cref="BulkValidatorExtensions.ValidateAsync(BulkValidator, CancellationToken)" />.
/// </remarks>
public sealed class AsyncCustomValidator : BasicFormValidator, IAsyncFormValidator {
    private readonly Func<string, CancellationToken, Task<bool>> predicate;

    /// <summary>
    /// Initializes a new instance of the <see cref="AsyncCustomValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="predicate">The asynchronous predicate whose result is <see langword="true" /> when the value is valid.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException"><paramref name="predicate" /> is <see langword="null" />.</exception>
    public AsyncCustomValidator(
        string column, string? value, Func<string, CancellationToken, Task<bool>> predicate,
        Func<string, string?, string>? customErrorMessageAccessor = null
    ) : base(column, value, customErrorMessageAccessor) {
        this.predicate = predicate ?? throw new ArgumentNullException(nameof(predicate));
    }

    /// <inheritdoc/>
    protected override Func<string, string?, string> DefaultErrorMessageAccessor => ErrorMessageProvider.ValueMatchCustomRuleAccessor;

    /// <inheritdoc/>
    public async Task<bool> ValidateAsync(CancellationToken cancellationToken = default) {
        if (StringUtils.IsNullOrWhiteSpace(Value)) {
            return SetValidationResult(true);
        }

        bool isValid = await predicate(Value, cancellationToken).ConfigureAwait(false);

        return SetValidationResult(isValid);
    }

    /// <inheritdoc/>
    /// <exception cref="NotSupportedException">Always thrown, because the predicate is asynchronous.</exception>
    protected override bool ValidateValue() {
        // 同步等待非同步 predicate 在具 SynchronizationContext 的環境（如 Web Form）可能死結，因此不提供
        throw new NotSupportedException($"{nameof(AsyncCustomValidator)} only supports {nameof(ValidateAsync)}.");
    }
}
