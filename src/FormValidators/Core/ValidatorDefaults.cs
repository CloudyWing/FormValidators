using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace CloudyWing.FormValidators.Core;

/// <summary>
/// The application-wide default settings of the validators.
/// </summary>
/// <remarks>
/// The settings are global. Each property can be read and replaced atomically from any thread,
/// but configure them once when the application starts.
/// </remarks>
public static class ValidatorDefaults {
    private static long regexTimeoutTicks = Regex.InfiniteMatchTimeout.Ticks;

    /// <summary>
    /// Gets or sets the match timeout used by <see cref="RegexValidator" /> created with a pattern string.
    /// </summary>
    /// <remarks>
    /// It applies to the constructors that accept a pattern without an explicit timeout.
    /// A <see cref="RegexValidator" /> created with a <see cref="Regex" /> instance uses the timeout of that instance.
    /// When a match times out, the validation fails instead of throwing <see cref="RegexMatchTimeoutException" />.
    /// </remarks>
    /// <value>The match timeout. The default is <see cref="Regex.InfiniteMatchTimeout" />, which keeps the timeout configured for the application domain.</value>
    /// <exception cref="ArgumentOutOfRangeException">The value is zero, negative or greater than about 24 days, and is not <see cref="Regex.InfiniteMatchTimeout" />.</exception>
    public static TimeSpan RegexTimeout {
        get => TimeSpan.FromTicks(Volatile.Read(ref regexTimeoutTicks));
        set {
            ValidateRegexTimeout(value, nameof(value));
            Volatile.Write(ref regexTimeoutTicks, value.Ticks);
        }
    }

    internal static void ValidateRegexTimeout(TimeSpan timeout, string paramName) {
        // 與 Regex 建構子的限制一致：必須為正值且不超過 Int32.MaxValue - 1 毫秒
        if (timeout == Regex.InfiniteMatchTimeout) {
            return;
        }

        if (timeout <= TimeSpan.Zero || timeout.TotalMilliseconds >= int.MaxValue) {
            throw new ArgumentOutOfRangeException(paramName, timeout, "The timeout must be positive and less than about 24 days, or Regex.InfiniteMatchTimeout.");
        }
    }

    internal static void ResetToDefaults() {
        Volatile.Write(ref regexTimeoutTicks, Regex.InfiniteMatchTimeout.Ticks);
    }
}
