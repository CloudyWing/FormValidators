using System;

namespace CloudyWing.FormValidators.Core {
    /// <summary>The less than validator abstract class.</summary>
    /// <typeparam name="T">The value type.</typeparam>
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

        /// <summary>Gets or sets the column.</summary>
        /// <value>The column.</value>
        public string Column { get; set; }

        /// <summary>Gets or sets the value.</summary>
        /// <value>The value.</value>
        public string Value { get; set; }

        /// <summary>Gets or sets the comparison column.</summary>
        /// <value>The comparison column.</value>
        public string ComparisonColumn { get; set; }

        /// <summary>Gets or sets the comparison value.</summary>
        /// <value>The comparison value.</value>
        public string ComparisonValue { get; set; }

        /// <summary>Gets or sets a value indicating whether [allowed equals].</summary>
        /// <value>
        ///   <c>true</c> if [allowed equals]; otherwise, <c>false</c>.</value>
        public bool AllowedEquals { get; set; }

        /// <inheritdoc />
        public string ErrorMessage { get; private set; }

        /// <inheritdoc />
        public bool IsValid { get; private set; }

        /// <summary>Gets the default error message format.</summary>
        /// <value>The default error message format.</value>
        public virtual string DefaultErrorMessageFormat { get; } = "「{0}」必須要小於「{1}」。";

        /// <summary>Gets or sets the custom error message format.</summary>
        /// <value>The custom error message format.</value>
        public string CustomErrorMessageFormat { get; set; }

        /// <inheritdoc />
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

        /// <summary>Tries the parse.</summary>
        /// <param name="value">The value.</param>
        /// <param name="result">The result.</param>
        /// <returns>Parse value to type <c>T</c> result.</returns>
        protected abstract bool TryParse(string value, out T result);

        private string CreateErrorMessage() {
            return string.IsNullOrWhiteSpace(CustomErrorMessageFormat)
                ? string.Format(DefaultErrorMessageFormat, Column, ComparisonColumn)
                : string.Format(CustomErrorMessageFormat, Column, ComparisonColumn);
        }
    }
}
