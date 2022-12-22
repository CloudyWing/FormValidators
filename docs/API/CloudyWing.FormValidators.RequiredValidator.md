#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## RequiredValidator Class

The required validator.

```csharp
public sealed class RequiredValidator : CloudyWing.FormValidators.Core.FormValidatorBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; RequiredValidator
### Constructors

<a name='CloudyWing.FormValidators.RequiredValidator.RequiredValidator(string,string,string)'></a>

## RequiredValidator(string, string, string) Constructor

Initializes a new instance of the [RequiredValidator](CloudyWing.FormValidators.RequiredValidator.md 'CloudyWing.FormValidators.RequiredValidator') class.

```csharp
public RequiredValidator(string column, string value, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.RequiredValidator.RequiredValidator(string,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.RequiredValidator.RequiredValidator(string,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.RequiredValidator.RequiredValidator(string,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.
### Properties

<a name='CloudyWing.FormValidators.RequiredValidator.DefaultErrorMessageFormat'></a>

## RequiredValidator.DefaultErrorMessageFormat Property

Gets the default error message format.

```csharp
public override string DefaultErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message format.
### Methods

<a name='CloudyWing.FormValidators.RequiredValidator.ValidateValue()'></a>

## RequiredValidator.ValidateValue() Method

Validates the value.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.