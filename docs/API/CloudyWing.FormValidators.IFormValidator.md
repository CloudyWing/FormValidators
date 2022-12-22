#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## IFormValidator Interface

The form validator.

```csharp
public interface IFormValidator
```

Derived  
&#8627; [BulkValidator](CloudyWing.FormValidators.BulkValidator.md 'CloudyWing.FormValidators.BulkValidator')  
&#8627; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase')  
&#8627; [LessThanValidator&lt;T&gt;](CloudyWing.FormValidators.Core.LessThanValidator_T_.md 'CloudyWing.FormValidators.Core.LessThanValidator<T>')  
&#8627; [FalseAssertValidator](CloudyWing.FormValidators.FalseAssertValidator.md 'CloudyWing.FormValidators.FalseAssertValidator')  
&#8627; [TrueAssertValidator](CloudyWing.FormValidators.TrueAssertValidator.md 'CloudyWing.FormValidators.TrueAssertValidator')
### Properties

<a name='CloudyWing.FormValidators.IFormValidator.ErrorMessage'></a>

## IFormValidator.ErrorMessage Property

Gets the error message.

```csharp
string ErrorMessage { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.

<a name='CloudyWing.FormValidators.IFormValidator.IsValid'></a>

## IFormValidator.IsValid Property

Returns true if ... is valid.

```csharp
bool IsValid { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if this instance is valid; otherwise, `false`.
### Methods

<a name='CloudyWing.FormValidators.IFormValidator.Validate()'></a>

## IFormValidator.Validate() Method

Validates this instance.

```csharp
bool Validate();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.