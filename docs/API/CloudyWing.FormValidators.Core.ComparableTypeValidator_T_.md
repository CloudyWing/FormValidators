#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators.Core](CloudyWing.FormValidators.Core.md 'CloudyWing.FormValidators.Core')

## ComparableTypeValidator<T> Class

The comparable type validator abstract class.

```csharp
public abstract class ComparableTypeValidator<T> : CloudyWing.FormValidators.Core.FormValidatorBase
    where T : struct, System.IConvertible, System.IComparable<T>, System.IEquatable<T>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T'></a>

`T`

The compare value type.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; ComparableTypeValidator<T>

Derived  
&#8627; [DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')  
&#8627; [IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')  
&#8627; [NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator')

### See Also
- [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase')
### Constructors

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ComparableTypeValidator(string,string,System.Nullable_T_,System.Nullable_T_,string,string)'></a>

## ComparableTypeValidator(string, string, Nullable<T>, Nullable<T>, string, string) Constructor

Initializes a new instance of the [ComparableTypeValidator&lt;T&gt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>') class.

```csharp
protected ComparableTypeValidator(string column, string value, System.Nullable<T> min=null, System.Nullable<T> max=null, string customMessageFormat=null, string customRangeMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ComparableTypeValidator(string,string,System.Nullable_T_,System.Nullable_T_,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ComparableTypeValidator(string,string,System.Nullable_T_,System.Nullable_T_,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ComparableTypeValidator(string,string,System.Nullable_T_,System.Nullable_T_,string,string).min'></a>

`min` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md#CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The minimum.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ComparableTypeValidator(string,string,System.Nullable_T_,System.Nullable_T_,string,string).max'></a>

`max` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md#CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The maximum.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ComparableTypeValidator(string,string,System.Nullable_T_,System.Nullable_T_,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ComparableTypeValidator(string,string,System.Nullable_T_,System.Nullable_T_,string,string).customRangeMessageFormat'></a>

`customRangeMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom range message format.
### Properties

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.CustomRangeMessageFormat'></a>

## ComparableTypeValidator<T>.CustomRangeMessageFormat Property

Gets the custom range message format.

```csharp
public string CustomRangeMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The custom range message format.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.MaxValue'></a>

## ComparableTypeValidator<T>.MaxValue Property

Gets the maximum value.

```csharp
public System.Nullable<T> MaxValue { get; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md#CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The maximum value.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.MaxValueErrorMessageFormat'></a>

## ComparableTypeValidator<T>.MaxValueErrorMessageFormat Property

Gets the maximum value error message format.

```csharp
public string MaxValueErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The maximum value error message format.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.MinValue'></a>

## ComparableTypeValidator<T>.MinValue Property

Gets the minimum value.

```csharp
public System.Nullable<T> MinValue { get; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md#CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The minimum value.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.MinValueErrorMessageFormat'></a>

## ComparableTypeValidator<T>.MinValueErrorMessageFormat Property

Gets the minimum value error message format.

```csharp
public string MinValueErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The minimum value error message format.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.RangeErrorMessageFormat'></a>

## ComparableTypeValidator<T>.RangeErrorMessageFormat Property

Gets the range error message format.

```csharp
public string RangeErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The range error message format.
### Methods

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.CreateErrorMessage()'></a>

## ComparableTypeValidator<T>.CreateErrorMessage() Method

Creates the error message.

```csharp
protected override string CreateErrorMessage();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.TryParse(string,T)'></a>

## ComparableTypeValidator<T>.TryParse(string, T) Method

Tries the parse.

```csharp
protected abstract bool TryParse(string value, out T result);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.TryParse(string,T).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.TryParse(string,T).result'></a>

`result` [T](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md#CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>.T')

The result.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Parse value to type `T` result.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ValidateValue()'></a>

## ComparableTypeValidator<T>.ValidateValue() Method

Validates the value.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.