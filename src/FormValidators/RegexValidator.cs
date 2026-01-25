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
    public RegexValidator(string column, string value, string pattern, Func<string, string, string> customErrorMessageAccessor = null)
        : base(column, value, customErrorMessageAccessor) {
        Pattern = pattern ?? throw new(nameof(pattern));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RegexValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="regex">The regex.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">regex</exception>
    public RegexValidator(string column, string value, Regex regex, Func<string, string, string> customErrorMessageAccessor = null)
        : base(column, value, customErrorMessageAccessor) {
        RegexInstance = regex ?? throw new(nameof(regex));
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
    protected Regex RegexInstance { get; set; }

    /// <inheritdoc/>
    protected override Func<string, string, string> DefaultErrorMessageAccessor => ErrorMessageProvider.ValueMatchRegexAccessor;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        // 是否有填資料由 RequiredValidator 驗證，所以沒填就不驗證
        if (string.IsNullOrWhiteSpace(Value)) {
            return true;
        }

        return RegexInstance is null
            ? Regex.IsMatch(Value, Pattern)
            : RegexInstance.IsMatch(Value);
    }
}
