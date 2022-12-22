﻿using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>The value length validator.</summary>
    /// <seealso cref="FormValidatorBase" />
    public sealed class ValueLengthValidator : FormValidatorBase {
        private string realErrorMessage;

        /// <summary>Initializes a new instance of the <see cref="ValueLengthValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        public ValueLengthValidator(
            string column, string value,
            int min, int max,
            string customMessageFormat = null
        ) : base(column, value, customMessageFormat) {
            MinLength = min < 0 ? 0 : min;
            MaxLength = max < 0 ? 0 : max;
        }

        /// <summary>Initializes a new instance of the <see cref="ValueLengthValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        public ValueLengthValidator(
            string column, string value, int max,
            string customMessageFormat = null
        ) : this(column, value, 0, max, customMessageFormat) { }

        /// <summary>Gets the minimum length.</summary>
        /// <value>The minimum length.</value>
        public int MinLength { get; }

        /// <summary>Gets the maximum length.</summary>
        /// <value>The maximum length.</value>
        public int MaxLength { get; }

        /// <summary>Gets the default error message format.</summary>
        /// <value>The default error message format.</value>
        public override string DefaultErrorMessageFormat => "「{0}」長度必須介於「{1}」和「{2}」之間。";

        /// <summary>Gets the minimum length error message format.</summary>
        /// <value>The minimum length error message format.</value>
        public string MinLengthErrorMessageFormat => "「{0}」長度必須大於等於「{1}」。";

        /// <summary>Gets the maximum length error message format.</summary>
        /// <value>The maximum length error message format.</value>
        public string MaxLengthErrorMessageFormat => "「{0}」長度必須小於等於「{1}」。";

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        protected override string CreateErrorMessage() {
            return realErrorMessage;
        }

        /// <summary>Creates the minimum length validator.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The minimum length validator.</returns>
        public static ValueLengthValidator CreateMinLength(
            string column, string value, int min,
            string customMessageFormat = null
        ) {
            return new ValueLengthValidator(column, value, min, 0, customMessageFormat);
        }

        /// <summary>Creates the maximum length validator.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The maximum length validator.</returns>
        public static ValueLengthValidator CreateMaxLength(
            string column, string value, int max,
            string customMessageFormat = null
        ) {
            return new ValueLengthValidator(column, value, max, customMessageFormat);
        }
    }
}
