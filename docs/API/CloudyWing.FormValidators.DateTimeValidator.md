#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## DateTimeValidator Class

Th date time validator.

```csharp
public sealed class DateTimeValidator : CloudyWing.FormValidators.Core.ComparableTypeValidator<System.DateTime>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; [CloudyWing.FormValidators.Core.ComparableTypeValidator&lt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>') &#129106; DateTimeValidator
### Constructors

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,string)'></a>

## DateTimeValidator(string, string, string) Constructor

Initializes a new instance of the [DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator') class.

```csharp
public DateTimeValidator(string column, string value, string customMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string,string)'></a>

## DateTimeValidator(string, string, Nullable<DateTime>, Nullable<DateTime>, string, string) Constructor

sInitializes a new instance of the [DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator') class.

```csharp
public DateTimeValidator(string column, string value, System.Nullable<System.DateTime> min=null, System.Nullable<System.DateTime> max=null, string customMessageFormat=null, string customRangeMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string,string).min'></a>

`min` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The minimum.

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string,string).max'></a>

`max` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The maximum.

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string,string).customRangeMessageFormat'></a>

`customRangeMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom range message format.
### Properties

<a name='CloudyWing.FormValidators.DateTimeValidator.DefaultErrorMessageFormat'></a>

## DateTimeValidator.DefaultErrorMessageFormat Property

Gets the default error message format.

```csharp
public override string DefaultErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message format.
### Methods

<a name='CloudyWing.FormValidators.DateTimeValidator.CreateMaxDateTime(string,string,System.DateTime,string,string)'></a>

## DateTimeValidator.CreateMaxDateTime(string, string, DateTime, string, string) Method

Creates the maximum date time.

```csharp
public static CloudyWing.FormValidators.DateTimeValidator CreateMaxDateTime(string column, string value, System.DateTime max, string customMessageFormat=null, string customRangeMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.DateTimeValidator.CreateMaxDateTime(string,string,System.DateTime,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.DateTimeValidator.CreateMaxDateTime(string,string,System.DateTime,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.DateTimeValidator.CreateMaxDateTime(string,string,System.DateTime,string,string).max'></a>

`max` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The maximum.

<a name='CloudyWing.FormValidators.DateTimeValidator.CreateMaxDateTime(string,string,System.DateTime,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.DateTimeValidator.CreateMaxDateTime(string,string,System.DateTime,string,string).customRangeMessageFormat'></a>

`customRangeMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom range message format.

#### Returns
[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')  
The maximum date time validator.

<a name='CloudyWing.FormValidators.DateTimeValidator.CreateMinDateTime(string,string,System.DateTime,string,string)'></a>

## DateTimeValidator.CreateMinDateTime(string, string, DateTime, string, string) Method

Creates the minimum date time validator.

```csharp
public static CloudyWing.FormValidators.DateTimeValidator CreateMinDateTime(string column, string value, System.DateTime min, string customMessageFormat=null, string customRangeMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.DateTimeValidator.CreateMinDateTime(string,string,System.DateTime,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.DateTimeValidator.CreateMinDateTime(string,string,System.DateTime,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.DateTimeValidator.CreateMinDateTime(string,string,System.DateTime,string,string).min'></a>

`min` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The minimum.

<a name='CloudyWing.FormValidators.DateTimeValidator.CreateMinDateTime(string,string,System.DateTime,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.DateTimeValidator.CreateMinDateTime(string,string,System.DateTime,string,string).customRangeMessageFormat'></a>

`customRangeMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom range message format.

#### Returns
[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')  
The minimum date time validator.