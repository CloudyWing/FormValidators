namespace CloudyWing.FormValidators;

/// <summary>The form validator.</summary>
public interface IFormValidator {
    /// <summary>Gets the error message.</summary>
    /// <value>The error message.</value>
    string ErrorMessage { get; }

    /// <summary>Returns true if ... is valid.</summary>
    /// <value>
    ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
    bool IsValid { get; }

    /// <summary>Validates this instance.</summary>
    /// <returns>The validation result.</returns>
    bool Validate();
}
