namespace CloudyWing.FormValidators {

    public class FalseAssertValidator : IFormValidatable {

        private string errorMessageFormat = "";

        public FalseAssertValidator(bool isFalse, string errorMessageFormat) {
            IsValid = !isFalse;
            this.errorMessageFormat = errorMessageFormat;
        }

        public string ErrorMessage { get; private set; }

        public bool IsValid { get; private set; }

        public bool Validate() {
            ErrorMessage = IsValid ? "" : errorMessageFormat;
            return IsValid;
        }
    }
}
