#### [CloudyWing\.FormValidators](index.md 'index')
### [CloudyWing\.FormValidators](CloudyWing.FormValidators.md 'CloudyWing\.FormValidators')

## NumberLessThanValidator Class

Validate that an number value is less than another column value\.

```csharp
public sealed class NumberLessThanValidator : CloudyWing.FormValidators.Core.LessThanValidator<decimal>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') &#129106; [CloudyWing\.FormValidators\.Core\.LessThanValidator&lt;](CloudyWing.FormValidators.Core.LessThanValidator_T_.md 'CloudyWing\.FormValidators\.Core\.LessThanValidator\<T\>')[System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')[&gt;](CloudyWing.FormValidators.Core.LessThanValidator_T_.md 'CloudyWing\.FormValidators\.Core\.LessThanValidator\<T\>') &#129106; NumberLessThanValidator
### Constructors

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_)'></a>

## NumberLessThanValidator\(string, string, string, string, bool, Func\<string,string,string,string,bool,string\>\) Constructor

Initializes a new instance of the [NumberLessThanValidator](CloudyWing.FormValidators.NumberLessThanValidator.md 'CloudyWing\.FormValidators\.NumberLessThanValidator') class\.

```csharp
public NumberLessThanValidator(string column, string value, string comparisonColumn, string comparisonValue, bool allowedEqual=true, System.Func<string,string,string,string,bool,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).comparisonColumn'></a>

`comparisonColumn` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The comparison column\.

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).comparisonValue'></a>

`comparisonValue` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The comparison value\.

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).allowedEqual'></a>

`allowedEqual` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

if set to `true` \[allowed equal\]\.

<a name='CloudyWing.FormValidators.NumberLessThanValidator.NumberLessThanValidator(string,string,string,string,bool,System.Func_string,string,string,string,bool,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-6 'System\.Func\`6')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-6 'System\.Func\`6')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-6 'System\.Func\`6')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-6 'System\.Func\`6')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-6 'System\.Func\`6')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-6 'System\.Func\`6')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-6 'System\.Func\`6')

The custom error message accessor\. The arguments are column, value, comparison column, comparison value, allowed equal\.