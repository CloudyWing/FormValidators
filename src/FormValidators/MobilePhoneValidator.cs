namespace CloudyWing.FormValidators {
    /// <summary>The mobile phone validator.</summary>
    public sealed class MobilePhoneValidator : RegexValidator {
        /// <summary>Initializes a new instance of the <see cref="MobilePhoneValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        public MobilePhoneValidator(string column, string value, string customMessageFormat = null)
            : base(column, value, @"^09(?:\d){2}-?(?:\d){6}$", customMessageFormat) {
        }

        /// <summary>Gets the default error message format.</summary>
        /// <value>The default error message format.</value>
        public override string DefaultErrorMessageFormat => "「{0}」必須為正確手機號碼格式。";
    }
}
