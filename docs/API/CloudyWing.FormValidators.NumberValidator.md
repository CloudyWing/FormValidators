#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## NumberValidator Class

The number validator.

```csharp
public sealed class NumberValidator : CloudyWing.FormValidators.Core.ComparableTypeValidator<decimal>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; [CloudyWing.FormValidators.Core.ComparableTypeValidator&lt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>') &#129106; NumberValidator
### Constructors

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,string)'></a>

## NumberValidator(string, string, string) Constructor

Initializes a new instance of the [NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator') class.

```csharp
public NumberValidator(string column, string value, string customMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,string,string)'></a>

## NumberValidator(string, string, Nullable<decimal>, Nullable<decimal>, string, string) Constructor

Initializes a new instance of the [NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator') class.

```csharp
public NumberValidator(string column, string value, System.Nullable<decimal> min=null, System.Nullable<decimal> max=null, string customMessageFormat=null, string customRangeMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,string,string).min'></a>

`min` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The minimum.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,string,string).max'></a>

`max` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The maximum.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,string,string).customRangeMessageFormat'></a>

`customRangeMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom range message format.
### Properties

<a name='CloudyWing.FormValidators.NumberValidator.DefaultErrorMessageFormat'></a>

## NumberValidator.DefaultErrorMessageFormat Property

Gets the default error message format.

```csharp
public override string DefaultErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message format.
### Methods

<a name='CloudyWing.FormValidators.NumberValidator.CreateMaxValue(string,string,decimal,string,string)'></a>

## NumberValidator.CreateMaxValue(string, string, decimal, string, string) Method

Creates the maximum value validator.

```csharp
public static CloudyWing.FormValidators.NumberValidator CreateMaxValue(string column, string value, decimal max, string customMessageFormat=null, string customRangeMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.NumberValidator.CreateMaxValue(string,string,decimal,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.NumberValidator.CreateMaxValue(string,string,decimal,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.NumberValidator.CreateMaxValue(string,string,decimal,string,string).max'></a>

`max` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The maximum.

<a name='CloudyWing.FormValidators.NumberValidator.CreateMaxValue(string,string,decimal,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.NumberValidator.CreateMaxValue(string,string,decimal,string,string).customRangeMessageFormat'></a>

`customRangeMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom range message format.

#### Returns
[NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator')  
The maximum value validator.

<a name='CloudyWing.FormValidators.NumberValidator.CreateMinValue(string,string,decimal,string,string)'></a>

## NumberValidator.CreateMinValue(string, string, decimal, string, string) Method

Creates the minimum value validator.

```csharp
public static CloudyWing.FormValidators.NumberValidator CreateMinValue(string column, string value, decimal min, string customMessageFormat=null, string customRangeMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.NumberValidator.CreateMinValue(string,string,decimal,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.NumberValidator.CreateMinValue(string,string,decimal,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.NumberValidator.CreateMinValue(string,string,decimal,string,string).min'></a>

`min` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The minimum.

<a name='CloudyWing.FormValidators.NumberValidator.CreateMinValue(string,string,decimal,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.NumberValidator.CreateMinValue(string,string,decimal,string,string).customRangeMessageFormat'></a>

`customRangeMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom range message format.

#### Returns
[NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator')  
The minimum value validator.