namespace CloudyWing.FormValidators {
    /// <summary>The email validator.</summary>
    /// <seealso cref="RegexValidator" />
    public sealed class EmailValidator : RegexValidator {
        /// <summary>Initializes a new instance of the <see cref="EmailValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        public EmailValidator(string column, string value, string customMessageFormat = null)
            : base(column, value, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", customMessageFormat) {
        }

        /// <inheritdoc/>
        public override string DefaultErrorMessageFormat => "「{0}」必須為正確E-mail格式。";
    }
}
