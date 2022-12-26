#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## RegexValidator Class

The regex validator.

```csharp
public class RegexValidator : CloudyWing.FormValidators.Core.BasicFormValidator
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; [BasicFormValidator](CloudyWing.FormValidators.Core.BasicFormValidator.md 'CloudyWing.FormValidators.Core.BasicFormValidator') &#129106; RegexValidator

Derived  
&#8627; [EmailValidator](CloudyWing.FormValidators.EmailValidator.md 'CloudyWing.FormValidators.EmailValidator')
### Constructors

<a name='CloudyWing.FormValidators.RegexValidator.RegexValidator(string,string,string,System.Func_string,string,string_)'></a>

## RegexValidator(string, string, string, Func<string,string,string>) Constructor

Initializes a new instance of the [RegexValidator](CloudyWing.FormValidators.RegexValidator.md 'CloudyWing.FormValidators.RegexValidator') class.

```csharp
public RegexValidator(string column, string value, string pattern, System.Func<string,string,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.RegexValidator.RegexValidator(string,string,string,System.Func_string,string,string_).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.RegexValidator.RegexValidator(string,string,string,System.Func_string,string,string_).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.RegexValidator.RegexValidator(string,string,string,System.Func_string,string,string_).pattern'></a>

`pattern` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The pattern.

<a name='CloudyWing.FormValidators.RegexValidator.RegexValidator(string,string,string,System.Func_string,string,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

The custom error message accessor. The agrumts are column, value.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
pattern
### Properties

<a name='CloudyWing.FormValidators.RegexValidator.DefaultErrorMessageAccessor'></a>

## RegexValidator.DefaultErrorMessageAccessor Property

Gets the get default error message.

```csharp
protected override System.Func<string,string,string> DefaultErrorMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The get default error message.

<a name='CloudyWing.FormValidators.RegexValidator.Pattern'></a>

## RegexValidator.Pattern Property

Gets the pattern.

```csharp
public string Pattern { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The pattern.
### Methods

<a name='CloudyWing.FormValidators.RegexValidator.ValidateValue()'></a>

## RegexValidator.ValidateValue() Method

Validates the value.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.