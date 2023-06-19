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

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ComparableTypeValidator(string,string,System.Nullable_T_,System.Nullable_T_,System.Func_string,string,System.Nullable_T_,System.Nullable_T_,string_)'></a>

## ComparableTypeValidator(string, string, Nullable<T>, Nullable<T>, Func<string,string,Nullable<T>,Nullable<T>,string>) Constructor

Initializes a new instance of the [ComparableTypeValidator&lt;T&gt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>') class.

```csharp
protected ComparableTypeValidator(string column, string value, System.Nullable<T> min, System.Nullable<T> max, System.Func<string,string,System.Nullable<T>,System.Nullable<T>,string> customErrorMessageAccessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ComparableTypeValidator(string,string,System.Nullable_T_,System.Nullable_T_,System.Func_string,string,System.Nullable_T_,System.Nullable_T_,string_).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ComparableTypeValidator(string,string,System.Nullable_T_,System.Nullable_T_,System.Func_string,string,System.Nullable_T_,System.Nullable_T_,string_).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ComparableTypeValidator(string,string,System.Nullable_T_,System.Nullable_T_,System.Func_string,string,System.Nullable_T_,System.Nullable_T_,string_).min'></a>

`min` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md#CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The minimum.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ComparableTypeValidator(string,string,System.Nullable_T_,System.Nullable_T_,System.Func_string,string,System.Nullable_T_,System.Nullable_T_,string_).max'></a>

`max` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md#CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The maximum.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.ComparableTypeValidator(string,string,System.Nullable_T_,System.Nullable_T_,System.Func_string,string,System.Nullable_T_,System.Nullable_T_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md#CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md#CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.
### Properties

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.CastErrorMessageAccessor'></a>

## ComparableTypeValidator<T>.CastErrorMessageAccessor Property

Gets the cast error message accessor.

```csharp
protected abstract System.Func<string,string,string> CastErrorMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The cast error message accessor.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.CustomErrorMessage'></a>

## ComparableTypeValidator<T>.CustomErrorMessage Property

Gets the custom error message.

```csharp
protected override string CustomErrorMessage { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The custom error message.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.CustomErrorMessageAccessor'></a>

## ComparableTypeValidator<T>.CustomErrorMessageAccessor Property

Gets the custom range message format.

```csharp
public System.Func<string,string,System.Nullable<T>,System.Nullable<T>,string> CustomErrorMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md#CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md#CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')  
The custom range message format.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.DefaultErrorMessage'></a>

## ComparableTypeValidator<T>.DefaultErrorMessage Property

Gets the default error message.

```csharp
protected override string DefaultErrorMessage { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.HasCustomErrorMessage'></a>

## ComparableTypeValidator<T>.HasCustomErrorMessage Property

Gets a value indicating whether this instance has custom error message.

```csharp
protected override bool HasCustomErrorMessage { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if this instance has custom error message; otherwise, `false`.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.MaxValue'></a>

## ComparableTypeValidator<T>.MaxValue Property

Gets the maximum value.

```csharp
public System.Nullable<T> MaxValue { get; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md#CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The maximum value.

<a name='CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.MinValue'></a>

## ComparableTypeValidator<T>.MinValue Property

Gets the minimum value.

```csharp
public System.Nullable<T> MinValue { get; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md#CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.T 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The minimum value.
### Methods

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