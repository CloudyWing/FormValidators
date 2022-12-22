namespace CloudyWing.FormValidators {
    public sealed class EmailValidator : RegexValidator {
        public EmailValidator(string column, string value, string customMessageFormat = null)
            : base(column, value, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", customMessageFormat) {
        }

        public override string DefaultErrorMessageFormat => "「{0}」必須為正確E-mail格式。";
    }
}