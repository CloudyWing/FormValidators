#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators.Core](CloudyWing.FormValidators.Core.md 'CloudyWing.FormValidators.Core')

## ValidationProvider Class

The validation provider.

```csharp
public class ValidationProvider
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ValidationProvider
### Methods

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Compare(string,string,string)'></a>

## ValidationProvider.Compare(string, string, string) Method

Compares validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.CompareValidator> Compare(string comparisonColumn, string comparisonValue, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Compare(string,string,string).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Compare(string,string,string).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Compare(string,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[CompareValidator](CloudyWing.FormValidators.CompareValidator.md 'CloudyWing.FormValidators.CompareValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTime(string)'></a>

## ValidationProvider.DateTime(string) Method

Validation value is date time.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeValidator> DateTime(string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTime(string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,string)'></a>

## ValidationProvider.DateTimeLessThan(string, string, bool, string) Method

DateTime less than validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeLessThanValidator> DateTimeLessThan(string comparisonColumn, string comparisonValue, bool allowedEquals=true, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,string).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,string).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,string).allowedEquals'></a>

`allowedEquals` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed equals].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeLessThanValidator](CloudyWing.FormValidators.DateTimeLessThanValidator.md 'CloudyWing.FormValidators.DateTimeLessThanValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeRange(System.DateTime,System.DateTime,string)'></a>

## ValidationProvider.DateTimeRange(DateTime, DateTime, string) Method

Date time range of validation values.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeValidator> DateTimeRange(System.DateTime min, System.DateTime max, string errorMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeRange(System.DateTime,System.DateTime,string).min'></a>

`min` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeRange(System.DateTime,System.DateTime,string).max'></a>

`max` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeRange(System.DateTime,System.DateTime,string).errorMessageFormat'></a>

`errorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The error message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Email(string)'></a>

## ValidationProvider.Email(string) Method

Email validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.EmailValidator> Email(string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Email(string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[EmailValidator](CloudyWing.FormValidators.EmailValidator.md 'CloudyWing.FormValidators.EmailValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IdCard(CloudyWing.FormValidators.IdCardTypes,string)'></a>

## ValidationProvider.IdCard(IdCardTypes, string) Method

Identifiers card validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IdCardValidator> IdCard(CloudyWing.FormValidators.IdCardTypes idTypes=CloudyWing.FormValidators.IdCardTypes.All, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IdCard(CloudyWing.FormValidators.IdCardTypes,string).idTypes'></a>

`idTypes` [IdCardTypes](CloudyWing.FormValidators.IdCardTypes.md 'CloudyWing.FormValidators.IdCardTypes')

The identifier types.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IdCard(CloudyWing.FormValidators.IdCardTypes,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IdCardValidator](CloudyWing.FormValidators.IdCardValidator.md 'CloudyWing.FormValidators.IdCardValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Integer(string)'></a>

## ValidationProvider.Integer(string) Method

Validation value is integer.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerValidator> Integer(string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Integer(string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,string)'></a>

## ValidationProvider.IntegerLessThan(string, string, bool, string) Method

Integer less than validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerLessThanValidator> IntegerLessThan(string comparisonColumn, string comparisonValue, bool allowedEquals=true, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,string).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,string).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,string).allowedEquals'></a>

`allowedEquals` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed equals].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerLessThanValidator](CloudyWing.FormValidators.IntegerLessThanValidator.md 'CloudyWing.FormValidators.IntegerLessThanValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(int,int,string)'></a>

## ValidationProvider.IntRange(int, int, string) Method

Integer range of validation values.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerValidator> IntRange(int min, int max, string errorMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(int,int,string).min'></a>

`min` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(int,int,string).max'></a>

`max` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(int,int,string).errorMessageFormat'></a>

`errorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The error message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.LengthRange(int,int,string)'></a>

## ValidationProvider.LengthRange(int, int, string) Method

Validation value string length range.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.ValueLengthValidator> LengthRange(int min, int max, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.LengthRange(int,int,string).min'></a>

`min` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.LengthRange(int,int,string).max'></a>

`max` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.LengthRange(int,int,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxDateTime(System.DateTime,string)'></a>

## ValidationProvider.MaxDateTime(DateTime, string) Method

Max date time value for the validation value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeValidator> MaxDateTime(System.DateTime max, string maxDateTimeErrorMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxDateTime(System.DateTime,string).max'></a>

`max` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxDateTime(System.DateTime,string).maxDateTimeErrorMessageFormat'></a>

`maxDateTimeErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The maximum date time error message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxInt(int,string)'></a>

## ValidationProvider.MaxInt(int, string) Method

Max integer value for the validation value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerValidator> MaxInt(int max, string maxValueErrorMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxInt(int,string).max'></a>

`max` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxInt(int,string).maxValueErrorMessageFormat'></a>

`maxValueErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The maximum value error message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxLength(int,string)'></a>

## ValidationProvider.MaxLength(int, string) Method

The maximum string length of the validation value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.ValueLengthValidator> MaxLength(int max, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxLength(int,string).max'></a>

`max` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxLength(int,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinDateTime(System.DateTime,string)'></a>

## ValidationProvider.MinDateTime(DateTime, string) Method

Minimum date time value for the validation value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeValidator> MinDateTime(System.DateTime min, string minDateTimeErrorMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinDateTime(System.DateTime,string).min'></a>

`min` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinDateTime(System.DateTime,string).minDateTimeErrorMessageFormat'></a>

`minDateTimeErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The minimum date time error message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinInt(int,string)'></a>

## ValidationProvider.MinInt(int, string) Method

Minimum integer value for the validation value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerValidator> MinInt(int min, string minValueErrorMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinInt(int,string).min'></a>

`min` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinInt(int,string).minValueErrorMessageFormat'></a>

`minValueErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The minimum value error message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinLength(int,string)'></a>

## ValidationProvider.MinLength(int, string) Method

The minimum string length of the validation value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.ValueLengthValidator> MinLength(int min, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinLength(int,string).min'></a>

`min` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinLength(int,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MobilePhone(CloudyWing.FormValidators.MobilePhoneFormats,string)'></a>

## ValidationProvider.MobilePhone(MobilePhoneFormats, string) Method

Mobile phone validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.MobilePhoneValidator> MobilePhone(CloudyWing.FormValidators.MobilePhoneFormats formats, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MobilePhone(CloudyWing.FormValidators.MobilePhoneFormats,string).formats'></a>

`formats` [MobilePhoneFormats](CloudyWing.FormValidators.MobilePhoneFormats.md 'CloudyWing.FormValidators.MobilePhoneFormats')

The formats.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MobilePhone(CloudyWing.FormValidators.MobilePhoneFormats,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[MobilePhoneValidator](CloudyWing.FormValidators.MobilePhoneValidator.md 'CloudyWing.FormValidators.MobilePhoneValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MobilePhone(string)'></a>

## ValidationProvider.MobilePhone(string) Method

Mobile phone validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.MobilePhoneValidator> MobilePhone(string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MobilePhone(string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[MobilePhoneValidator](CloudyWing.FormValidators.MobilePhoneValidator.md 'CloudyWing.FormValidators.MobilePhoneValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,string)'></a>

## ValidationProvider.NumberLessThan(string, string, bool, string) Method

Number less than validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.NumberLessThanValidator> NumberLessThan(string comparisonColumn, string comparisonValue, bool allowedEquals=true, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,string).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,string).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,string).allowedEquals'></a>

`allowedEquals` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed equals].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[NumberLessThanValidator](CloudyWing.FormValidators.NumberLessThanValidator.md 'CloudyWing.FormValidators.NumberLessThanValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Regex(string,string)'></a>

## ValidationProvider.Regex(string, string) Method

Regex validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.RegexValidator> Regex(string pattern, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Regex(string,string).pattern'></a>

`pattern` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The pattern.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Regex(string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[RegexValidator](CloudyWing.FormValidators.RegexValidator.md 'CloudyWing.FormValidators.RegexValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Required(string)'></a>

## ValidationProvider.Required(string) Method

Validation value is required.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.RequiredValidator> Required(string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Required(string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[RequiredValidator](CloudyWing.FormValidators.RequiredValidator.md 'CloudyWing.FormValidators.RequiredValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.