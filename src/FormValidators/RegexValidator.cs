using System;
using System.Text.RegularExpressions;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// The regex validator.
/// </summary>
public class RegexValidator : BasicFormValidator {
    /// <summary>
    /// Initializes a new instance of the <see cref="RegexValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="pattern">The pattern.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">pattern</exception>
    public RegexValidator(string column, string? value, string pattern, Func<string, string?, string>? customErrorMessageAccessor = null)
        : base(column, value, customErrorMessageAccessor) {
        Pattern = pattern ?? throw new ArgumentNullException(nameof(pattern));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RegexValidator" /> class with the regex options and the match timeout.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="pattern">The pattern.</param>
    /// <param name="options">The regex options.</param>
    /// <param name="matchTimeout">The match timeout, or <see cref="Regex.InfiniteMatchTimeout" />. When a match times out, the validation fails.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException"><paramref name="pattern" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException"><paramref name="pattern" /> is not a valid regular expression, or <paramref name="options" /> contains an invalid flag.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="matchTimeout" /> is zero, negative or too large, and is not <see cref="Regex.InfiniteMatchTimeout" />.</exception>
    public RegexValidator(
        string column, string? value, string pattern, RegexOptions options, TimeSpan matchTimeout,
        Func<string, string?, string>? customErrorMessageAccessor
    ) : this(column, value, CreateRegex(pattern, options, matchTimeout), customErrorMessageAccessor) {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RegexValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="regex">The regex.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">regex</exception>
    public RegexValidator(string column, string? value, Regex regex, Func<string, string?, string>? customErrorMessageAccessor = null)
        : base(column, value, customErrorMessageAccessor) {
        RegexInstance = regex ?? throw new ArgumentNullException(nameof(regex));
        Pattern = regex.ToString();
    }

    /// <summary>
    /// Gets the pattern.
    /// </summary>
    /// <value>The pattern.</value>
    public string Pattern { get; protected set; }

    /// <summary>
    /// Gets or sets the regex instance.
    /// </summary>
    /// <value>The regex instance.</value>
    protected Regex? RegexInstance { get; set; }

    /// <inheritdoc/>
    protected override Func<string, string?, string> DefaultErrorMessageAccessor => ErrorMessageProvider.ValueMatchRegexAccessor;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        // 是否有填資料由 RequiredValidator 驗證，所以沒填就不驗證
        if (StringUtils.IsNullOrWhiteSpace(Value)) {
            return true;
        }

        // 逾時代表輸入無法在時限內判定，視為驗證失敗而非拋出例外
        try {
            if (RegexInstance is not null) {
                return RegexInstance.IsMatch(Value);
            }

            TimeSpan timeout = ValidatorDefaults.RegexTimeout;

            // 未設定 timeout 時呼叫不帶 timeout 的多載，保留應用程式網域的 REGEX_DEFAULT_MATCH_TIMEOUT 設定
            return timeout == Regex.InfiniteMatchTimeout
                ? Regex.IsMatch(Value, Pattern)
                : Regex.IsMatch(Value, Pattern, RegexOptions.None, timeout);
        } catch (RegexMatchTimeoutException) {
            return false;
        }
    }

    private static Regex CreateRegex(string pattern, RegexOptions options, TimeSpan matchTimeout) {
        if (pattern is null) {
            throw new ArgumentNullException(nameof(pattern));
        }

        ValidatorDefaults.ValidateRegexTimeout(matchTimeout, nameof(matchTimeout));

        return new Regex(pattern, options, matchTimeout);
    }
}
