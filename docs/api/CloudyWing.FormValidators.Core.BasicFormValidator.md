#### [CloudyWing\.FormValidators](index.md 'index')
### [CloudyWing\.FormValidators\.Core](CloudyWing.FormValidators.Core.md 'CloudyWing\.FormValidators\.Core')

## BasicFormValidator Class

The basic form validator abstract class\.

```csharp
public abstract class BasicFormValidator : CloudyWing.FormValidators.Core.FormValidatorBase
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') &#129106; BasicFormValidator

Derived  
&#8627; [CreditCardValidator](CloudyWing.FormValidators.CreditCardValidator.md 'CloudyWing\.FormValidators\.CreditCardValidator')  
&#8627; [RegexValidator](CloudyWing.FormValidators.RegexValidator.md 'CloudyWing\.FormValidators\.RegexValidator')  
&#8627; [RequiredValidator](CloudyWing.FormValidators.RequiredValidator.md 'CloudyWing\.FormValidators\.RequiredValidator')  
&#8627; [UrlValidator](CloudyWing.FormValidators.UrlValidator.md 'CloudyWing\.FormValidators\.UrlValidator')

### See Also
- [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase')
### Constructors

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.BasicFormValidator(string,string,System.Func_string,string,string_)'></a>

## BasicFormValidator\(string, string, Func\<string,string,string\>\) Constructor

Initializes a new instance of the [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') class\.

```csharp
public BasicFormValidator(string column, string value, System.Func<string,string,string> customErrorMessageAccessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.BasicFormValidator(string,string,System.Func_string,string,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.BasicFormValidator(string,string,System.Func_string,string,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.BasicFormValidator(string,string,System.Func_string,string,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')

The custom error message accessor\. The arguments are column, value\.
### Properties

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.CustomErrorMessage'></a>

## BasicFormValidator\.CustomErrorMessage Property

Gets the custom error message\.

```csharp
protected override string CustomErrorMessage { protected get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The custom error message\.

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.CustomErrorMessageAccessor'></a>

## BasicFormValidator\.CustomErrorMessageAccessor Property

Gets or sets the custom error message accessor\.

```csharp
public System.Func<string,string,string> CustomErrorMessageAccessor { get; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')  
The custom error message accessor\.

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.DefaultErrorMessage'></a>

## BasicFormValidator\.DefaultErrorMessage Property

Gets the default error message\.

```csharp
protected override string DefaultErrorMessage { protected get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The default error message\.

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.DefaultErrorMessageAccessor'></a>

## BasicFormValidator\.DefaultErrorMessageAccessor Property

Gets the get default error message\.

```csharp
protected abstract System.Func<string,string,string> DefaultErrorMessageAccessor { protected get; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')  
The get default error message\.

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.HasCustomErrorMessage'></a>

## BasicFormValidator\.HasCustomErrorMessage Property

Gets a value indicating whether this instance has custom error message\.

```csharp
protected override bool HasCustomErrorMessage { protected get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if this instance has custom error message; otherwise, `false`\.