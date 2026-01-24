#### [CloudyWing\.FormValidators](index.md 'index')
### [CloudyWing\.FormValidators](CloudyWing.FormValidators.md 'CloudyWing\.FormValidators')

## CompareValidator Class

Compare the value of one column with the value of another column\.

```csharp
public class CompareValidator : CloudyWing.FormValidators.Core.FormValidatorBase
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') &#129106; CompareValidator

### See Also
- [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase')
### Constructors

<a name='CloudyWing.FormValidators.CompareValidator.CompareValidator(string,string,string,string,System.Func_string,string,string,string,string_)'></a>

## CompareValidator\(string, string, string, string, Func\<string,string,string,string,string\>\) Constructor

Initializes a new instance of the [CompareValidator](CloudyWing.FormValidators.CompareValidator.md 'CloudyWing\.FormValidators\.CompareValidator') class\.

```csharp
public CompareValidator(string column, string value, string comparisonColumn, string comparisonValue, System.Func<string,string,string,string,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.CompareValidator.CompareValidator(string,string,string,string,System.Func_string,string,string,string,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.CompareValidator.CompareValidator(string,string,string,string,System.Func_string,string,string,string,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.CompareValidator.CompareValidator(string,string,string,string,System.Func_string,string,string,string,string_).comparisonColumn'></a>

`comparisonColumn` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The comparison column\.

<a name='CloudyWing.FormValidators.CompareValidator.CompareValidator(string,string,string,string,System.Func_string,string,string,string,string_).comparisonValue'></a>

`comparisonValue` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The comparison value\.

<a name='CloudyWing.FormValidators.CompareValidator.CompareValidator(string,string,string,string,System.Func_string,string,string,string,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')

The custom error message accessor\. The agrumts are column, value, comparison column, comparison value\.
### Properties

<a name='CloudyWing.FormValidators.CompareValidator.ComparisonColumn'></a>

## CompareValidator\.ComparisonColumn Property

Gets the comparison column\.

```csharp
public string ComparisonColumn { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The comparison column\.

<a name='CloudyWing.FormValidators.CompareValidator.ComparisonValue'></a>

## CompareValidator\.ComparisonValue Property

Gets the comparison value\.

```csharp
public string ComparisonValue { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The comparison value\.

<a name='CloudyWing.FormValidators.CompareValidator.CustomErrorMessage'></a>

## CompareValidator\.CustomErrorMessage Property

Gets the custom error message\.

```csharp
protected override string CustomErrorMessage { protected get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The custom error message\.

<a name='CloudyWing.FormValidators.CompareValidator.CustomErrorMessageAccessor'></a>

## CompareValidator\.CustomErrorMessageAccessor Property

Gets the custom range message format\.

```csharp
public System.Func<string,string,string,string,string> CustomErrorMessageAccessor { get; set; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')  
The custom range message format\.

<a name='CloudyWing.FormValidators.CompareValidator.DefaultErrorMessage'></a>

## CompareValidator\.DefaultErrorMessage Property

Gets the default error message\.

```csharp
protected override string DefaultErrorMessage { protected get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The default error message\.

<a name='CloudyWing.FormValidators.CompareValidator.HasCustomErrorMessage'></a>

## CompareValidator\.HasCustomErrorMessage Property

Gets a value indicating whether this instance has custom error message\.

```csharp
protected override bool HasCustomErrorMessage { protected get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if this instance has custom error message; otherwise, `false`\.
### Methods

<a name='CloudyWing.FormValidators.CompareValidator.ValidateValue()'></a>

## CompareValidator\.ValidateValue\(\) Method

Validates the value\.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
The validation result\.