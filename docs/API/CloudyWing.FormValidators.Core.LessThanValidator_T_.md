#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators.Core](CloudyWing.FormValidators.Core.md 'CloudyWing.FormValidators.Core')

## LessThanValidator<T> Class

The less than validator abstract class.

```csharp
public abstract class LessThanValidator<T> :
CloudyWing.FormValidators.IFormValidator
    where T : struct, System.IConvertible, System.IComparable<T>, System.IEquatable<T>, System.ValueType, System.ValueType
```
#### Type parameters

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.T'></a>

`T`

The value type.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; LessThanValidator<T>

Derived  
&#8627; [DateTimeLessThanValidator](CloudyWing.FormValidators.DateTimeLessThanValidator.md 'CloudyWing.FormValidators.DateTimeLessThanValidator')  
&#8627; [IntegerLessThanValidator](CloudyWing.FormValidators.IntegerLessThanValidator.md 'CloudyWing.FormValidators.IntegerLessThanValidator')  
&#8627; [NumberLessThanValidator](CloudyWing.FormValidators.NumberLessThanValidator.md 'CloudyWing.FormValidators.NumberLessThanValidator')

Implements [IFormValidator](CloudyWing.FormValidators.IFormValidator.md 'CloudyWing.FormValidators.IFormValidator')
### Constructors

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,string)'></a>

## LessThanValidator(string, string, string, string, bool, string) Constructor

Initializes a new instance of the [LessThanValidator&lt;T&gt;](CloudyWing.FormValidators.Core.LessThanValidator_T_.md 'CloudyWing.FormValidators.Core.LessThanValidator<T>') class.

```csharp
protected LessThanValidator(string column, string value, string comparisonColumn, string comparisonValue, bool allowedEquals=true, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,string).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,string).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,string).allowedEquals'></a>

`allowedEquals` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed equals].

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.LessThanValidator(string,string,string,string,bool,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format. Format argument: {0}:column {1}:comparisonColumn

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
column  
or  
value  
or  
comparisonColumn  
or  
comparisonValue
### Properties

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.AllowedEquals'></a>

## LessThanValidator<T>.AllowedEquals Property

Gets or sets a value indicating whether [allowed equals].

```csharp
public bool AllowedEquals { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [allowed equals]; otherwise, `false`.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.Column'></a>

## LessThanValidator<T>.Column Property

Gets or sets the column.

```csharp
public string Column { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The column.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.ComparisonColumn'></a>

## LessThanValidator<T>.ComparisonColumn Property

Gets or sets the comparison column.

```csharp
public string ComparisonColumn { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The comparison column.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.ComparisonValue'></a>

## LessThanValidator<T>.ComparisonValue Property

Gets or sets the comparison value.

```csharp
public string ComparisonValue { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The comparison value.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.CustomErrorMessageFormat'></a>

## LessThanValidator<T>.CustomErrorMessageFormat Property

Gets or sets the custom error message format.

```csharp
public string CustomErrorMessageFormat { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The custom error message format.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.DefaultErrorMessageFormat'></a>

## LessThanValidator<T>.DefaultErrorMessageFormat Property

Gets the default error message format.

```csharp
public virtual string DefaultErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message format.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.ErrorMessage'></a>

## LessThanValidator<T>.ErrorMessage Property

Gets the error message.

```csharp
public string ErrorMessage { get; set; }
```

Implements [ErrorMessage](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.ErrorMessage 'CloudyWing.FormValidators.IFormValidator.ErrorMessage')

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.IsValid'></a>

## LessThanValidator<T>.IsValid Property

Returns true if ... is valid.

```csharp
public bool IsValid { get; set; }
```

Implements [IsValid](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.IsValid 'CloudyWing.FormValidators.IFormValidator.IsValid')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if this instance is valid; otherwise, `false`.

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.Value'></a>

## LessThanValidator<T>.Value Property

Gets or sets the value.

```csharp
public string Value { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The value.
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

<a name='CloudyWing.FormValidators.Core.LessThanValidator_T_.Validate()'></a>

## LessThanValidator<T>.Validate() Method

Validates this instance.

```csharp
public bool Validate();
```

Implements [Validate()](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.Validate() 'CloudyWing.FormValidators.IFormValidator.Validate()')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.