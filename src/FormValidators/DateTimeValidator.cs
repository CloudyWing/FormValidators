using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>
    ///  Th date time validator.
    /// </summary>
    public sealed class DateTimeValidator : ComparableTypeValidator<DateTime> {
        /// <summary>sInitializes a new instance of the <see cref="DateTimeValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <param name="customRangeMessageFormat">The custom range message format.</param>
        public DateTimeValidator(
            string column, string value,
            DateTime? min = null, DateTime? max = null,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) : base(column, value, min, max, customMessageFormat, customRangeMessageFormat) { }

        /// <summary>Initializes a new instance of the <see cref="DateTimeValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        public DateTimeValidator(string column, string value, string customMessageFormat)
            : this(column, value, null, null, customMessageFormat) { }

        /// <inheritdoc/>
        public override string DefaultErrorMessageFormat => "「{0}」必須為正確日期格式。";

        /// <inheritdoc/>
        protected override bool TryParse(string value, out DateTime result) {
            return DateTime.TryParse(value, out result);
        }

        /// <summary>Creates the minimum date time validator.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <param name="customRangeMessageFormat">The custom range message format.</param>
        /// <returns>The minimum date time validator.</returns>
        public static DateTimeValidator CreateMinDateTime(
            string column, string value, DateTime min,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new DateTimeValidator(column, value, min, null, customMessageFormat, customRangeMessageFormat);
        }

        /// <summary>Creates the maximum date time.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <param name="customRangeMessageFormat">The custom range message format.</param>
        /// <returns>The maximum date time validator.</returns>
        public static DateTimeValidator CreateMaxDateTime(
            string column, string value, DateTime max,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new DateTimeValidator(column, value, null, max, customMessageFormat, customRangeMessageFormat);
        }
    }
}
