using System;

namespace CloudyWing.FormValidators {
    using Core;

    public sealed class DateTimeValidator : ComparableTypeValidator<DateTime> {
        public DateTimeValidator(
            string column, string value,
            DateTime? min = null, DateTime? max = null,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) : base(column, value, min, max, customMessageFormat, customRangeMessageFormat) { }

        public DateTimeValidator(string column, string value, string customMessageFormat)
            : this(column, value, null, null, customMessageFormat) { }

        public override string DefaultErrorMessageFormat => "「{0}」必須為正確日期格式。";

        protected override bool TryParse(string value, out DateTime result) => DateTime.TryParse(value, out result);

        public static DateTimeValidator CreateMinDateTime(
            string column, string value, DateTime min,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new DateTimeValidator(column, value, min, null, customMessageFormat, customRangeMessageFormat);
        }

        public static DateTimeValidator CreateMaxDateTime(
            string column, string value, DateTime max,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new DateTimeValidator(column, value, null, max, customMessageFormat, customRangeMessageFormat);
        }
    }
}