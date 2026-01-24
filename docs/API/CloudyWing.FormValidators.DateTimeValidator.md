#### [CloudyWing\.FormValidators](index.md 'index')
### [CloudyWing\.FormValidators](CloudyWing.FormValidators.md 'CloudyWing\.FormValidators')

## DateTimeValidator Class

Validation constrains the date time format of a value\.

```csharp
public sealed class DateTimeValidator : CloudyWing.FormValidators.Core.ComparableTypeValidator<System.DateTime>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') &#129106; [CloudyWing\.FormValidators\.Core\.ComparableTypeValidator&lt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing\.FormValidators\.Core\.ComparableTypeValidator\<T\>')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing\.FormValidators\.Core\.ComparableTypeValidator\<T\>') &#129106; DateTimeValidator
### Constructors

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_)'></a>

## DateTimeValidator\(string, string, Func\<string,string,Nullable\<DateTime\>,Nullable\<DateTime\>,string\>\) Constructor

Initializes a new instance of the [DateTimeValidator](CloudyWing.FormValidators.DateTimeValidator.md 'CloudyWing\.FormValidators\.DateTimeValidator') class\.

```csharp
public DateTimeValidator(string column, string value, System.Func<string,string,System.Nullable<System.DateTime>,System.Nullable<System.DateTime>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.DateTimeValidator.DateTimeValidator(string,string,System.Func_string,string,System.Nullable_System.DateTime_,System.Nullable_System.DateTime_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')

The custom error message accessor\. The agrumts are column, value, min, max\.
### Properties

<a name='CloudyWing.FormValidators.DateTimeValidator.CastErrorMessageAccessor'></a>

## DateTimeValidator\.CastErrorMessageAccessor Property

Gets the cast error message accessor\.

```csharp
protected override System.Func<string,string,string> CastErrorMessageAccessor { protected get; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')  
The cast error message accessor\.