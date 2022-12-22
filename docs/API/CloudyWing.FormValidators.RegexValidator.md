#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## RegexValidator Class

The regex validator.

```csharp
public class RegexValidator : CloudyWing.FormValidators.Core.FormValidatorBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; RegexValidator

Derived  
&#8627; [EmailValidator](CloudyWing.FormValidators.EmailValidator.md 'CloudyWing.FormValidators.EmailValidator')  
&#8627; [MobilePhoneValidator](CloudyWing.FormValidators.MobilePhoneValidator.md 'CloudyWing.FormValidators.MobilePhoneValidator')
### Constructors

<a name='CloudyWing.FormValidators.RegexValidator.RegexValidator(string,string,string,string)'></a>

## RegexValidator(string, string, string, string) Constructor

Initializes a new instance of the [RegexValidator](CloudyWing.FormValidators.RegexValidator.md 'CloudyWing.FormValidators.RegexValidator') class.

```csharp
public RegexValidator(string column, string value, string pattern, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.RegexValidator.RegexValidator(string,string,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.RegexValidator.RegexValidator(string,string,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.RegexValidator.RegexValidator(string,string,string,string).pattern'></a>

`pattern` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The pattern.

<a name='CloudyWing.FormValidators.RegexValidator.RegexValidator(string,string,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.
### Properties

<a name='CloudyWing.FormValidators.RegexValidator.DefaultErrorMessageFormat'></a>

## RegexValidator.DefaultErrorMessageFormat Property

Gets the default error message format.

```csharp
public override string DefaultErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message format.

<a name='CloudyWing.FormValidators.RegexValidator.Pattern'></a>

## RegexValidator.Pattern Property

Gets the pattern.

```csharp
public string Pattern { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The pattern.
### Methods

<a name='CloudyWing.FormValidators.RegexValidator.ValidateValue()'></a>

## RegexValidator.ValidateValue() Method

Validates the value.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.