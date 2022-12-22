using System;

namespace CloudyWing.FormValidators {
    public class TrueAssertValidator : IFormValidator {
        private readonly string errorMessage;
        private readonly Func<bool> truePredicate;

        public TrueAssertValidator(bool isTrue, string errorMessage) : this(() => isTrue, errorMessage) { }

        public TrueAssertValidator(Func<bool> truePredicate, string errorMessage) {
            this.truePredicate = truePredicate;
            this.errorMessage = errorMessage;
        }

        public string ErrorMessage { get; private set; }

        public bool IsValid { get; private set; }

        public bool Validate() {
            IsValid = truePredicate();
            ErrorMessage = IsValid ? "" : errorMessage;
            return IsValid;
        }
    }
}