using System;

namespace CloudyWing.FormValidators.Core {
    public abstract class LessThanValidator<T> : IFormValidator
        where T : struct, IConvertible, IComparable<T>, IEquatable<T> {
        /// <summary>
        /// Initializes a new instance of the <see cref="LessThanValidator{T}"/> class.
        /// </summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="comparisonColumn">The comparison column.</param>
        /// <param name="comparisonValue">The comparison value.</param>
        /// <param name="allowedEquals">if set to <c>true</c> [allowed equals].</param>
        /// <param name="customMessageFormat">The custom message format. Format argument: {0}:column {1}:comparisonColumn</param>
        /// <exception cref="ArgumentNullException">
        /// column
        /// or
        /// value
        /// or
        /// comparisonColumn
        /// or
        /// comparisonValue
        /// </exception>
        protected LessThanValidator(
            string column, string value, string comparisonColumn, string comparisonValue,
            bool allowedEquals = true, string customMessageFormat = null
        ) {
            Column = column ?? throw new ArgumentNullException(nameof(column));
            Value = value ?? throw new ArgumentNullException(nameof(value));
            ComparisonColumn = comparisonColumn ?? throw new ArgumentNullException(nameof(comparisonColumn));
            ComparisonValue = comparisonValue ?? throw new ArgumentNullException(nameof(comparisonValue));
            AllowedEquals = allowedEquals;
            CustomErrorMessageFormat = customMessageFormat;
        }

        public string Column { get; set; }

        public string Value { get; set; }

        public string ComparisonColumn { get; set; }

        public string ComparisonValue { get; set; }

        public bool AllowedEquals { get; set; }

        public string ErrorMessage { get; private set; }

        public bool IsValid { get; private set; }

        public virtual string DefaultErrorMessageFormat { get; } = "「{0}」必須要小於「{1}」。";

        public string CustomErrorMessageFormat { get; set; }

        public bool Validate() {
            // 格式不正確就不驗證
            if (!TryParse(Value, out T _value)
                || !TryParse(ComparisonValue, out T _comparisonValue)
            ) {
                IsValid = true;
            } else {
                IsValid = _value.CompareTo(_comparisonValue) < 0
                    || (AllowedEquals && _value.Equals(_comparisonValue));
            }

            ErrorMessage = IsValid ? "" : CreateErrorMessage();
            return IsValid;
        }

        protected abstract bool TryParse(string value, out T result);

        private string CreateErrorMessage() {
            return string.IsNullOrWhiteSpace(CustomErrorMessageFormat)
                ? string.Format(DefaultErrorMessageFormat, Column, ComparisonColumn)
                : string.Format(CustomErrorMessageFormat, Column, ComparisonColumn);
        }
    }
}
