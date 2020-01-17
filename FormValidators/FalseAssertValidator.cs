using System;

namespace CloudyWing.FormValidators {
    public class FalseAssertValidator : IFormValidatable {
        private readonly string errorMessage = "";
        private readonly Func<bool> falsePredicate;

        public FalseAssertValidator(bool isFalse, string errorMessage) : this(() => isFalse, errorMessage) { }

        public FalseAssertValidator(Func<bool> falsePredicate, string errorMessage) {
            this.falsePredicate = falsePredicate;
            this.errorMessage = errorMessage;
        }

        public string ErrorMessage { get; private set; }

        public bool IsValid { get; private set; }

        public bool Validate() {
            IsValid = !falsePredicate();
            ErrorMessage = IsValid ? "" : errorMessage;
            return IsValid;
        }
    }
}