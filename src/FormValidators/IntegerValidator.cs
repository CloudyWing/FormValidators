using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>The integer validator.</summary>
    public sealed class IntegerValidator : ComparableTypeValidator<long> {
        /// <summary>Initializes a new instance of the <see cref="IntegerValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <param name="customRangeMessageFormat">The custom range message format.</param>
        public IntegerValidator(
            string column, string value,
            long? min = null, long? max = null,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) : base(column, value, min, max, customMessageFormat, customRangeMessageFormat) { }

        /// <summary>Initializes a new instance of the <see cref="IntegerValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        public IntegerValidator(string column, string value, string customMessageFormat)
            : this(column, value, null, null, customMessageFormat) { }

        /// <inheritdoc/>
        public override string DefaultErrorMessageFormat => "「{0}」必須為整數。";

        /// <inheritdoc/>
        protected override bool TryParse(string value, out long result) {
            return long.TryParse(value, out result);
        }

        /// <summary>Creates the minimum value validator.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <param name="customRangeMessageFormat">The custom range message format.</param>
        /// <returns>The minimum value validator</returns>
        public static IntegerValidator CreateMinValue(
            string column, string value, long min,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new IntegerValidator(column, value, min, null, customMessageFormat, customRangeMessageFormat);
        }

        /// <summary>Creates the maximum value validator.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <param name="customRangeMessageFormat">The custom range message format.</param>
        /// <returns>The maximum value validator</returns>
        public static IntegerValidator CreateMaxValue(
            string column, string value, long max,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new IntegerValidator(column, value, null, max, customMessageFormat, customRangeMessageFormat);
        }
    }
}
