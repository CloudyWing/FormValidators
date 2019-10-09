namespace CloudyWing.FormValidators {
    public interface IFormValidatable {
        string ErrorMessage { get; }

        bool IsValid { get; }

        bool Validate();
    }
}