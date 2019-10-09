using System;

namespace CloudyWing.FormValidators {
    public sealed class DateTimeValidator : FormValidatorBase {
        private string realErrorMessage;

        public DateTimeValidator(
            string column, string value,
            DateTime? min = null, DateTime? max = null,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) : base(column, value, customMessageFormat) {
            MinDateTime = min;
            MaxDateValue = max;
            CustomRangeMessageFormat = customRangeMessageFormat;
        }

        public DateTimeValidator(string column, string value, string customMessageFormat)
            : this(column, value, null, null, customMessageFormat) { }

        public DateTime? MinDateTime { get; }

        public DateTime? MaxDateValue { get; }

        public string CustomRangeMessageFormat { get; }

        public override string DefaultErrorMessageFormat => "「{0}」必須為正確日期格式。";

        public string MinValueErrorMessageFormat => "「{0}」必須大於等於「{1}」。";

        public string MaxValueErrorMessageFormat => "「{0}」必須小於等於「{1}」。";

        public string RangeErrorMessageFormat => "「{0}」必須介於「{1}」和「{2}」之間。";

        protected override bool ValidateValue() {
            InitErrorMessage();

            if (string.IsNullOrWhiteSpace(Value)) {
                return true;
            }

            if (DateTime.TryParse(Value, out DateTime value)) {
                if (MinDateTime.HasValue && MaxDateValue.HasValue) {
                    return ValidateRange(value);

                } else if (MinDateTime.HasValue) {
                    return ValidateMinValue(value);

                } else if (MaxDateValue.HasValue) {
                    return ValidateMaxValue(value);
                }

                return true;
            }

            CreateFormatErrorMessage();

            return false;
        }

        private bool ValidateRange(DateTime value) {
            if (value >= MinDateTime && value <= MaxDateValue) {
                return true;
            }

            realErrorMessage = string.IsNullOrWhiteSpace(CustomRangeMessageFormat)
                ? string.Format(RangeErrorMessageFormat, Column, MinDateTime, MaxDateValue)
                : string.Format(CustomRangeMessageFormat, Column, MinDateTime, MaxDateValue);

            return false;
        }

        private bool ValidateMinValue(DateTime value) {
            if (value >= MinDateTime) {
                return true;
            }

            realErrorMessage = string.IsNullOrWhiteSpace(CustomRangeMessageFormat)
                ? string.Format(MinValueErrorMessageFormat, Column, MinDateTime)
                : string.Format(CustomRangeMessageFormat, Column, MinDateTime);

            return false;
        }

        private bool ValidateMaxValue(DateTime value) {
            if (value <= MaxDateValue) {
                return true;
            }

            realErrorMessage = string.IsNullOrWhiteSpace(CustomRangeMessageFormat)
                ? string.Format(MaxValueErrorMessageFormat, Column, MaxDateValue)
                : string.Format(CustomRangeMessageFormat, Column, MaxDateValue);

            return false;
        }

        private void InitErrorMessage() {
            realErrorMessage = "";
        }

        private void CreateFormatErrorMessage() {
            realErrorMessage = string.IsNullOrWhiteSpace(CustomErrorMessageFormat)
                ? string.Format(DefaultErrorMessageFormat, Column)
                : string.Format(CustomErrorMessageFormat, Column);
        }

        protected override string CreateErrorMessage() {
            return realErrorMessage;
        }

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