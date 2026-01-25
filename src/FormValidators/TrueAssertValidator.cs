using System;

namespace CloudyWing.FormValidators;

/// <summary>The true assert validator.</summary>
public class TrueAssertValidator : IFormValidator {
    private readonly string errorMessage;
    private readonly Func<bool> truePredicate;

    /// <summary>Initializes a new instance of the <see cref="TrueAssertValidator" /> class.</summary>
    /// <param name="isTrue">if set to <c>true</c> [is true].</param>
    /// <param name="errorMessage">The error message.</param>
    public TrueAssertValidator(bool isTrue, string errorMessage) : this(() => isTrue, errorMessage) { }

    /// <summary>Initializes a new instance of the <see cref="TrueAssertValidator" /> class.</summary>
    /// <param name="truePredicate">The true predicate.</param>
    /// <param name="errorMessage">The error message.</param>
    public TrueAssertValidator(Func<bool> truePredicate, string errorMessage) {
        this.truePredicate = truePredicate;
        this.errorMessage = errorMessage;
    }

    /// <inheritdoc/>
    public string ErrorMessage { get; private set; }

    /// <inheritdoc/>
    public bool IsValid { get; private set; }

    /// <inheritdoc/>
    public bool Validate() {
        IsValid = truePredicate();
        ErrorMessage = IsValid ? "" : errorMessage;
        return IsValid;
    }
}
