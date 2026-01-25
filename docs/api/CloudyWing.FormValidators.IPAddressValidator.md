#### [CloudyWing\.FormValidators](index.md 'index')
### [CloudyWing\.FormValidators](CloudyWing.FormValidators.md 'CloudyWing\.FormValidators')

## IPAddressValidator Class

The IP address validator\.

```csharp
public sealed class IPAddressValidator : CloudyWing.FormValidators.Core.FormValidatorBase
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') &#129106; IPAddressValidator
### Constructors

<a name='CloudyWing.FormValidators.IPAddressValidator.IPAddressValidator(string,string,CloudyWing.FormValidators.IPAddressTypes,System.Func_string,string,CloudyWing.FormValidators.IPAddressTypes,string_)'></a>

## IPAddressValidator\(string, string, IPAddressTypes, Func\<string,string,IPAddressTypes,string\>\) Constructor

Initializes a new instance of the [IPAddressValidator](CloudyWing.FormValidators.IPAddressValidator.md 'CloudyWing\.FormValidators\.IPAddressValidator') class\.

```csharp
public IPAddressValidator(string column, string value, CloudyWing.FormValidators.IPAddressTypes types, System.Func<string,string,CloudyWing.FormValidators.IPAddressTypes,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.IPAddressValidator.IPAddressValidator(string,string,CloudyWing.FormValidators.IPAddressTypes,System.Func_string,string,CloudyWing.FormValidators.IPAddressTypes,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.IPAddressValidator.IPAddressValidator(string,string,CloudyWing.FormValidators.IPAddressTypes,System.Func_string,string,CloudyWing.FormValidators.IPAddressTypes,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.IPAddressValidator.IPAddressValidator(string,string,CloudyWing.FormValidators.IPAddressTypes,System.Func_string,string,CloudyWing.FormValidators.IPAddressTypes,string_).types'></a>

`types` [IPAddressTypes](CloudyWing.FormValidators.IPAddressTypes.md 'CloudyWing\.FormValidators\.IPAddressTypes')

The types\.

<a name='CloudyWing.FormValidators.IPAddressValidator.IPAddressValidator(string,string,CloudyWing.FormValidators.IPAddressTypes,System.Func_string,string,CloudyWing.FormValidators.IPAddressTypes,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[IPAddressTypes](CloudyWing.FormValidators.IPAddressTypes.md 'CloudyWing\.FormValidators\.IPAddressTypes')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')

The custom error message accessor\. The arguments are column, value, IP address types\.

<a name='CloudyWing.FormValidators.IPAddressValidator.IPAddressValidator(string,string,System.Func_string,string,CloudyWing.FormValidators.IPAddressTypes,string_)'></a>

## IPAddressValidator\(string, string, Func\<string,string,IPAddressTypes,string\>\) Constructor

Initializes a new instance of the [IPAddressValidator](CloudyWing.FormValidators.IPAddressValidator.md 'CloudyWing\.FormValidators\.IPAddressValidator') class\.

```csharp
public IPAddressValidator(string column, string value, System.Func<string,string,CloudyWing.FormValidators.IPAddressTypes,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.IPAddressValidator.IPAddressValidator(string,string,System.Func_string,string,CloudyWing.FormValidators.IPAddressTypes,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.IPAddressValidator.IPAddressValidator(string,string,System.Func_string,string,CloudyWing.FormValidators.IPAddressTypes,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.IPAddressValidator.IPAddressValidator(string,string,System.Func_string,string,CloudyWing.FormValidators.IPAddressTypes,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[IPAddressTypes](CloudyWing.FormValidators.IPAddressTypes.md 'CloudyWing\.FormValidators\.IPAddressTypes')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')

The custom error message accessor\. The arguments are column, value, IP address types\.
### Properties

<a name='CloudyWing.FormValidators.IPAddressValidator.CustomErrorMessage'></a>

## IPAddressValidator\.CustomErrorMessage Property

Gets the custom error message\.

```csharp
protected override string CustomErrorMessage { protected get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The custom error message\.

<a name='CloudyWing.FormValidators.IPAddressValidator.CustomErrorMessageAccessor'></a>

## IPAddressValidator\.CustomErrorMessageAccessor Property

Gets or sets the custom error message accessor\.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IPAddressTypes,string> CustomErrorMessageAccessor { get; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[IPAddressTypes](CloudyWing.FormValidators.IPAddressTypes.md 'CloudyWing\.FormValidators\.IPAddressTypes')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')  
The custom error message accessor\.

<a name='CloudyWing.FormValidators.IPAddressValidator.DefaultErrorMessage'></a>

## IPAddressValidator\.DefaultErrorMessage Property

Gets the default error message\.

```csharp
protected override string DefaultErrorMessage { protected get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The default error message\.

<a name='CloudyWing.FormValidators.IPAddressValidator.HasCustomErrorMessage'></a>

## IPAddressValidator\.HasCustomErrorMessage Property

Gets a value indicating whether this instance has custom error message\.

```csharp
protected override bool HasCustomErrorMessage { protected get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if this instance has custom error message; otherwise, `false`\.

<a name='CloudyWing.FormValidators.IPAddressValidator.Types'></a>

## IPAddressValidator\.Types Property

Gets the types\.

```csharp
public CloudyWing.FormValidators.IPAddressTypes Types { get; }
```

#### Property Value
[IPAddressTypes](CloudyWing.FormValidators.IPAddressTypes.md 'CloudyWing\.FormValidators\.IPAddressTypes')  
The types\.
### Methods

<a name='CloudyWing.FormValidators.IPAddressValidator.ValidateValue()'></a>

## IPAddressValidator\.ValidateValue\(\) Method

Validates the value\.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
The validation result\.