namespace CloudyWing.FormValidators {
    public class FalseAssertValidator : IFormValidatable {
        private readonly string errorMessage = "";

        public FalseAssertValidator(bool isFalse, string errorMessage) {
            IsValid = !isFalse;
            this.errorMessage = errorMessage;
        }

        public string ErrorMessage { get; private set; }

        public bool IsValid { get; }

        public bool Validate() {
            ErrorMessage = IsValid ? "" : errorMessage;
            return IsValid;
        }
    }
}