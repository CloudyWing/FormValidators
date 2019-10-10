namespace CloudyWing.FormValidators {
    public sealed class MobilePhoneValidator : RegexValidator {
        public MobilePhoneValidator(string column, string value, string customMessageFormat = null)
            : base(column, value, @"^[0][9][0-9]{8}$", customMessageFormat) {
        }

        public override string DefaultErrorMessageFormat => "「{0}」必須為正確手機號碼格式。";
    }
}