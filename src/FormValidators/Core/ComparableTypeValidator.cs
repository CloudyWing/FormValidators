using System;

namespace CloudyWing.FormValidators.Core {
    public abstract class ComparableTypeValidator<T> : FormValidatorBase
        where T : struct, IConvertible, IComparable<T>, IEquatable<T> {
        private string realErrorMessage;

        protected ComparableTypeValidator(
            string column, string value,
            T? min = null, T? max = null,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) : base(column, value, customMessageFormat) {
            MinValue = min;
            MaxValue = max;
            CustomRangeMessageFormat = customRangeMessageFormat;
        }

        public T? MinValue { get; }

        public T? MaxValue { get; }

        public string CustomRangeMessageFormat { get; }

        public string MinValueErrorMessageFormat => "「{0}」必須大於等於「{1}」。";

        public string MaxValueErrorMessageFormat => "「{0}」必須小於等於「{1}」。";

        public string RangeErrorMessageFormat => "「{0}」必須介於「{1}」和「{2}」之間。";

        protected override bool ValidateValue() {
            InitErrorMessage();

            if (string.IsNullOrWhiteSpace(Value)) {
                return true;
            }

            if (TryParse(Value, out T value)) {
                if (MinValue.HasValue && MaxValue.HasValue) {
                    return ValidateRange(value);

                } else if (MinValue.HasValue) {
                    return ValidateMinValue(value);

                } else if (MaxValue.HasValue) {
                    return ValidateMaxValue(value);
                }

                return true;
            }

            CreateFormatErrorMessage();

            return false;
        }

        private void InitErrorMessage() {
            realErrorMessage = "";
        }

        protected abstract bool TryParse(string value, out T result);

        private bool ValidateRange(T value) {
            if (value.CompareTo(MinValue.Value) >= 0 && value.CompareTo(MaxValue.Value) <= 0) {
                return true;
            }

            realErrorMessage = string.IsNullOrWhiteSpace(CustomRangeMessageFormat)
                ? string.Format(RangeErrorMessageFormat, Column, MinValue, MaxValue)
                : string.Format(CustomRangeMessageFormat, Column, MinValue, MaxValue);

            return false;
        }

        private bool ValidateMinValue(T value) {
            if (value.CompareTo(MinValue.Value) >= 0) {
                return true;
            }

            realErrorMessage = string.IsNullOrWhiteSpace(CustomRangeMessageFormat)
                ? string.Format(MinValueErrorMessageFormat, Column, MinValue)
                : string.Format(CustomRangeMessageFormat, Column, MinValue);

            return false;
        }

        private bool ValidateMaxValue(T value) {
            if (value.CompareTo(MaxValue.Value) <= 0) {
                return true;
            }

            realErrorMessage = string.IsNullOrWhiteSpace(CustomRangeMessageFormat)
                ? string.Format(MaxValueErrorMessageFormat, Column, MaxValue)
                : string.Format(CustomRangeMessageFormat, Column, MaxValue);

            return false;
        }

        private void CreateFormatErrorMessage() {
            realErrorMessage = string.IsNullOrWhiteSpace(CustomErrorMessageFormat)
                ? string.Format(DefaultErrorMessageFormat, Column)
                : string.Format(CustomErrorMessageFormat, Column);
        }

        protected override string CreateErrorMessage() {
            return realErrorMessage;
        }
    }
}
