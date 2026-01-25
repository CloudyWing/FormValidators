#### [CloudyWing\.FormValidators](index.md 'index')
### [CloudyWing\.FormValidators](CloudyWing.FormValidators.md 'CloudyWing\.FormValidators')

## IdCardValidator Class

The identity card validator\.

```csharp
public sealed class IdCardValidator : CloudyWing.FormValidators.Core.FormValidatorBase
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') &#129106; IdCardValidator
### Constructors

<a name='CloudyWing.FormValidators.IdCardValidator.IdCardValidator(string,string,CloudyWing.FormValidators.IdCardTypes,System.Func_string,string,CloudyWing.FormValidators.IdCardTypes,string_)'></a>

## IdCardValidator\(string, string, IdCardTypes, Func\<string,string,IdCardTypes,string\>\) Constructor

Initializes a new instance of the [IdCardValidator](CloudyWing.FormValidators.IdCardValidator.md 'CloudyWing\.FormValidators\.IdCardValidator') class\.

```csharp
public IdCardValidator(string column, string value, CloudyWing.FormValidators.IdCardTypes idCardType=CloudyWing.FormValidators.IdCardTypes.All, System.Func<string,string,CloudyWing.FormValidators.IdCardTypes,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.IdCardValidator.IdCardValidator(string,string,CloudyWing.FormValidators.IdCardTypes,System.Func_string,string,CloudyWing.FormValidators.IdCardTypes,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.IdCardValidator.IdCardValidator(string,string,CloudyWing.FormValidators.IdCardTypes,System.Func_string,string,CloudyWing.FormValidators.IdCardTypes,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.IdCardValidator.IdCardValidator(string,string,CloudyWing.FormValidators.IdCardTypes,System.Func_string,string,CloudyWing.FormValidators.IdCardTypes,string_).idCardType'></a>

`idCardType` [IdCardTypes](CloudyWing.FormValidators.IdCardTypes.md 'CloudyWing\.FormValidators\.IdCardTypes')

Type of the identification card\.

<a name='CloudyWing.FormValidators.IdCardValidator.IdCardValidator(string,string,CloudyWing.FormValidators.IdCardTypes,System.Func_string,string,CloudyWing.FormValidators.IdCardTypes,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[IdCardTypes](CloudyWing.FormValidators.IdCardTypes.md 'CloudyWing\.FormValidators\.IdCardTypes')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')

The custom error message accessor\. The arguments are column, value, identification card types\.
### Properties

<a name='CloudyWing.FormValidators.IdCardValidator.CustomErrorMessage'></a>

## IdCardValidator\.CustomErrorMessage Property

Gets the custom error message\.

```csharp
protected override string CustomErrorMessage { protected get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The custom error message\.

<a name='CloudyWing.FormValidators.IdCardValidator.CustomErrorMessageAccessor'></a>

## IdCardValidator\.CustomErrorMessageAccessor Property

Gets or sets the custom error message accessor\.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.IdCardTypes,string> CustomErrorMessageAccessor { get; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[IdCardTypes](CloudyWing.FormValidators.IdCardTypes.md 'CloudyWing\.FormValidators\.IdCardTypes')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-4 'System\.Func\`4')  
The custom error message accessor\.

<a name='CloudyWing.FormValidators.IdCardValidator.DefaultErrorMessage'></a>

## IdCardValidator\.DefaultErrorMessage Property

Gets the default error message\.

```csharp
protected override string DefaultErrorMessage { protected get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The default error message\.

<a name='CloudyWing.FormValidators.IdCardValidator.HasCustomErrorMessage'></a>

## IdCardValidator\.HasCustomErrorMessage Property

Gets a value indicating whether this instance has custom error message\.

```csharp
protected override bool HasCustomErrorMessage { protected get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if this instance has custom error message; otherwise, `false`\.

<a name='CloudyWing.FormValidators.IdCardValidator.IdCardType'></a>

## IdCardValidator\.IdCardType Property

Gets the type of the identification card\.

```csharp
public CloudyWing.FormValidators.IdCardTypes IdCardType { get; }
```

#### Property Value
[IdCardTypes](CloudyWing.FormValidators.IdCardTypes.md 'CloudyWing\.FormValidators\.IdCardTypes')  
The type of the identification card\.
### Methods

<a name='CloudyWing.FormValidators.IdCardValidator.ValidateValue()'></a>

## IdCardValidator\.ValidateValue\(\) Method

Validates the value\.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
The validation result\.