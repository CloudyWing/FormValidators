namespace CloudyWing.FormValidators {
    public abstract class FormValidatorBase : IFormValidatable {
        public FormValidatorBase(string column, string value, string customMessageFormat) {
            Column = column;
            Value = value;
            CustomErrorMessageFormat = customMessageFormat;
        }

        public string Column { get; set; }

        public string Value { get; set; }

        public string ErrorMessage { get; private set; }

        public bool IsValid { get; private set; }

        public abstract string DefaultErrorMessageFormat { get; }

        public string CustomErrorMessageFormat { get; set; }

        public bool Validate() {
            IsValid = ValidateValue();
            ErrorMessage = IsValid ? "" : CreateErrorMessage();
            return IsValid;
        }

        protected abstract bool ValidateValue();

        protected virtual string CreateErrorMessage() {
            return string.IsNullOrWhiteSpace(CustomErrorMessageFormat) ?
                string.Format(DefaultErrorMessageFormat, Column) : string.Format(CustomErrorMessageFormat, Column);
        }
    }
}