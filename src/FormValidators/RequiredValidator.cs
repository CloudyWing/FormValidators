using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>The required validator.</summary>
    public sealed class RequiredValidator : FormValidatorBase {
        /// <summary>Initializes a new instance of the <see cref="RequiredValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        public RequiredValidator(string column, string value, string customMessageFormat = null)
            : base(column, value, customMessageFormat) { }

        /// <inheritdoc/>
        public override string DefaultErrorMessageFormat => "「{0}」欄位為必填。";

        /// <inheritdoc/>
        protected override bool ValidateValue() {
            return !string.IsNullOrWhiteSpace(Value);
        }
    }
}
