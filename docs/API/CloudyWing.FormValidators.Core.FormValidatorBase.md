#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators.Core](CloudyWing.FormValidators.Core.md 'CloudyWing.FormValidators.Core')

## FormValidatorBase Class

The form validator abstract class.

```csharp
public abstract class FormValidatorBase :
CloudyWing.FormValidators.IFormValidator
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FormValidatorBase

Derived  
&#8627; [CompareValidator](CloudyWing.FormValidators.CompareValidator.md 'CloudyWing.FormValidators.CompareValidator')  
&#8627; [ComparableTypeValidator&lt;T&gt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing.FormValidators.Core.ComparableTypeValidator<T>')  
&#8627; [IdCardValidator](CloudyWing.FormValidators.IdCardValidator.md 'CloudyWing.FormValidators.IdCardValidator')  
&#8627; [RegexValidator](CloudyWing.FormValidators.RegexValidator.md 'CloudyWing.FormValidators.RegexValidator')  
&#8627; [RequiredValidator](CloudyWing.FormValidators.RequiredValidator.md 'CloudyWing.FormValidators.RequiredValidator')  
&#8627; [ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator')

Implements [IFormValidator](CloudyWing.FormValidators.IFormValidator.md 'CloudyWing.FormValidators.IFormValidator')

### See Also
- [IFormValidator](CloudyWing.FormValidators.IFormValidator.md 'CloudyWing.FormValidators.IFormValidator')
### Constructors

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.FormValidatorBase(string,string,string)'></a>

## FormValidatorBase(string, string, string) Constructor

Initializes a new instance of the [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') class.

```csharp
public FormValidatorBase(string column, string value, string customMessageFormat);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.FormValidatorBase(string,string,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.FormValidatorBase(string,string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.FormValidatorBase(string,string,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.
### Properties

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.Column'></a>

## FormValidatorBase.Column Property

Gets or sets the column.

```csharp
public string Column { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The column.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.CustomErrorMessageFormat'></a>

## FormValidatorBase.CustomErrorMessageFormat Property

Gets or sets the custom error message format.

```csharp
public string CustomErrorMessageFormat { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The custom error message format.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.DefaultErrorMessageFormat'></a>

## FormValidatorBase.DefaultErrorMessageFormat Property

Gets the default error message format.

```csharp
public abstract string DefaultErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message format.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.ErrorMessage'></a>

## FormValidatorBase.ErrorMessage Property

Gets the error message.

```csharp
public string ErrorMessage { get; set; }
```

Implements [ErrorMessage](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.ErrorMessage 'CloudyWing.FormValidators.IFormValidator.ErrorMessage')

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.IsValid'></a>

## FormValidatorBase.IsValid Property

Returns true if ... is valid.

```csharp
public bool IsValid { get; set; }
```

Implements [IsValid](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.IsValid 'CloudyWing.FormValidators.IFormValidator.IsValid')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if this instance is valid; otherwise, `false`.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.Value'></a>

## FormValidatorBase.Value Property

Gets or sets the value.

```csharp
public string Value { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The value.
### Methods

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.CreateErrorMessage()'></a>

## FormValidatorBase.CreateErrorMessage() Method

Creates the error message.

```csharp
protected virtual string CreateErrorMessage();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.Validate()'></a>

## FormValidatorBase.Validate() Method

Validates this instance.

```csharp
public bool Validate();
```

Implements [Validate()](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.Validate() 'CloudyWing.FormValidators.IFormValidator.Validate()')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.ValidateValue()'></a>

## FormValidatorBase.ValidateValue() Method

Validates the value.

```csharp
protected abstract bool ValidateValue();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.