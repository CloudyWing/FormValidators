#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## NumberValidator Class

Validation constrains the number format of a value.

```csharp
public sealed class NumberValidator : CloudyWing.FormValidators.Core.ComparableTypeValidator<decimal>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; [CloudyWing.FormValidators.Core.ComparableTypeValidator&lt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>') &#129106; NumberValidator
### Constructors

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_)'></a>

## NumberValidator(string, string, Func<string,string,Nullable<decimal>,Nullable<decimal>,string>) Constructor

Initializes a new instance of the [NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator') class.

```csharp
public NumberValidator(string column, string value, System.Func<string,string,System.Nullable<decimal>,System.Nullable<decimal>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.
### Properties

<a name='CloudyWing.FormValidators.NumberValidator.CastErrorMessageAccessor'></a>

## NumberValidator.CastErrorMessageAccessor Property

Gets the cast error message accessor.

```csharp
protected override System.Func<string,string,string> CastErrorMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The cast error message accessor.