namespace CloudyWing.FormValidators {
    using Core;

    public sealed class NumberValidator : ComparableTypeValidator<decimal> {
        public NumberValidator(
            string column, string value,
            decimal? min = null, decimal? max = null,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) : base(column, value, min, max, customMessageFormat, customRangeMessageFormat) { }

        public NumberValidator(string column, string value, string customMessageFormat)
            : this(column, value, null, null, customMessageFormat) { }

        public override string DefaultErrorMessageFormat => "「{0}」必須為數值。";

        protected override bool TryParse(string value, out decimal result) => decimal.TryParse(value, out result);

        public static NumberValidator CreateMinValue(
            string column, string value, decimal min,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new NumberValidator(column, value, min, null, customMessageFormat, customRangeMessageFormat);
        }

        public static NumberValidator CreateMaxValue(
            string column, string value, decimal max,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new NumberValidator(column, value, null, max, customMessageFormat, customRangeMessageFormat);
        }
    }
}