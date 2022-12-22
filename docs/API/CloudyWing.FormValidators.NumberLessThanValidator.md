#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## NumberLessThanValidator Class

The number less than validator.

```csharp
public sealed class NumberLessThanValidator : CloudyWing.FormValidators.Core.LessThanValidator<decimal>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.FormValidators.Core.LessThanValidator&lt;](CloudyWing.FormValidators.Core.LessThanValidator_T_.md 'CloudyWing.FormValidators.Core.LessThanValidator<T>')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](CloudyWing.FormValidators.Core.LessThanValidator_T_.md 'CloudyWing.FormValidators.Core.LessThanValidator<T>') &#129106; NumberLessThanValidator
### Constructors

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,string)'></a>

## NumberLessThanValidator(string, string, string, string, bool, string) Constructor

Initializes a new instance of the [NumberLessThanValidator](CloudyWing.FormValidators.NumberLessThanValidator.md 'CloudyWing.FormValidators.NumberLessThanValidator') class.

```csharp
public NumberLessThanValidator(string column, string value, string comparisonColumn, string comparisonValue, bool allowedEquals=true, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,string).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,string).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,string).allowedEquals'></a>

`allowedEquals` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed equals].

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format. Format argument: {0}:column {1}:comparisonColumn