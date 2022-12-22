using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>The number validator.</summary>
    public sealed class NumberValidator : ComparableTypeValidator<decimal> {
        /// <summary>Initializes a new instance of the <see cref="NumberValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <param name="customRangeMessageFormat">The custom range message format.</param>
        public NumberValidator(
            string column, string value,
            decimal? min = null, decimal? max = null,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) : base(column, value, min, max, customMessageFormat, customRangeMessageFormat) { }

        /// <summary>Initializes a new instance of the <see cref="NumberValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        public NumberValidator(string column, string value, string customMessageFormat)
            : this(column, value, null, null, customMessageFormat) { }

        /// <inheritdoc/>
        public override string DefaultErrorMessageFormat => "「{0}」必須為數值。";

        /// <inheritdoc/>
        protected override bool TryParse(string value, out decimal result) {
            return decimal.TryParse(value, out result);
        }

        /// <summary>Creates the minimum value validator.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <param name="customRangeMessageFormat">The custom range message format.</param>
        /// <returns>The minimum value validator.</returns>
        public static NumberValidator CreateMinValue(
            string column, string value, decimal min,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new NumberValidator(column, value, min, null, customMessageFormat, customRangeMessageFormat);
        }

        /// <summary>Creates the maximum value validator.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <param name="customRangeMessageFormat">The custom range message format.</param>
        /// <returns>The maximum value validator.</returns>
        public static NumberValidator CreateMaxValue(
            string column, string value, decimal max,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new NumberValidator(column, value, null, max, customMessageFormat, customRangeMessageFormat);
        }
    }
}
