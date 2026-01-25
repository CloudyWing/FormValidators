using System;

namespace CloudyWing.FormValidators;

/// <summary>The false assert validator.</summary>
public class FalseAssertValidator : IFormValidator {
    private readonly string errorMessage = "";
    private readonly Func<bool> falsePredicate;

    /// <summary>Initializes a new instance of the <see cref="FalseAssertValidator" /> class.</summary>
    /// <param name="isFalse">if set to <c>true</c> [is false].</param>
    /// <param name="errorMessage">The error message.</param>
    public FalseAssertValidator(bool isFalse, string errorMessage) : this(() => isFalse, errorMessage) { }

    /// <summary>Initializes a new instance of the <see cref="FalseAssertValidator" /> class.</summary>
    /// <param name="falsePredicate">The false predicate.</param>
    /// <param name="errorMessage">The error message.</param>
    public FalseAssertValidator(Func<bool> falsePredicate, string errorMessage) {
        this.falsePredicate = falsePredicate;
        this.errorMessage = errorMessage;
    }

    /// <inheritdoc/>
    public string ErrorMessage { get; private set; }

    /// <inheritdoc/>
    public bool IsValid { get; private set; }

    /// <inheritdoc/>
    public bool Validate() {
        IsValid = !falsePredicate();
        ErrorMessage = IsValid ? "" : errorMessage;
        return IsValid;
    }
}
