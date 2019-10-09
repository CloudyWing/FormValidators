namespace CloudyWing.FormValidators {
    public sealed class IntegerValidator : FormValidatorBase {
        private string realErrorMessage;

        public IntegerValidator(
            string column, string value,
            int? min = null, int? max = null,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) : base(column, value, customMessageFormat) {
            MinValue = min;
            MaxValue = max;
            CustomRangeMessageFormat = customRangeMessageFormat;
        }

        public IntegerValidator(string column, string value, string customMessageFormat)
            : this(column, value, null, null, customMessageFormat) { }

        public int? MinValue { get; }

        public int? MaxValue { get; }

        public string CustomRangeMessageFormat { get; }

        public override string DefaultErrorMessageFormat => "「{0}」必須為整數。";

        public string MinValueErrorMessageFormat => "「{0}」必須大於等於「{1}」。";

        public string MaxValueErrorMessageFormat => "「{0}」必須小於等於「{1}」。";

        public string RangeErrorMessageFormat => "「{0}」必須介於「{1}」和「{2}」之間。";

        protected override bool ValidateValue() {
            InitErrorMessage();

            if (string.IsNullOrWhiteSpace(Value)) {
                return true;
            }

            if (int.TryParse(Value, out int value)) {
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

        private bool ValidateRange(int value) {
            if (value >= MinValue && value <= MaxValue) {
                return true;
            }

            realErrorMessage = string.IsNullOrWhiteSpace(CustomRangeMessageFormat)
                ? string.Format(RangeErrorMessageFormat, Column, MinValue, MaxValue)
                : string.Format(CustomRangeMessageFormat, Column, MinValue, MaxValue);

            return false;
        }

        private bool ValidateMinValue(int value) {
            if (value >= MinValue) {
                return true;
            }

            realErrorMessage = string.IsNullOrWhiteSpace(CustomRangeMessageFormat)
                ? string.Format(MinValueErrorMessageFormat, Column, MinValue)
                : string.Format(CustomRangeMessageFormat, Column, MinValue);

            return false;
        }

        private bool ValidateMaxValue(int value) {
            if (value <= MaxValue) {
                return true;
            }

            realErrorMessage = string.IsNullOrWhiteSpace(CustomRangeMessageFormat)
                ? string.Format(MaxValueErrorMessageFormat, Column, MaxValue)
                : string.Format(CustomRangeMessageFormat, Column, MaxValue);

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

        public static IntegerValidator CreateMinValue(
            string column, string value, int min,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new IntegerValidator(column, value, min, null, customMessageFormat, customRangeMessageFormat);
        }

        public static IntegerValidator CreateMaxValue(
            string column, string value, int max,
            string customMessageFormat = null,
            string customRangeMessageFormat = null
        ) {
            return new IntegerValidator(column, value, null, max, customMessageFormat, customRangeMessageFormat);
        }
    }
}