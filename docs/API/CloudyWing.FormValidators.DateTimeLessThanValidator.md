#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## DateTimeLessThanValidator Class

Validate that an date time value is less than another column value.

```csharp
public sealed class DateTimeLessThanValidator : CloudyWing.FormValidators.Core.LessThanValidator<System.DateTime>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; [CloudyWing.FormValidators.Core.LessThanValidator&lt;](CloudyWing.FormValidators.Core.LessThanValidator_T_.md 'CloudyWing.FormValidators.Core.LessThanValidator<T>')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](CloudyWing.FormValidators.Core.LessThanValidator_T_.md 'CloudyWing.FormValidators.Core.LessThanValidator<T>') &#129106; DateTimeLessThanValidator
### Constructors

<a name='CloudyWing.FormValidators.DateTimeLessThanValidator.DateTimeLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_)'></a>

## DateTimeLessThanValidator(string, string, string, string, bool, Func<string,string,string,string,bool,string>) Constructor

Initializes a new instance of the [DateTimeLessThanValidator](CloudyWing.FormValidators.DateTimeLessThanValidator.md 'CloudyWing.FormValidators.DateTimeLessThanValidator') class.

```csharp
public DateTimeLessThanValidator(string column, string value, string comparisonColumn, string comparisonValue, bool allowedEqual=true, System.Func<string,string,string,string,bool,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.DateTimeLessThanValidator.DateTimeLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.DateTimeLessThanValidator.DateTimeLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.DateTimeLessThanValidator.DateTimeLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).comparisonColumn'></a>

`comparisonColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison column.

<a name='CloudyWing.FormValidators.DateTimeLessThanValidator.DateTimeLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).comparisonValue'></a>

`comparisonValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The comparison value.

<a name='CloudyWing.FormValidators.DateTimeLessThanValidator.DateTimeLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).allowedEqual'></a>

`allowedEqual` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [allowed equal].

<a name='CloudyWing.FormValidators.DateTimeLessThanValidator.DateTimeLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')

The custom error message accessor. The agrumts are column, value, comparison column, comparison value, allowed equal.