using System;
using System.Text.RegularExpressions;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>The regex validator.</summary>
public class RegexValidator : BasicFormValidator {
    /// <summary>Initializes a new instance of the <see cref="RegexValidator" /> class.</summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="pattern">The pattern.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value.</param>
    /// <exception cref="ArgumentNullException">pattern</exception>
    public RegexValidator(string column, string value, string pattern, Func<string, string, string> customErrorMessageAccessor = null)
        : base(column, value, customErrorMessageAccessor) {
        Pattern = pattern ?? throw new ArgumentNullException(nameof(pattern));
    }

    /// <summary>Gets the pattern.</summary>
    /// <value>The pattern.</value>
    public string Pattern { get; protected set; }

    /// <inheritdoc/>
    protected override Func<string, string, string> DefaultErrorMessageAccessor => ErrorMessageProvider.ValueMatchRegexAccessor;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        // 是否有填資料由RequiredValidator驗證，所以沒填就不驗證
        return string.IsNullOrWhiteSpace(Value) || Regex.IsMatch(Value, Pattern);
    }
}
