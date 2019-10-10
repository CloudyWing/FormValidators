namespace CloudyWing.FormValidators {
    public class TrueAssertValidator : IFormValidatable {
        private readonly string errorMessage;

        public TrueAssertValidator(bool isTrue, string errorMessage) {
            IsValid = isTrue;
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