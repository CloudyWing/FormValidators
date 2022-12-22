#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## MobilePhoneValidator Class

The mobile phone validator.

```csharp
public sealed class MobilePhoneValidator : CloudyWing.FormValidators.RegexValidator
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; [RegexValidator](CloudyWing.FormValidators.RegexValidator.md 'CloudyWing.FormValidators.RegexValidator') &#129106; MobilePhoneValidator
### Constructors

<a name='CloudyWing.FormValidators.MobilePhoneValidator.MobilePhoneValidator(string,string,string)'></a>

## MobilePhoneValidator(string, string, string) Constructor

Initializes a new instance of the [MobilePhoneValidator](CloudyWing.FormValidators.MobilePhoneValidator.md 'CloudyWing.FormValidators.MobilePhoneValidator') class.

```csharp
public MobilePhoneValidator(string column, string value, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.MobilePhoneValidator.MobilePhoneValidator(string,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.MobilePhoneValidator.MobilePhoneValidator(string,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.MobilePhoneValidator.MobilePhoneValidator(string,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.
### Properties

<a name='CloudyWing.FormValidators.MobilePhoneValidator.DefaultErrorMessageFormat'></a>

## MobilePhoneValidator.DefaultErrorMessageFormat Property

Gets the default error message format.

```csharp
public override string DefaultErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message format.