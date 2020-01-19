namespace CloudyWing.FormValidators {
    public sealed class MobilePhoneValidator : RegexValidator {
        public MobilePhoneValidator(string column, string value, string customMessageFormat = null)
            : base(column, value, @"^09(?:\d){2}-?(?:\d){6}$", customMessageFormat) {
        }

        public override string DefaultErrorMessageFormat => "「{0}」必須為正確手機號碼格式。";
    }
}