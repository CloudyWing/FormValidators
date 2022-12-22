namespace CloudyWing.FormValidators {
    using Core;

    public sealed class IntegerValidator : ComparableTypeValidator<long> {
        public IntegerValidator(
            string column, string value,
            long? min = null, long? max = null,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) : base(column, value, min, max, customMessageFormat, customRangeMessageFormat) { }

        public IntegerValidator(string column, string value, string customMessageFormat)
            : this(column, value, null, null, customMessageFormat) { }

        public override string DefaultErrorMessageFormat => "「{0}」必須為整數。";

        protected override bool TryParse(string value, out long result) => long.TryParse(value, out result);

        public static IntegerValidator CreateMinValue(
            string column, string value, long min,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new IntegerValidator(column, value, min, null, customMessageFormat, customRangeMessageFormat);
        }

        public static IntegerValidator CreateMaxValue(
            string column, string value, long max,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new IntegerValidator(column, value, null, max, customMessageFormat, customRangeMessageFormat);
        }
    }
}