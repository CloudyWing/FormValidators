using System;
using System.Threading;
using System.Threading.Tasks;

namespace CloudyWing.FormValidators;

/// <summary>
/// Provides extension methods for <see cref="BulkValidator" />.
/// </summary>
public static class BulkValidatorExtensions {
    /// <summary>
    /// Validates the validators asynchronously.
    /// </summary>
    /// <remarks>
    /// The validators run one by one in order. <see cref="IAsyncFormValidator" /> is awaited, nested <see cref="BulkValidator" /> is validated asynchronously,
    /// and the other validators are validated synchronously. <see cref="BulkValidator.IsStoppedIfFail" /> stops at the first failure as <see cref="BulkValidator.Validate" /> does.
    /// The validators must not be modified until the task completes.
    /// </remarks>
    /// <param name="validators">The validators.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. It is checked before each validator runs.</param>
    /// <returns>The task whose result is the validation result.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="validators" /> is <see langword="null" />.</exception>
    /// <exception cref="OperationCanceledException"><paramref name="cancellationToken" /> is canceled.</exception>
    public static async Task<bool> ValidateAsync(this BulkValidator validators, CancellationToken cancellationToken = default) {
        if (validators is null) {
            throw new ArgumentNullException(nameof(validators));
        }

        return await validators.ValidateCoreAsync(cancellationToken).ConfigureAwait(false);
    }
}
