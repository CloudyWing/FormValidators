using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>The compare validator.</summary>
    /// <seealso cref="FormValidatorBase" />
    public class CompareValidator : FormValidatorBase {
        /// <summary>Initializes a new instance of the <see cref="CompareValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="comparisonColumn">The comparison column.</param>
        /// <param name="comparisonValue">The comparison value.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        public CompareValidator(string column, string value, string comparisonColumn, string comparisonValue, string customMessageFormat = null)
            : base(column, value, customMessageFormat) {
            ComparisonColumn = comparisonColumn;
            ComparisonValue = comparisonValue;
        }

        /// <summary>Gets the comparison column.</summary>
        /// <value>The comparison column.</value>
        public string ComparisonColumn { get; }

        /// <summary>Gets the comparison value.</summary>
        /// <value>The comparison value.</value>
        public string ComparisonValue { get; }

        /// <inheritdoc/>
        public override string DefaultErrorMessageFormat => "「{0}」和「{1}」輸入不一致。";

        /// <inheritdoc/>
        protected override bool ValidateValue() {
            // 是否有填資料由RequiredValidator驗證，所以沒填就不驗證
            return string.IsNullOrWhiteSpace(Value) || Value == ComparisonValue;
        }

        /// <inheritdoc/>
        protected override string CreateErrorMessage() {
            return string.IsNullOrWhiteSpace(CustomErrorMessageFormat) ?
                string.Format(DefaultErrorMessageFormat, Column, ComparisonColumn) : string.Format(CustomErrorMessageFormat, Column, ComparisonColumn);
        }
    }
}
