using System.Text.RegularExpressions;

namespace CloudyWing.FormValidators {
    public class RegexValidator : FormValidatorBase {
        public RegexValidator(string column, string value, string pattern, string customMessageFormat = null)
            : base(column, value, customMessageFormat) {
            Pattern = pattern;
        }

        public string Pattern { get; }

        public override string DefaultErrorMessageFormat => "「{0}」格式錯誤。";

        protected override bool ValidateValue() {
            // 是否有填資料由RequiredValidator驗證，所以沒填就不驗證
            return string.IsNullOrWhiteSpace(Value) || Regex.IsMatch(Value, Pattern);
        }
    }
}