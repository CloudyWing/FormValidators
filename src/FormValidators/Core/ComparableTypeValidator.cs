using System;

namespace CloudyWing.FormValidators.Core {
    /// <summary>
    /// The comparable type validator abstract class.
    /// </summary>
    /// <typeparam name="T">The compare value type.</typeparam>
    /// <seealso cref="FormValidatorBase" />
    public abstract class ComparableTypeValidator<T> : FormValidatorBase
        where T : struct, IConvertible, IComparable<T>, IEquatable<T> {
        private string realErrorMessage;

        /// <summary>Initializes a new instance of the <see cref="ComparableTypeValidator{T}" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <param name="customRangeMessageFormat">The custom range message format.</param>
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

        /// <summary>Gets the minimum value.</summary>
        /// <value>The minimum value.</value>
        public T? MinValue { get; }

        /// <summary>Gets the maximum value.</summary>
        /// <value>The maximum value.</value>
        public T? MaxValue { get; }

        /// <summary>Gets the custom range message format.</summary>
        /// <value>The custom range message format.</value>
        public string CustomRangeMessageFormat { get; }

        /// <summary>Gets the minimum value error message format.</summary>
        /// <value>The minimum value error message format.</value>
        public string MinValueErrorMessageFormat => "「{0}」必須大於等於「{1}」。";

        /// <summary>Gets the maximum value error message format.</summary>
        /// <value>The maximum value error message format.</value>
        public string MaxValueErrorMessageFormat => "「{0}」必須小於等於「{1}」。";

        /// <summary>Gets the range error message format.</summary>
        /// <value>The range error message format.</value>
        public string RangeErrorMessageFormat => "「{0}」必須介於「{1}」和「{2}」之間。";

        /// <inheritdoc />
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

        /// <summary>Tries the parse.</summary>
        /// <param name="value">The value.</param>
        /// <param name="result">The result.</param>
        /// <returns>Parse value to type <c>T</c> result.</returns>
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

        /// <inheritdoc />
        protected override string CreateErrorMessage() {
            return realErrorMessage;
        }
    }
}
