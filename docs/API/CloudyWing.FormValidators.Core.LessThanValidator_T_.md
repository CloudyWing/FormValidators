#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators.Core](CloudyWing.FormValidators.Core.md 'CloudyWing.FormValidators.Core')

## LessThanValidator<T> Class

The less than other column value validator abstract class.

```csharp
public abstract class LessThanValidator<T> : CloudyWing.FormValidators.Core.FormValidatorBase
    where T : struct, System.IConvertible, System.IComparable<T>, System.IEquatable<T>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.T'></a>

`T`

The value type.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; LessThanValidator<T>

Derived  
&#8627; [DateTimeLessThanValidator](CloudyWing.FormValidators.DateTimeLessThanValidator.md 'CloudyWing.FormValidators.DateTimeLessThanValidator')  
&#8627; [IntegerLessThanValidator](CloudyWing.FormValidators.IntegerLessThanValidator.md 'CloudyWing.FormValidators.IntegerLessThanValidator')  
&#8627; [NumberLessThanValidator](CloudyWing.FormValidators.NumberLessThanValidator.md 'CloudyWing.FormValidators.NumberLessThanValidator')
### Constructors

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_)'></a>

## LessThanValidator(string, string, string, string, bool, Func<string,string,string,string,bool,string>) Constructor

Initializes a new instance of the [LessThanValidator&lt;T&gt;](CloudyWing.FormValidators.Core.LessThanValidator_T_.md 'CloudyWing.FormValidators.Core.LessThanValidator<T>') class.

```csharp
protected LessThanValidator(string column, string value, string comparisonColumn, string comparisonValue, bool allowedEqual=true, System.Func<string,string,string,string,bool,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).allowedEqual'></a>

`allowedEqual` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed equal].

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')

The custom error message accessor. The agrumts are column, value, comparison column, comparison value, allowed equal.
### Properties

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.AllowedEqual'></a>

## LessThanValidator<T>.AllowedEqual Property

Gets or sets a value indicating whether [allowed equal].

```csharp
public bool AllowedEqual { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [allowed equal]; otherwise, `false`.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.ComparisonColumn'></a>

## LessThanValidator<T>.ComparisonColumn Property

Gets or sets the comparison column.

```csharp
public string ComparisonColumn { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The comparison column.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.ComparisonValue'></a>

## LessThanValidator<T>.ComparisonValue Property

Gets or sets the comparison value.

```csharp
public string ComparisonValue { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The comparison value.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.CustomErrorMessage'></a>

## LessThanValidator<T>.CustomErrorMessage Property

Gets the custom error message.

```csharp
protected override string CustomErrorMessage { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The custom error message.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.CustomErrorMessageAccessor'></a>

## LessThanValidator<T>.CustomErrorMessageAccessor Property

Gets the custom range message format.

```csharp
public System.Func<string,string,string,string,bool,string> CustomErrorMessageAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')  
The custom range message format.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.DefaultErrorMessage'></a>

## LessThanValidator<T>.DefaultErrorMessage Property

Gets the default error message.

```csharp
protected override string DefaultErrorMessage { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.HasCustomErrorMessage'></a>

## LessThanValidator<T>.HasCustomErrorMessage Property

Gets a value indicating whether this instance has custom error message.

```csharp
protected override bool HasCustomErrorMessage { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if this instance has custom error message; otherwise, `false`.
### Methods

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.TryParse(string,T)'></a>

## LessThanValidator<T>.TryParse(string, T) Method

Tries the parse.

```csharp
protected abstract bool TryParse(string value, out T result);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.TryParse(string,T).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.TryParse(string,T).result'></a>

`result` [T](CloudyWing.FormValidators.Core.LessThanValidator_T_.md#CloudyWing.FormValidators.Core.LessThanValidator_T_.T 'CloudyWing.FormValidators.Core.LessThanValidator<T>.T')

The result.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Parse value to type `T` result.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.ValidateValue()'></a>

## LessThanValidator<T>.ValidateValue() Method

Validates the value.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.