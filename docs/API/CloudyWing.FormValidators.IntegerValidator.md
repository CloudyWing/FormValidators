#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## IntegerValidator Class

The integer validator.

```csharp
public sealed class IntegerValidator : CloudyWing.FormValidators.Core.ComparableTypeValidator<long>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; [CloudyWing.FormValidators.Core.ComparableTypeValidator&lt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>') &#129106; IntegerValidator
### Constructors

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,string)'></a>

## IntegerValidator(string, string, string) Constructor

Initializes a new instance of the [IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator') class.

```csharp
public IntegerValidator(string column, string value, string customMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,string,string)'></a>

## IntegerValidator(string, string, Nullable<long>, Nullable<long>, string, string) Constructor

Initializes a new instance of the [IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator') class.

```csharp
public IntegerValidator(string column, string value, System.Nullable<long> min=null, System.Nullable<long> max=null, string customMessageFormat=null, string customRangeMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,string,string).min'></a>

`min` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The minimum.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,string,string).max'></a>

`max` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The maximum.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,string,string).customRangeMessageFormat'></a>

`customRangeMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom range message format.
### Properties

<a name='CloudyWing.FormValidators.IntegerValidator.DefaultErrorMessageFormat'></a>

## IntegerValidator.DefaultErrorMessageFormat Property

Gets the default error message format.

```csharp
public override string DefaultErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message format.
### Methods

<a name='CloudyWing.FormValidators.IntegerValidator.CreateMaxValue(string,string,long,string,string)'></a>

## IntegerValidator.CreateMaxValue(string, string, long, string, string) Method

Creates the maximum value validator.

```csharp
public static CloudyWing.FormValidators.IntegerValidator CreateMaxValue(string column, string value, long max, string customMessageFormat=null, string customRangeMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.IntegerValidator.CreateMaxValue(string,string,long,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.IntegerValidator.CreateMaxValue(string,string,long,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.IntegerValidator.CreateMaxValue(string,string,long,string,string).max'></a>

`max` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The maximum.

<a name='CloudyWing.FormValidators.IntegerValidator.CreateMaxValue(string,string,long,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.IntegerValidator.CreateMaxValue(string,string,long,string,string).customRangeMessageFormat'></a>

`customRangeMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom range message format.

#### Returns
[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')  
The maximum value validator

<a name='CloudyWing.FormValidators.IntegerValidator.CreateMinValue(string,string,long,string,string)'></a>

## IntegerValidator.CreateMinValue(string, string, long, string, string) Method

Creates the minimum value validator.

```csharp
public static CloudyWing.FormValidators.IntegerValidator CreateMinValue(string column, string value, long min, string customMessageFormat=null, string customRangeMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.IntegerValidator.CreateMinValue(string,string,long,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.IntegerValidator.CreateMinValue(string,string,long,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.IntegerValidator.CreateMinValue(string,string,long,string,string).min'></a>

`min` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The minimum.

<a name='CloudyWing.FormValidators.IntegerValidator.CreateMinValue(string,string,long,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.IntegerValidator.CreateMinValue(string,string,long,string,string).customRangeMessageFormat'></a>

`customRangeMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom range message format.

#### Returns
[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')  
The minimum value validator