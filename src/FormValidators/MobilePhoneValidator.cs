namespace CloudyWing.FormValidators {
    /// <summary>The mobile phone validator.</summary>
    public sealed class MobilePhoneValidator : RegexValidator {
        private const string BasicPattern = @"^09\d{2}-?\d{3}-?\d{3}$";

        /// <summary>Initializes a new instance of the <see cref="MobilePhoneValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        public MobilePhoneValidator(string column, string value, string customMessageFormat = null)
            : this(column, value, MobilePhoneFormats.All, customMessageFormat) {
        }

        /// <summary>Initializes a new instance of the <see cref="MobilePhoneValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="formats">The formats.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        public MobilePhoneValidator(string column, string value, MobilePhoneFormats formats, string customMessageFormat = null)
            : base(column, value, customMessageFormat) {
            if (formats.HasFlag(MobilePhoneFormats.AllowContainDashes) && !formats.HasFlag(MobilePhoneFormats.AllowWithoutDashes)) {
                Pattern = BasicPattern.Replace("-?", "-");
            } else if (!formats.HasFlag(MobilePhoneFormats.AllowContainDashes) && formats.HasFlag(MobilePhoneFormats.AllowWithoutDashes)) {
                Pattern = BasicPattern.Replace("-?", "");
            } else {
                Pattern = BasicPattern;
            }
        }

        /// <summary>Gets the default error message format.</summary>
        /// <value>The default error message format.</value>
        public override string DefaultErrorMessageFormat => "「{0}」必須為正確手機號碼格式。";
    }
}
