#### [CloudyWing\.FormValidators](index.md 'index')
### [CloudyWing\.FormValidators](CloudyWing.FormValidators.md 'CloudyWing\.FormValidators')

## EmailValidator Class

The email validator\.

```csharp
public sealed class EmailValidator : CloudyWing.FormValidators.RegexValidator
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') &#129106; [BasicFormValidator](CloudyWing.FormValidators.Core.BasicFormValidator.md 'CloudyWing\.FormValidators\.Core\.BasicFormValidator') &#129106; [RegexValidator](CloudyWing.FormValidators.RegexValidator.md 'CloudyWing\.FormValidators\.RegexValidator') &#129106; EmailValidator

### See Also
- [RegexValidator](CloudyWing.FormValidators.RegexValidator.md 'CloudyWing\.FormValidators\.RegexValidator')
### Constructors

<a name='CloudyWing.FormValidators.EmailValidator.EmailValidator(string,string,System.Func_string,string,string_)'></a>

## EmailValidator\(string, string, Func\<string,string,string\>\) Constructor

Initializes a new instance of the [EmailValidator](CloudyWing.FormValidators.EmailValidator.md 'CloudyWing\.FormValidators\.EmailValidator') class\.

```csharp
public EmailValidator(string column, string value, System.Func<string,string,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.EmailValidator.EmailValidator(string,string,System.Func_string,string,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.EmailValidator.EmailValidator(string,string,System.Func_string,string,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.EmailValidator.EmailValidator(string,string,System.Func_string,string,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')

The custom error message accessor\. The agrumts are column, value\.
### Properties

<a name='CloudyWing.FormValidators.EmailValidator.DefaultErrorMessageAccessor'></a>

## EmailValidator\.DefaultErrorMessageAccessor Property

Gets the get default error message\.

```csharp
protected override System.Func<string,string,string> DefaultErrorMessageAccessor { protected get; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')  
The get default error message\.