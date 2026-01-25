#### [CloudyWing\.FormValidators](index.md 'index')
### [CloudyWing\.FormValidators](CloudyWing.FormValidators.md 'CloudyWing\.FormValidators')

## UrlValidator Class

The URL validator\.

```csharp
public sealed class UrlValidator : CloudyWing.FormValidators.Core.BasicFormValidator
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') &#129106; [BasicFormValidator](CloudyWing.FormValidators.Core.BasicFormValidator.md 'CloudyWing\.FormValidators\.Core\.BasicFormValidator') &#129106; UrlValidator
### Constructors

<a name='CloudyWing.FormValidators.UrlValidator.UrlValidator(string,string,System.Func_string,string,string_)'></a>

## UrlValidator\(string, string, Func\<string,string,string\>\) Constructor

Initializes a new instance of the [UrlValidator](CloudyWing.FormValidators.UrlValidator.md 'CloudyWing\.FormValidators\.UrlValidator') class\.

```csharp
public UrlValidator(string column, string value, System.Func<string,string,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.UrlValidator.UrlValidator(string,string,System.Func_string,string,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.UrlValidator.UrlValidator(string,string,System.Func_string,string,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.UrlValidator.UrlValidator(string,string,System.Func_string,string,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')

The custom error message accessor\. The arguments are column, value\.

<a name='CloudyWing.FormValidators.UrlValidator.UrlValidator(string,string,System.UriKind,System.Func_string,string,string_)'></a>

## UrlValidator\(string, string, UriKind, Func\<string,string,string\>\) Constructor

Initializes a new instance of the [UrlValidator](CloudyWing.FormValidators.UrlValidator.md 'CloudyWing\.FormValidators\.UrlValidator') class\.

```csharp
public UrlValidator(string column, string value, System.UriKind kind, System.Func<string,string,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.UrlValidator.UrlValidator(string,string,System.UriKind,System.Func_string,string,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.UrlValidator.UrlValidator(string,string,System.UriKind,System.Func_string,string,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.UrlValidator.UrlValidator(string,string,System.UriKind,System.Func_string,string,string_).kind'></a>

`kind` [System\.UriKind](https://learn.microsoft.com/en-us/dotnet/api/system.urikind 'System\.UriKind')

The kind\.

<a name='CloudyWing.FormValidators.UrlValidator.UrlValidator(string,string,System.UriKind,System.Func_string,string,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')

The custom error message accessor\. The arguments are column, value\.
### Properties

<a name='CloudyWing.FormValidators.UrlValidator.DefaultErrorMessageAccessor'></a>

## UrlValidator\.DefaultErrorMessageAccessor Property

Gets the get default error message\.

```csharp
protected override System.Func<string,string,string> DefaultErrorMessageAccessor { protected get; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')  
The get default error message\.

<a name='CloudyWing.FormValidators.UrlValidator.Kind'></a>

## UrlValidator\.Kind Property

Gets the kind\.

```csharp
public System.UriKind Kind { get; }
```

#### Property Value
[System\.UriKind](https://learn.microsoft.com/en-us/dotnet/api/system.urikind 'System\.UriKind')  
The kind\.
### Methods

<a name='CloudyWing.FormValidators.UrlValidator.ValidateValue()'></a>

## UrlValidator\.ValidateValue\(\) Method

Validates the value\.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
The validation result\.