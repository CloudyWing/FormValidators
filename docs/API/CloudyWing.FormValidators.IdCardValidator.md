#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## IdCardValidator Class

The identity card validator.

```csharp
public sealed class IdCardValidator : CloudyWing.FormValidators.Core.FormValidatorBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; IdCardValidator
### Constructors

<a name='CloudyWing.FormValidators.IdCardValidator.IdCardValidator(string,string,CloudyWing.FormValidators.IdCardTypes,string)'></a>

## IdCardValidator(string, string, IdCardTypes, string) Constructor

Initializes a new instance of the [IdCardValidator](CloudyWing.FormValidators.IdCardValidator.md 'CloudyWing.FormValidators.IdCardValidator') class.

```csharp
public IdCardValidator(string column, string value, CloudyWing.FormValidators.IdCardTypes idCardType=CloudyWing.FormValidators.IdCardTypes.All, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.IdCardValidator.IdCardValidator(string,string,CloudyWing.FormValidators.IdCardTypes,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.IdCardValidator.IdCardValidator(string,string,CloudyWing.FormValidators.IdCardTypes,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.IdCardValidator.IdCardValidator(string,string,CloudyWing.FormValidators.IdCardTypes,string).idCardType'></a>

`idCardType` [IdCardTypes](CloudyWing.FormValidators.IdCardTypes.md 'CloudyWing.FormValidators.IdCardTypes')

Type of the identifier card.

<a name='CloudyWing.FormValidators.IdCardValidator.IdCardValidator(string,string,CloudyWing.FormValidators.IdCardTypes,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.
### Properties

<a name='CloudyWing.FormValidators.IdCardValidator.DefaultErrorMessageFormat'></a>

## IdCardValidator.DefaultErrorMessageFormat Property

Gets the default error message format.

```csharp
public override string DefaultErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message format.

<a name='CloudyWing.FormValidators.IdCardValidator.IdCardType'></a>

## IdCardValidator.IdCardType Property

Gets the type of the identifier card.

```csharp
public CloudyWing.FormValidators.IdCardTypes IdCardType { get; }
```

#### Property Value
[IdCardTypes](CloudyWing.FormValidators.IdCardTypes.md 'CloudyWing.FormValidators.IdCardTypes')  
The type of the identifier card.
### Methods

<a name='CloudyWing.FormValidators.IdCardValidator.ValidateValue()'></a>

## IdCardValidator.ValidateValue() Method

Validates the value.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.