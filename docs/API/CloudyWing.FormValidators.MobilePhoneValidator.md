#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## MobilePhoneValidator Class

The mobile phone validator.

```csharp
public sealed class MobilePhoneValidator : CloudyWing.FormValidators.Core.FormValidatorBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; MobilePhoneValidator
### Constructors

<a name='CloudyWing.FormValidators.MobilePhoneValidator.MobilePhoneValidator(string,string,CloudyWing.FormValidators.MobilePhoneFormats,System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_)'></a>

## MobilePhoneValidator(string, string, MobilePhoneFormats, Func<string,string,MobilePhoneFormats,string>) Constructor

Initializes a new instance of the [MobilePhoneValidator](CloudyWing.FormValidators.MobilePhoneValidator.md 'CloudyWing.FormValidators.MobilePhoneValidator') class.

```csharp
public MobilePhoneValidator(string column, string value, CloudyWing.FormValidators.MobilePhoneFormats formats, System.Func<string,string,CloudyWing.FormValidators.MobilePhoneFormats,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.MobilePhoneValidator.MobilePhoneValidator(string,string,CloudyWing.FormValidators.MobilePhoneFormats,System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.MobilePhoneValidator.MobilePhoneValidator(string,string,CloudyWing.FormValidators.MobilePhoneFormats,System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.MobilePhoneValidator.MobilePhoneValidator(string,string,CloudyWing.FormValidators.MobilePhoneFormats,System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_).formats'></a>

`formats` [MobilePhoneFormats](CloudyWing.FormValidators.MobilePhoneFormats.md 'CloudyWing.FormValidators.MobilePhoneFormats')

The formats.

<a name='CloudyWing.FormValidators.MobilePhoneValidator.MobilePhoneValidator(string,string,CloudyWing.FormValidators.MobilePhoneFormats,System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[MobilePhoneFormats](CloudyWing.FormValidators.MobilePhoneFormats.md 'CloudyWing.FormValidators.MobilePhoneFormats')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

The custom error message accessor. The agrumts are column, value, mobile phone formats.

<a name='CloudyWing.FormValidators.MobilePhoneValidator.MobilePhoneValidator(string,string,System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_)'></a>

## MobilePhoneValidator(string, string, Func<string,string,MobilePhoneFormats,string>) Constructor

Initializes a new instance of the [MobilePhoneValidator](CloudyWing.FormValidators.MobilePhoneValidator.md 'CloudyWing.FormValidators.MobilePhoneValidator') class.

```csharp
public MobilePhoneValidator(string column, string value, System.Func<string,string,CloudyWing.FormValidators.MobilePhoneFormats,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.MobilePhoneValidator.MobilePhoneValidator(string,string,System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.MobilePhoneValidator.MobilePhoneValidator(string,string,System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.MobilePhoneValidator.MobilePhoneValidator(string,string,System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[MobilePhoneFormats](CloudyWing.FormValidators.MobilePhoneFormats.md 'CloudyWing.FormValidators.MobilePhoneFormats')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

The custom error message accessor. The agrumts are column, value, mobile phone formats.
### Properties

<a name='CloudyWing.FormValidators.MobilePhoneValidator.CustomErrorMessage'></a>

## MobilePhoneValidator.CustomErrorMessage Property

Gets the custom error message.

```csharp
protected override string CustomErrorMessage { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The custom error message.

<a name='CloudyWing.FormValidators.MobilePhoneValidator.CustomErrorMessageAccessor'></a>

## MobilePhoneValidator.CustomErrorMessageAccessor Property

Gets or sets the custom error message accessor.

```csharp
public System.Func<string,string,CloudyWing.FormValidators.MobilePhoneFormats,string> CustomErrorMessageAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[MobilePhoneFormats](CloudyWing.FormValidators.MobilePhoneFormats.md 'CloudyWing.FormValidators.MobilePhoneFormats')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')  
The custom error message accessor.

<a name='CloudyWing.FormValidators.MobilePhoneValidator.DefaultErrorMessage'></a>

## MobilePhoneValidator.DefaultErrorMessage Property

Gets the default error message.

```csharp
protected override string DefaultErrorMessage { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message.

<a name='CloudyWing.FormValidators.MobilePhoneValidator.Formats'></a>

## MobilePhoneValidator.Formats Property

Gets or sets the formats.

```csharp
public CloudyWing.FormValidators.MobilePhoneFormats Formats { get; }
```

#### Property Value
[MobilePhoneFormats](CloudyWing.FormValidators.MobilePhoneFormats.md 'CloudyWing.FormValidators.MobilePhoneFormats')  
The formats.

<a name='CloudyWing.FormValidators.MobilePhoneValidator.HasCustomErrorMessage'></a>

## MobilePhoneValidator.HasCustomErrorMessage Property

Gets a value indicating whether this instance has custom error message.

```csharp
protected override bool HasCustomErrorMessage { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if this instance has custom error message; otherwise, `false`.

<a name='CloudyWing.FormValidators.MobilePhoneValidator.Pattern'></a>

## MobilePhoneValidator.Pattern Property

Gets the regex pattern.

```csharp
public string Pattern { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The regex pattern.
### Methods

<a name='CloudyWing.FormValidators.MobilePhoneValidator.ValidateValue()'></a>

## MobilePhoneValidator.ValidateValue() Method

Validates the value.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.