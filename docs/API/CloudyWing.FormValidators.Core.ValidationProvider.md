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

Compare the value of one column with the value of another column.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.CompareValidator> Compare(string comparisonColumn, string comparisonValue, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Compare(string,string,string).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Compare(string,string,string).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Compare(string,string,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, comparison column, comparison value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[CompareValidator](CloudyWing.FormValidators.CompareValidator.md 'CloudyWing.FormValidators.CompareValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Compare(string,string,System.Func_string,string,string,string,string_)'></a>

## ValidationProvider.Compare(string, string, Func<string,string,string,string,string>) Method

Compare the value of one column with the value of another column.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.CompareValidator> Compare(string comparisonColumn, string comparisonValue, System.Func<string,string,string,string,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Compare(string,string,System.Func_string,string,string,string,string_).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Compare(string,string,System.Func_string,string,string,string,string_).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Compare(string,string,System.Func_string,string,string,string,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, comparison column, comparison value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[CompareValidator](CloudyWing.FormValidators.CompareValidator.md 'CloudyWing.FormValidators.CompareValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTime(string)'></a>

## ValidationProvider.DateTime(string) Method

Validation indicate that a value is date time.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeValidator> DateTime(string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTime(string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTime(System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_)'></a>

## ValidationProvider.DateTime(Func<string,string,Nullable<DateTime>,Nullable<DateTime>,string>) Method

Validation indicate that a value is date time.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeValidator> DateTime(System.Func<string,string,System.Nullable<System.DateTime>,System.Nullable<System.DateTime>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTime(System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,string)'></a>

## ValidationProvider.DateTimeLessThan(string, string, bool, string) Method

Validate that an date time value is less than another column value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeLessThanValidator> DateTimeLessThan(string comparisonColumn, string comparisonValue, bool allowedEqual, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,string).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,string).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,string).allowedEqual'></a>

`allowedEqual` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed equal].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, comparison column, comparison value, allowed equal.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeLessThanValidator](CloudyWing.FormValidators.DateTimeLessThanValidator.md 'CloudyWing.FormValidators.DateTimeLessThanValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_)'></a>

## ValidationProvider.DateTimeLessThan(string, string, bool, Func<string,string,string,string,bool,string>) Method

Validate that an date time value is less than another column value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeLessThanValidator> DateTimeLessThan(string comparisonColumn, string comparisonValue, bool allowedEqual=true, System.Func<string,string,string,string,bool,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_).allowedEqual'></a>

`allowedEqual` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed equal].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')

The custom error message accessor. The agrumts are column, value, comparison column, comparison value, allowed equal.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeLessThanValidator](CloudyWing.FormValidators.DateTimeLessThanValidator.md 'CloudyWing.FormValidators.DateTimeLessThanValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeRange(System.DateTime,System.DateTime,string)'></a>

## ValidationProvider.DateTimeRange(DateTime, DateTime, string) Method

Validation constrains the date time range of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeValidator> DateTimeRange(System.DateTime min, System.DateTime max, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeRange(System.DateTime,System.DateTime,string).min'></a>

`min` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeRange(System.DateTime,System.DateTime,string).max'></a>

`max` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeRange(System.DateTime,System.DateTime,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeRange(System.DateTime,System.DateTime,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_)'></a>

## ValidationProvider.DateTimeRange(DateTime, DateTime, Func<string,string,Nullable<DateTime>,Nullable<DateTime>,string>) Method

Validation constrains the date time range of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeValidator> DateTimeRange(System.DateTime min, System.DateTime max, System.Func<string,string,System.Nullable<System.DateTime>,System.Nullable<System.DateTime>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeRange(System.DateTime,System.DateTime,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_).min'></a>

`min` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeRange(System.DateTime,System.DateTime,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_).max'></a>

`max` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.DateTimeRange(System.DateTime,System.DateTime,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Email(string)'></a>

## ValidationProvider.Email(string) Method

Email validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.RegexValidator> Email(string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Email(string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[RegexValidator](CloudyWing.FormValidators.RegexValidator.md 'CloudyWing.FormValidators.RegexValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Email(System.Func_string,string,string_)'></a>

## ValidationProvider.Email(Func<string,string,string>) Method

Email validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.EmailValidator> Email(System.Func<string,string,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Email(System.Func_string,string,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

The custom error message accessor. The agrumts are column, value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[EmailValidator](CloudyWing.FormValidators.EmailValidator.md 'CloudyWing.FormValidators.EmailValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IdCard(CloudyWing.FormValidators.IdCardTypes,string)'></a>

## ValidationProvider.IdCard(IdCardTypes, string) Method

Identification card validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IdCardValidator> IdCard(CloudyWing.FormValidators.IdCardTypes idTypes, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IdCard(CloudyWing.FormValidators.IdCardTypes,string).idTypes'></a>

`idTypes` [IdCardTypes](CloudyWing.FormValidators.IdCardTypes.md 'CloudyWing.FormValidators.IdCardTypes')

The Identification types.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IdCard(CloudyWing.FormValidators.IdCardTypes,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, The identification card types.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IdCardValidator](CloudyWing.FormValidators.IdCardValidator.md 'CloudyWing.FormValidators.IdCardValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IdCard(CloudyWing.FormValidators.IdCardTypes,System.Func_string,string,CloudyWing.FormValidators.IdCardTypes,string_)'></a>

## ValidationProvider.IdCard(IdCardTypes, Func<string,string,IdCardTypes,string>) Method

Identification card validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IdCardValidator> IdCard(CloudyWing.FormValidators.IdCardTypes idTypes=CloudyWing.FormValidators.IdCardTypes.All, System.Func<string,string,CloudyWing.FormValidators.IdCardTypes,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IdCard(CloudyWing.FormValidators.IdCardTypes,System.Func_string,string,CloudyWing.FormValidators.IdCardTypes,string_).idTypes'></a>

`idTypes` [IdCardTypes](CloudyWing.FormValidators.IdCardTypes.md 'CloudyWing.FormValidators.IdCardTypes')

The Identification types.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IdCard(CloudyWing.FormValidators.IdCardTypes,System.Func_string,string,CloudyWing.FormValidators.IdCardTypes,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[IdCardTypes](CloudyWing.FormValidators.IdCardTypes.md 'CloudyWing.FormValidators.IdCardTypes')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

The custom error message accessor. The agrumts are column, value, The identification card types.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IdCardValidator](CloudyWing.FormValidators.IdCardValidator.md 'CloudyWing.FormValidators.IdCardValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Integer(bool,string)'></a>

## ValidationProvider.Integer(bool, string) Method

Validation indicate that a value is integer.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerValidator> Integer(bool allowedThousands, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Integer(bool,string).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Integer(bool,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Integer(bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_)'></a>

## ValidationProvider.Integer(bool, Func<string,string,Nullable<long>,Nullable<long>,string>) Method

Validation indicate that a value is integer.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerValidator> Integer(bool allowedThousands=false, System.Func<string,string,System.Nullable<long>,System.Nullable<long>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Integer(bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Integer(bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,string)'></a>

## ValidationProvider.IntegerLessThan(string, string, bool, string) Method

Validate that an integer value is less than another column value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerLessThanValidator> IntegerLessThan(string comparisonColumn, string comparisonValue, bool allowedEqual, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,string).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,string).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,string).allowedEqual'></a>

`allowedEqual` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed equal].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, comparison column, comparison value, allowed equal.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerLessThanValidator](CloudyWing.FormValidators.IntegerLessThanValidator.md 'CloudyWing.FormValidators.IntegerLessThanValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_)'></a>

## ValidationProvider.IntegerLessThan(string, string, bool, Func<string,string,string,string,bool,string>) Method

Validate that an integer value is less than another column value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerLessThanValidator> IntegerLessThan(string comparisonColumn, string comparisonValue, bool allowedEqual=true, System.Func<string,string,string,string,bool,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_).allowedEqual'></a>

`allowedEqual` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed equal].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntegerLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')

The custom error message accessor. The agrumts are column, value, comparison column, comparison value, allowed equal.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerLessThanValidator](CloudyWing.FormValidators.IntegerLessThanValidator.md 'CloudyWing.FormValidators.IntegerLessThanValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(long,long,bool,string)'></a>

## ValidationProvider.IntRange(long, long, bool, string) Method

Validation constrains the integer range of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerValidator> IntRange(long min, long max, bool allowedThousands, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(long,long,bool,string).min'></a>

`min` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(long,long,bool,string).max'></a>

`max` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(long,long,bool,string).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(long,long,bool,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(long,long,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_)'></a>

## ValidationProvider.IntRange(long, long, bool, Func<string,string,Nullable<long>,Nullable<long>,string>) Method

Validation constrains the integer range of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerValidator> IntRange(long min, long max, bool allowedThousands=false, System.Func<string,string,System.Nullable<long>,System.Nullable<long>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(long,long,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).min'></a>

`min` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(long,long,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).max'></a>

`max` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(long,long,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.IntRange(long,long,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.LengthRange(int,int,string)'></a>

## ValidationProvider.LengthRange(int, int, string) Method

Validation constraints a value does not exceed the length range.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.ValueLengthValidator> LengthRange(int min, int max, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.LengthRange(int,int,string).min'></a>

`min` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.LengthRange(int,int,string).max'></a>

`max` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.LengthRange(int,int,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.LengthRange(int,int,System.Func_string,string,long,long,string_)'></a>

## ValidationProvider.LengthRange(int, int, Func<string,string,long,long,string>) Method

Validation constraints a value does not exceed the length range.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.ValueLengthValidator> LengthRange(int min, int max, System.Func<string,string,long,long,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.LengthRange(int,int,System.Func_string,string,long,long,string_).min'></a>

`min` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.LengthRange(int,int,System.Func_string,string,long,long,string_).max'></a>

`max` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.LengthRange(int,int,System.Func_string,string,long,long,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxDateTime(System.DateTime,string)'></a>

## ValidationProvider.MaxDateTime(DateTime, string) Method

Validation constrains the maximum date time of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeValidator> MaxDateTime(System.DateTime max, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxDateTime(System.DateTime,string).max'></a>

`max` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxDateTime(System.DateTime,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxDateTime(System.DateTime,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_)'></a>

## ValidationProvider.MaxDateTime(DateTime, Func<string,string,Nullable<DateTime>,Nullable<DateTime>,string>) Method

Validation constrains the maximum date time of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeValidator> MaxDateTime(System.DateTime max, System.Func<string,string,System.Nullable<System.DateTime>,System.Nullable<System.DateTime>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxDateTime(System.DateTime,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_).max'></a>

`max` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxDateTime(System.DateTime,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxInt(long,bool,string)'></a>

## ValidationProvider.MaxInt(long, bool, string) Method

Validation constrains the maximum integer of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerValidator> MaxInt(long max, bool allowedThousands, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxInt(long,bool,string).max'></a>

`max` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxInt(long,bool,string).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxInt(long,bool,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxInt(long,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_)'></a>

## ValidationProvider.MaxInt(long, bool, Func<string,string,Nullable<long>,Nullable<long>,string>) Method

Validation constrains the maximum integer of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerValidator> MaxInt(long max, bool allowedThousands=false, System.Func<string,string,System.Nullable<long>,System.Nullable<long>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxInt(long,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).max'></a>

`max` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxInt(long,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxInt(long,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxLength(long,string)'></a>

## ValidationProvider.MaxLength(long, string) Method

Validation to constrains a value does not exceed a maximum length.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.ValueLengthValidator> MaxLength(long max, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxLength(long,string).max'></a>

`max` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxLength(long,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxLength(long,System.Func_string,string,long,long,string_)'></a>

## ValidationProvider.MaxLength(long, Func<string,string,long,long,string>) Method

Validation to constrains a value does not exceed a maximum length.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.ValueLengthValidator> MaxLength(long max, System.Func<string,string,long,long,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxLength(long,System.Func_string,string,long,long,string_).max'></a>

`max` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxLength(long,System.Func_string,string,long,long,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxNumber(decimal,bool,string)'></a>

## ValidationProvider.MaxNumber(decimal, bool, string) Method

Validation constrains the maximum number of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.NumberValidator> MaxNumber(decimal max, bool allowedThousands, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxNumber(decimal,bool,string).max'></a>

`max` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxNumber(decimal,bool,string).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxNumber(decimal,bool,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxNumber(decimal,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_)'></a>

## ValidationProvider.MaxNumber(decimal, bool, Func<string,string,Nullable<decimal>,Nullable<decimal>,string>) Method

Validation constrains the maximum number of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.NumberValidator> MaxNumber(decimal max, bool allowedThousands=false, System.Func<string,string,System.Nullable<decimal>,System.Nullable<decimal>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxNumber(decimal,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).max'></a>

`max` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxNumber(decimal,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MaxNumber(decimal,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinDateTime(System.DateTime,string)'></a>

## ValidationProvider.MinDateTime(DateTime, string) Method

Validation constrains the minimum date time of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeValidator> MinDateTime(System.DateTime min, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinDateTime(System.DateTime,string).min'></a>

`min` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinDateTime(System.DateTime,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinDateTime(System.DateTime,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_)'></a>

## ValidationProvider.MinDateTime(DateTime, Func<string,string,Nullable<DateTime>,Nullable<DateTime>,string>) Method

Validation constrains the minimum date time of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.DateTimeValidator> MinDateTime(System.DateTime min, System.Func<string,string,System.Nullable<System.DateTime>,System.Nullable<System.DateTime>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinDateTime(System.DateTime,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_).min'></a>

`min` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinDateTime(System.DateTime,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing.FormValidators.DateTimeValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinInt(long,bool,string)'></a>

## ValidationProvider.MinInt(long, bool, string) Method

Validation constrains the minimum integer of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerValidator> MinInt(long min, bool allowedThousands, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinInt(long,bool,string).min'></a>

`min` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinInt(long,bool,string).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinInt(long,bool,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinInt(long,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_)'></a>

## ValidationProvider.MinInt(long, bool, Func<string,string,Nullable<long>,Nullable<long>,string>) Method

Validation constrains the minimum integer of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IntegerValidator> MinInt(long min, bool allowedThousands=false, System.Func<string,string,System.Nullable<long>,System.Nullable<long>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinInt(long,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).min'></a>

`min` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinInt(long,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinInt(long,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing.FormValidators.IntegerValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinLength(long,string)'></a>

## ValidationProvider.MinLength(long, string) Method

Validation to constrains a value does not exceed a minimum length.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.ValueLengthValidator> MinLength(long min, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinLength(long,string).min'></a>

`min` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinLength(long,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinLength(long,System.Func_string,string,long,long,string_)'></a>

## ValidationProvider.MinLength(long, Func<string,string,long,long,string>) Method

Validation to constrains a value does not exceed a minimum length.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.ValueLengthValidator> MinLength(long min, System.Func<string,string,long,long,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinLength(long,System.Func_string,string,long,long,string_).min'></a>

`min` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinLength(long,System.Func_string,string,long,long,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinNumber(decimal,bool,string)'></a>

## ValidationProvider.MinNumber(decimal, bool, string) Method

Validation constrains the minimum number of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.NumberValidator> MinNumber(decimal min, bool allowedThousands, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinNumber(decimal,bool,string).min'></a>

`min` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinNumber(decimal,bool,string).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinNumber(decimal,bool,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinNumber(decimal,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_)'></a>

## ValidationProvider.MinNumber(decimal, bool, Func<string,string,Nullable<decimal>,Nullable<decimal>,string>) Method

Validation constrains the minimum number of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.NumberValidator> MinNumber(decimal min, bool allowedThousands=false, System.Func<string,string,System.Nullable<decimal>,System.Nullable<decimal>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinNumber(decimal,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).min'></a>

`min` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinNumber(decimal,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MinNumber(decimal,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MobilePhone(CloudyWing.FormValidators.MobilePhoneFormats,string)'></a>

## ValidationProvider.MobilePhone(MobilePhoneFormats, string) Method

Mobile phone validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.MobilePhoneValidator> MobilePhone(CloudyWing.FormValidators.MobilePhoneFormats formats, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MobilePhone(CloudyWing.FormValidators.MobilePhoneFormats,string).formats'></a>

`formats` [MobilePhoneFormats](CloudyWing.FormValidators.MobilePhoneFormats.md 'CloudyWing.FormValidators.MobilePhoneFormats')

The formats.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MobilePhone(CloudyWing.FormValidators.MobilePhoneFormats,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, The mobile phone formats.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[MobilePhoneValidator](CloudyWing.FormValidators.MobilePhoneValidator.md 'CloudyWing.FormValidators.MobilePhoneValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MobilePhone(CloudyWing.FormValidators.MobilePhoneFormats,System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_)'></a>

## ValidationProvider.MobilePhone(MobilePhoneFormats, Func<string,string,MobilePhoneFormats,string>) Method

Mobile phone validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.MobilePhoneValidator> MobilePhone(CloudyWing.FormValidators.MobilePhoneFormats formats=CloudyWing.FormValidators.MobilePhoneFormats.All, System.Func<string,string,CloudyWing.FormValidators.MobilePhoneFormats,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MobilePhone(CloudyWing.FormValidators.MobilePhoneFormats,System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_).formats'></a>

`formats` [MobilePhoneFormats](CloudyWing.FormValidators.MobilePhoneFormats.md 'CloudyWing.FormValidators.MobilePhoneFormats')

The formats.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.MobilePhone(CloudyWing.FormValidators.MobilePhoneFormats,System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[MobilePhoneFormats](CloudyWing.FormValidators.MobilePhoneFormats.md 'CloudyWing.FormValidators.MobilePhoneFormats')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

The custom error message accessor. The agrumts are column, value, The mobile phone formats.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[MobilePhoneValidator](CloudyWing.FormValidators.MobilePhoneValidator.md 'CloudyWing.FormValidators.MobilePhoneValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Number(bool,string)'></a>

## ValidationProvider.Number(bool, string) Method

Validation indicate that a value is number.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.NumberValidator> Number(bool allowedThousands, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Number(bool,string).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Number(bool,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Number(bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_)'></a>

## ValidationProvider.Number(bool, Func<string,string,Nullable<decimal>,Nullable<decimal>,string>) Method

Validation indicate that a value is number.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.NumberValidator> Number(bool allowedThousands=false, System.Func<string,string,System.Nullable<decimal>,System.Nullable<decimal>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Number(bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Number(bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,string)'></a>

## ValidationProvider.NumberLessThan(string, string, bool, string) Method

Validate that an number value is less than another column value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.NumberLessThanValidator> NumberLessThan(string comparisonColumn, string comparisonValue, bool allowedEqual, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,string).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,string).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,string).allowedEqual'></a>

`allowedEqual` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed equal].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, comparison column, comparison value, allowed equal.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[NumberLessThanValidator](CloudyWing.FormValidators.NumberLessThanValidator.md 'CloudyWing.FormValidators.NumberLessThanValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_)'></a>

## ValidationProvider.NumberLessThan(string, string, bool, Func<string,string,string,string,bool,string>) Method

Validate that an number value is less than another column value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.NumberLessThanValidator> NumberLessThan(string comparisonColumn, string comparisonValue, bool allowedEqual=true, System.Func<string,string,string,string,bool,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_).allowedEqual'></a>

`allowedEqual` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed equal].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberLessThan(string,string,bool,System.Func_string,string,string,string,bool,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')

The custom error message accessor. The agrumts are column, value, comparison column, comparison value, allowed equal.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[NumberLessThanValidator](CloudyWing.FormValidators.NumberLessThanValidator.md 'CloudyWing.FormValidators.NumberLessThanValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberRange(decimal,decimal,bool,string)'></a>

## ValidationProvider.NumberRange(decimal, decimal, bool, string) Method

Validation constrains the number range of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.NumberValidator> NumberRange(decimal min, decimal max, bool allowedThousands, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberRange(decimal,decimal,bool,string).min'></a>

`min` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberRange(decimal,decimal,bool,string).max'></a>

`max` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberRange(decimal,decimal,bool,string).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberRange(decimal,decimal,bool,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberRange(decimal,decimal,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_)'></a>

## ValidationProvider.NumberRange(decimal, decimal, bool, Func<string,string,Nullable<decimal>,Nullable<decimal>,string>) Method

Validation constrains the number range of a value.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.NumberValidator> NumberRange(decimal min, decimal max, bool allowedThousands=false, System.Func<string,string,System.Nullable<decimal>,System.Nullable<decimal>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberRange(decimal,decimal,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).min'></a>

`min` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The minimum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberRange(decimal,decimal,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).max'></a>

`max` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The maximum.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberRange(decimal,decimal,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).allowedThousands'></a>

`allowedThousands` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed thousands].

<a name='CloudyWing.FormValidators.Core.ValidationProvider.NumberRange(decimal,decimal,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The custom error message accessor. The agrumts are column, value, min, max.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing.FormValidators.NumberValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Regex(string,string)'></a>

## ValidationProvider.Regex(string, string) Method

Regex validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.RegexValidator> Regex(string pattern, string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Regex(string,string).pattern'></a>

`pattern` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The pattern.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Regex(string,string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[RegexValidator](CloudyWing.FormValidators.RegexValidator.md 'CloudyWing.FormValidators.RegexValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Regex(string,System.Func_string,string,string_)'></a>

## ValidationProvider.Regex(string, Func<string,string,string>) Method

Regex validation.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.RegexValidator> Regex(string pattern, System.Func<string,string,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Regex(string,System.Func_string,string,string_).pattern'></a>

`pattern` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The pattern.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Regex(string,System.Func_string,string,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

The custom error message accessor. The agrumts are column, value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[RegexValidator](CloudyWing.FormValidators.RegexValidator.md 'CloudyWing.FormValidators.RegexValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Required(string)'></a>

## ValidationProvider.Required(string) Method

Validation indicate that a value is required.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.RequiredValidator> Required(string customErrorMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Required(string).customErrorMessageFormat'></a>

`customErrorMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom error message format. The agrumts are column, value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[RequiredValidator](CloudyWing.FormValidators.RequiredValidator.md 'CloudyWing.FormValidators.RequiredValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Required(System.Func_string,string,string_)'></a>

## ValidationProvider.Required(Func<string,string,string>) Method

Validation indicate that a value is required.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.RequiredValidator> Required(System.Func<string,string,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidationProvider.Required(System.Func_string,string,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

The custom error message accessor. The agrumts are column, value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[RequiredValidator](CloudyWing.FormValidators.RequiredValidator.md 'CloudyWing.FormValidators.RequiredValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The validator creator.