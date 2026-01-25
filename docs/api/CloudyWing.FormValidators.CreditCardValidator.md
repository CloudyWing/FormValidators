#### [CloudyWing\.FormValidators](index.md 'index')
### [CloudyWing\.FormValidators](CloudyWing.FormValidators.md 'CloudyWing\.FormValidators')

## CreditCardValidator Class

The credit card validator\.

```csharp
public sealed class CreditCardValidator : CloudyWing.FormValidators.Core.BasicFormValidator
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') &#129106; [BasicFormValidator](CloudyWing.FormValidators.Core.BasicFormValidator.md 'CloudyWing\.FormValidators\.Core\.BasicFormValidator') &#129106; CreditCardValidator
### Constructors

<a name='CloudyWing.FormValidators.CreditCardValidator.CreditCardValidator(string,string,System.Func_string,string,string_)'></a>

## CreditCardValidator\(string, string, Func\<string,string,string\>\) Constructor

Initializes a new instance of the [CreditCardValidator](CloudyWing.FormValidators.CreditCardValidator.md 'CloudyWing\.FormValidators\.CreditCardValidator') class\.

```csharp
public CreditCardValidator(string column, string value, System.Func<string,string,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.CreditCardValidator.CreditCardValidator(string,string,System.Func_string,string,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.CreditCardValidator.CreditCardValidator(string,string,System.Func_string,string,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.CreditCardValidator.CreditCardValidator(string,string,System.Func_string,string,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')

The custom error message accessor\. The arguments are column, value\.
### Properties

<a name='CloudyWing.FormValidators.CreditCardValidator.DefaultErrorMessageAccessor'></a>

## CreditCardValidator\.DefaultErrorMessageAccessor Property

Gets the get default error message\.

```csharp
protected override System.Func<string,string,string> DefaultErrorMessageAccessor { protected get; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')  
The get default error message\.
### Methods

<a name='CloudyWing.FormValidators.CreditCardValidator.ValidateValue()'></a>

## CreditCardValidator\.ValidateValue\(\) Method

Validates the value\.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
The validation result\.