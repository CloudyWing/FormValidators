using System.Threading;
using System.Threading.Tasks;

namespace CloudyWing.FormValidators;

/// <summary>
/// The form validator that validates asynchronously.
/// </summary>
/// <remarks>
/// <see cref="BulkValidatorExtensions.ValidateAsync(BulkValidator, CancellationToken)" /> awaits <see cref="ValidateAsync(CancellationToken)" />
/// for validators implementing this interface, while <see cref="BulkValidator.Validate" /> calls <see cref="IFormValidator.Validate" />.
/// An implementation that cannot validate synchronously may throw <see cref="System.NotSupportedException" /> from <see cref="IFormValidator.Validate" />.
/// </remarks>
public interface IAsyncFormValidator : IFormValidator {
    /// <summary>
    /// Validates this instance asynchronously.
    /// </summary>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>The task whose result is the validation result.</returns>
    Task<bool> ValidateAsync(CancellationToken cancellationToken = default);
}
