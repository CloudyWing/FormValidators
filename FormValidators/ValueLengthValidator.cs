namespace CloudyWing.FormValidators {
    using Core;

    public sealed class ValueLengthValidator : FormValidatorBase {
        private string realErrorMessage;

        public ValueLengthValidator(
            string column, string value,
            int min, int max,
            string customMessageFormat = null
        ) : base(column, value, customMessageFormat) {
            MinLength = min < 0 ? 0 : min;
            MaxLength = max < 0 ? 0 : max;
        }

        public ValueLengthValidator(
            string column, string value, int max,
            string customMessageFormat = null
        ) : this(column, value, 0, max, customMessageFormat) { }

        public int MinLength { get; }

        public int MaxLength { get; }

        public override string DefaultErrorMessageFormat => "「{0}」長度必須介於「{1}」和「{2}」之間。";

        public string MinLengthErrorMessageFormat => "「{0}」長度必須大於等於「{1}」。";

        public string MaxLengthErrorMessageFormat => "「{0}」長度必須小於等於「{1}」。";

        protected override bool ValidateValue() {
            InitErrorMessage();

            if (string.IsNullOrWhiteSpace(Value)) {
                return true;
            }

            if (MinLength > 0 && MaxLength > 0) {
                return ValidateRange();

            } else if (MinLength > 0) {
                return ValidateMinLength();

            } else if (MaxLength > 0) {
                return ValidateMaxLength();
            } else {
                return true;
            }
        }

        private bool ValidateRange() {
            if (Value.Length >= MinLength && Value.Length <= MaxLength) {
                return true;
            }

            realErrorMessage = string.IsNullOrWhiteSpace(CustomErrorMessageFormat)
                ? string.Format(DefaultErrorMessageFormat, Column, MinLength, MaxLength)
                : string.Format(CustomErrorMessageFormat, Column, MinLength, MaxLength);

            return false;
        }

        private bool ValidateMinLength() {
            if (Value.Length >= MinLength) {
                return true;
            }

            realErrorMessage = string.IsNullOrWhiteSpace(CustomErrorMessageFormat)
                ? string.Format(MinLengthErrorMessageFormat, Column, MinLength)
                : string.Format(CustomErrorMessageFormat, Column, MinLength);

            return false;
        }

        private bool ValidateMaxLength() {
            if (Value.Length <= MaxLength) {
                return true;
            }

            realErrorMessage = string.IsNullOrWhiteSpace(CustomErrorMessageFormat)
                ? string.Format(MaxLengthErrorMessageFormat, Column, MaxLength)
                : string.Format(CustomErrorMessageFormat, Column, MaxLength);

            return false;
        }

        private void InitErrorMessage() {
            realErrorMessage = "";
        }

        private void CreateFormatErrorMessage() {
            realErrorMessage = string.IsNullOrWhiteSpace(base.CustomErrorMessageFormat)
                ? string.Format(DefaultErrorMessageFormat, Column)
                : string.Format(base.CustomErrorMessageFormat, Column);
        }

        protected override string CreateErrorMessage() {
            return realErrorMessage;
        }

        public static ValueLengthValidator CreateMinLength(
            string column, string value, int min,
            string customMessageFormat = null
        ) {
            return new ValueLengthValidator(column, value, min, 0, customMessageFormat);
        }

        public static ValueLengthValidator CreateMaxLength(
            string column, string value, int max,
            string customMessageFormat = null
        ) {
            return new ValueLengthValidator(column, value, max, customMessageFormat);
        }
    }
}
