#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators.Core](CloudyWing.FormValidators.Core.md 'CloudyWing.FormValidators.Core')

## BasicFormValidator Class

The basic form validator abstract class.

```csharp
public abstract class BasicFormValidator : CloudyWing.FormValidators.Core.FormValidatorBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; BasicFormValidator

Derived  
&#8627; [RegexValidator](CloudyWing.FormValidators.RegexValidator.md 'CloudyWing.FormValidators.RegexValidator')  
&#8627; [RequiredValidator](CloudyWing.FormValidators.RequiredValidator.md 'CloudyWing.FormValidators.RequiredValidator')

### See Also
- [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase')
### Constructors

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.BasicFormValidator(string,string,System.Func_string,string,string_)'></a>

## BasicFormValidator(string, string, Func<string,string,string>) Constructor

Initializes a new instance of the [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') class.

```csharp
public BasicFormValidator(string column, string value, System.Func<string,string,string> customErrorMessageAccessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.BasicFormValidator(string,string,System.Func_string,string,string_).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.BasicFormValidator(string,string,System.Func_string,string,string_).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.BasicFormValidator(string,string,System.Func_string,string,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

The custom error message accessor. The agrumts are column, value.
### Properties

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.CustomErrorMessage'></a>

## BasicFormValidator.CustomErrorMessage Property

Gets the custom error message.

```csharp
protected override string CustomErrorMessage { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The custom error message.

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.CustomErrorMessageAccessor'></a>

## BasicFormValidator.CustomErrorMessageAccessor Property

Gets or sets the custom error message accessor.

```csharp
public System.Func<string,string,string> CustomErrorMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The custom error message accessor.

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.DefaultErrorMessage'></a>

## BasicFormValidator.DefaultErrorMessage Property

Gets the default error message.

```csharp
protected override string DefaultErrorMessage { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message.

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.DefaultErrorMessageAccessor'></a>

## BasicFormValidator.DefaultErrorMessageAccessor Property

Gets the get default error message.

```csharp
protected abstract System.Func<string,string,string> DefaultErrorMessageAccessor { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The get default error message.

<a name='CloudyWing.FormValidators.Core.BasicFormValidator.HasCustomErrorMessage'></a>

## BasicFormValidator.HasCustomErrorMessage Property

Gets a value indicating whether this instance has custom error message.

```csharp
protected override bool HasCustomErrorMessage { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if this instance has custom error message; otherwise, `false`.