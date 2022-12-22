using System.Text.RegularExpressions;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>The regex validator.</summary>
    public class RegexValidator : FormValidatorBase {
        /// <summary>Initializes a new instance of the <see cref="RegexValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="pattern">The pattern.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        public RegexValidator(string column, string value, string pattern, string customMessageFormat = null)
            : base(column, value, customMessageFormat) {
            Pattern = pattern;
        }

        /// <summary>Gets the pattern.</summary>
        /// <value>The pattern.</value>
        public string Pattern { get; }

        /// <inheritdoc/>
        public override string DefaultErrorMessageFormat => "「{0}」格式錯誤。";

        /// <inheritdoc/>
        protected override bool ValidateValue() {
            // 是否有填資料由RequiredValidator驗證，所以沒填就不驗證
            return string.IsNullOrWhiteSpace(Value) || Regex.IsMatch(Value, Pattern);
        }
    }
}
