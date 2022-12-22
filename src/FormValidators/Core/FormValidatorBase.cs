namespace CloudyWing.FormValidators.Core {
    /// <summary>The form validator abstract class.</summary>
    /// <seealso cref="IFormValidator" />
    public abstract class FormValidatorBase : IFormValidator {
        /// <summary>Initializes a new instance of the <see cref="FormValidatorBase" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        public FormValidatorBase(string column, string value, string customMessageFormat) {
            Column = column;
            Value = value;
            CustomErrorMessageFormat = customMessageFormat;
        }

        /// <summary>Gets or sets the column.</summary>
        /// <value>The column.</value>
        public string Column { get; set; }

        /// <summary>Gets or sets the value.</summary>
        /// <value>The value.</value>
        public string Value { get; set; }

        /// <inheritdoc />
        public string ErrorMessage { get; private set; }

        /// <inheritdoc />
        public bool IsValid { get; private set; }

        /// <summary>Gets the default error message format.</summary>
        /// <value>The default error message format.</value>
        public abstract string DefaultErrorMessageFormat { get; }

        /// <summary>Gets or sets the custom error message format.</summary>
        /// <value>The custom error message format.</value>
        public string CustomErrorMessageFormat { get; set; }

        /// <inheritdoc />
        public bool Validate() {
            IsValid = ValidateValue();
            ErrorMessage = IsValid ? "" : CreateErrorMessage();
            return IsValid;
        }

        /// <summary>Validates the value.</summary>
        /// <returns>The validation result.</returns>
        protected abstract bool ValidateValue();

        /// <summary>Creates the error message.</summary>
        /// <returns>The error message.</returns>
        protected virtual string CreateErrorMessage() {
            return string.IsNullOrWhiteSpace(CustomErrorMessageFormat) ?
                string.Format(DefaultErrorMessageFormat, Column) : string.Format(CustomErrorMessageFormat, Column);
        }
    }
}
