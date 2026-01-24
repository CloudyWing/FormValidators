#### [CloudyWing\.FormValidators](index.md 'index')
### [CloudyWing\.FormValidators](CloudyWing.FormValidators.md 'CloudyWing\.FormValidators')

## ValueLengthValidator Class

Validation constraints a value does not exceed the length range\.

```csharp
public sealed class ValueLengthValidator : CloudyWing.FormValidators.Core.FormValidatorBase
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') &#129106; ValueLengthValidator

### See Also
- [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase')
### Constructors

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,long,long,System.Func_string,string,long,long,string_)'></a>

## ValueLengthValidator\(string, string, long, long, Func\<string,string,long,long,string\>\) Constructor

Initializes a new instance of the [ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing\.FormValidators\.ValueLengthValidator') class\.

```csharp
public ValueLengthValidator(string column, string value, long min, long max, System.Func<string,string,long,long,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,long,long,System.Func_string,string,long,long,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,long,long,System.Func_string,string,long,long,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,long,long,System.Func_string,string,long,long,string_).min'></a>

`min` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The minimum\. Less than or equal to 0 means unlimited\.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,long,long,System.Func_string,string,long,long,string_).max'></a>

`max` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The maximum\. Less than or equal to 0 means unlimited\.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,long,long,System.Func_string,string,long,long,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')

The custom error message accessor\. The agrumts are column, value, min, max\.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,long,System.Func_string,string,long,long,string_)'></a>

## ValueLengthValidator\(string, string, long, Func\<string,string,long,long,string\>\) Constructor

Initializes a new instance of the [ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing\.FormValidators\.ValueLengthValidator') class\.

```csharp
public ValueLengthValidator(string column, string value, long max, System.Func<string,string,long,long,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,long,System.Func_string,string,long,long,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,long,System.Func_string,string,long,long,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,long,System.Func_string,string,long,long,string_).max'></a>

`max` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The maximum\.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,long,System.Func_string,string,long,long,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')

The custom error message accessor\. The agrumts are column, value, min, max\.
### Properties

<a name='CloudyWing.FormValidators.ValueLengthValidator.CustomErrorMessage'></a>

## ValueLengthValidator\.CustomErrorMessage Property

Gets the custom error message\.

```csharp
protected override string CustomErrorMessage { protected get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The custom error message\.

<a name='CloudyWing.FormValidators.ValueLengthValidator.CustomErrorMessageAccessor'></a>

## ValueLengthValidator\.CustomErrorMessageAccessor Property

Gets the custom range message format\.

```csharp
public System.Func<string,string,long,long,string> CustomErrorMessageAccessor { get; set; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')  
The custom range message format\.

<a name='CloudyWing.FormValidators.ValueLengthValidator.DefaultErrorMessage'></a>

## ValueLengthValidator\.DefaultErrorMessage Property

Gets the default error message\.

```csharp
protected override string DefaultErrorMessage { protected get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The default error message\.

<a name='CloudyWing.FormValidators.ValueLengthValidator.HasCustomErrorMessage'></a>

## ValueLengthValidator\.HasCustomErrorMessage Property

Gets a value indicating whether this instance has custom error message\.

```csharp
protected override bool HasCustomErrorMessage { protected get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if this instance has custom error message; otherwise, `false`\.

<a name='CloudyWing.FormValidators.ValueLengthValidator.MaxLength'></a>

## ValueLengthValidator\.MaxLength Property

Gets the maximum length\.

```csharp
public long MaxLength { get; }
```

#### Property Value
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')  
The maximum length\.

<a name='CloudyWing.FormValidators.ValueLengthValidator.MinLength'></a>

## ValueLengthValidator\.MinLength Property

Gets the minimum length\.

```csharp
public long MinLength { get; }
```

#### Property Value
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')  
The minimum length\.
### Methods

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValidateValue()'></a>

## ValueLengthValidator\.ValidateValue\(\) Method

Validates the value\.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
The validation result\.