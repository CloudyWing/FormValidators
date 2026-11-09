#if !NETCOREAPP3_0_OR_GREATER && !NETSTANDARD2_1_OR_GREATER
namespace System.Diagnostics.CodeAnalysis;

/// <summary>
/// Specifies that when a method returns <see cref="ReturnValue" />, the parameter will not be <see langword="null" /> even if the corresponding type allows it.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
internal sealed class NotNullWhenAttribute : Attribute {
    /// <summary>
    /// Initializes a new instance of the <see cref="NotNullWhenAttribute" /> class.
    /// </summary>
    /// <param name="returnValue">The return value condition.</param>
    public NotNullWhenAttribute(bool returnValue) {
        ReturnValue = returnValue;
    }

    /// <summary>
    /// Gets the return value condition.
    /// </summary>
    /// <value>The return value condition.</value>
    public bool ReturnValue { get; }
}
#endif
