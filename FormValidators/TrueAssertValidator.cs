namespace CloudyWing.FormValidators {

    public class TrueAssertValidator : IFormValidatable {

        private string errorMessageFormat = "";

        public TrueAssertValidator(bool isTrue, string errorMessageFormat) {
            IsValid = isTrue;
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
