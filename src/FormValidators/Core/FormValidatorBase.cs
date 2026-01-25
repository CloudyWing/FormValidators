namespace CloudyWing.FormValidators.Core;

/// <summary>The form validator base abstract class.</summary>
/// <seealso cref="IFormValidator" />
public abstract class FormValidatorBase : IFormValidator {
    /// <summary>Initializes a new instance of the <see cref="FormValidatorBase" /> class.</summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    public FormValidatorBase(string column, string value) {
        Column = column;
        Value = value;
    }

    /// <summary>Gets or sets the column.</summary>
    /// <value>The column.</value>
    public string Column { get; }

    /// <summary>Gets or sets the value.</summary>
    /// <value>The value.</value>
    public string Value { get; }

    /// <inheritdoc />
    public string ErrorMessage { get; private set; }

    /// <inheritdoc />
    public bool IsValid { get; private set; }

    /// <summary>Gets the default error message.</summary>
    /// <value>The default error message.</value>
    protected abstract string DefaultErrorMessage { get; }

    /// <summary>Gets the custom error message.</summary>
    /// <value>The custom error message.</value>
    protected abstract string CustomErrorMessage { get; }

    /// <summary>Gets a value indicating whether this instance has custom error message.</summary>
    /// <value>
    ///   <c>true</c> if this instance has custom error message; otherwise, <c>false</c>.</value>
    protected abstract bool HasCustomErrorMessage { get; }

    /// <inheritdoc />
    public bool Validate() {
        IsValid = ValidateValue();
        ErrorMessage = IsValid ? "" : CreateErrorMessage();
        return IsValid;
    }

    /// <summary>Validates the value.</summary>
    /// <returns>The validation result.</returns>
    protected abstract bool ValidateValue();

    /// <summary>Creates the error message.</summary>
    /// <returns>The error message.</returns>
    protected virtual string CreateErrorMessage() {
        return HasCustomErrorMessage ? CustomErrorMessage : DefaultErrorMessage;
    }
}
