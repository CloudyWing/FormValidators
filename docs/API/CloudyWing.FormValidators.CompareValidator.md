#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## CompareValidator Class

The compare validator.

```csharp
public class CompareValidator : CloudyWing.FormValidators.Core.FormValidatorBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; CompareValidator

### See Also
- [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase')
### Constructors

<a name='CloudyWing.FormValidators.CompareValidator.CompareValidator(string,string,string,string,string)'></a>

## CompareValidator(string, string, string, string, string) Constructor

Initializes a new instance of the [CompareValidator](CloudyWing.FormValidators.CompareValidator.md 'CloudyWing.FormValidators.CompareValidator') class.

```csharp
public CompareValidator(string column, string value, string comparisonColumn, string comparisonValue, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.CompareValidator.CompareValidator(string,string,string,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.CompareValidator.CompareValidator(string,string,string,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.CompareValidator.CompareValidator(string,string,string,string,string).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.CompareValidator.CompareValidator(string,string,string,string,string).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.CompareValidator.CompareValidator(string,string,string,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.
### Properties

<a name='CloudyWing.FormValidators.CompareValidator.ComparisonColumn'></a>

## CompareValidator.ComparisonColumn Property

Gets the comparison column.

```csharp
public string ComparisonColumn { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The comparison column.

<a name='CloudyWing.FormValidators.CompareValidator.ComparisonValue'></a>

## CompareValidator.ComparisonValue Property

Gets the comparison value.

```csharp
public string ComparisonValue { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The comparison value.

<a name='CloudyWing.FormValidators.CompareValidator.DefaultErrorMessageFormat'></a>

## CompareValidator.DefaultErrorMessageFormat Property

Gets the default error message format.

```csharp
public override string DefaultErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message format.
### Methods

<a name='CloudyWing.FormValidators.CompareValidator.CreateErrorMessage()'></a>

## CompareValidator.CreateErrorMessage() Method

Creates the error message.

```csharp
protected override string CreateErrorMessage();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.

<a name='CloudyWing.FormValidators.CompareValidator.ValidateValue()'></a>

## CompareValidator.ValidateValue() Method

Validates the value.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.