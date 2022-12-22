using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>The number less than validator.</summary>
    public sealed class NumberLessThanValidator : LessThanValidator<decimal> {
        /// <summary>Initializes a new instance of the <see cref="NumberLessThanValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="comparisonColumn">The comparison column.</param>
        /// <param name="comparisonValue">The comparison value.</param>
        /// <param name="allowedEquals">if set to <c>true</c> [allowed equals].</param>
        /// <param name="customMessageFormat">The custom message format. Format argument: {0}:column {1}:comparisonColumn</param>
        public NumberLessThanValidator(
            string column, string value, string comparisonColumn, string comparisonValue,
            bool allowedEquals = true, string customMessageFormat = null)
            : base(column, value, comparisonColumn, comparisonValue, allowedEquals, customMessageFormat) { }

        /// <inheritdoc/>
        protected override bool TryParse(string value, out decimal result) {
            return decimal.TryParse(value, out result);
        }
    }
}
