namespace CloudyWing.FormValidators {
    public interface IFormValidator {
        string ErrorMessage { get; }

        bool IsValid { get; }

        bool Validate();
    }
}