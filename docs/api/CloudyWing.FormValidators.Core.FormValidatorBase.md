#### [CloudyWing\.FormValidators](index.md 'index')
### [CloudyWing\.FormValidators\.Core](CloudyWing.FormValidators.Core.md 'CloudyWing\.FormValidators\.Core')

## FormValidatorBase Class

The form validator base abstract class\.

```csharp
public abstract class FormValidatorBase : CloudyWing.FormValidators.IFormValidator
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; FormValidatorBase

Derived  
&#8627; [CompareValidator](CloudyWing.FormValidators.CompareValidator.md 'CloudyWing\.FormValidators\.CompareValidator')  
&#8627; [BasicFormValidator](CloudyWing.FormValidators.Core.BasicFormValidator.md 'CloudyWing\.FormValidators\.Core\.BasicFormValidator')  
&#8627; [ComparableTypeValidator&lt;T&gt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing\.FormValidators\.Core\.ComparableTypeValidator\<T\>')  
&#8627; [LessThanValidator&lt;T&gt;](CloudyWing.FormValidators.Core.LessThanValidator_T_.md 'CloudyWing\.FormValidators\.Core\.LessThanValidator\<T\>')  
&#8627; [IdCardValidator](CloudyWing.FormValidators.IdCardValidator.md 'CloudyWing\.FormValidators\.IdCardValidator')  
&#8627; [MobilePhoneValidator](CloudyWing.FormValidators.MobilePhoneValidator.md 'CloudyWing\.FormValidators\.MobilePhoneValidator')  
&#8627; [ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing\.FormValidators\.ValueLengthValidator')

Implements [IFormValidator](CloudyWing.FormValidators.IFormValidator.md 'CloudyWing\.FormValidators\.IFormValidator')

### See Also
- [IFormValidator](CloudyWing.FormValidators.IFormValidator.md 'CloudyWing\.FormValidators\.IFormValidator')
### Constructors

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.FormValidatorBase(string,string)'></a>

## FormValidatorBase\(string, string\) Constructor

Initializes a new instance of the [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') class\.

```csharp
public FormValidatorBase(string column, string value);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.FormValidatorBase(string,string).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.FormValidatorBase(string,string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.
### Properties

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.Column'></a>

## FormValidatorBase\.Column Property

Gets or sets the column\.

```csharp
public string Column { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The column\.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.CustomErrorMessage'></a>

## FormValidatorBase\.CustomErrorMessage Property

Gets the custom error message\.

```csharp
protected abstract string CustomErrorMessage { protected get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The custom error message\.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.DefaultErrorMessage'></a>

## FormValidatorBase\.DefaultErrorMessage Property

Gets the default error message\.

```csharp
protected abstract string DefaultErrorMessage { protected get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The default error message\.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.ErrorMessage'></a>

## FormValidatorBase\.ErrorMessage Property

Gets the error message\.

```csharp
public string ErrorMessage { get; private set; }
```

Implements [ErrorMessage](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.ErrorMessage 'CloudyWing\.FormValidators\.IFormValidator\.ErrorMessage')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The error message\.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.HasCustomErrorMessage'></a>

## FormValidatorBase\.HasCustomErrorMessage Property

Gets a value indicating whether this instance has custom error message\.

```csharp
protected abstract bool HasCustomErrorMessage { protected get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if this instance has custom error message; otherwise, `false`\.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.IsValid'></a>

## FormValidatorBase\.IsValid Property

Returns true if \.\.\. is valid\.

```csharp
public bool IsValid { get; private set; }
```

Implements [IsValid](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.IsValid 'CloudyWing\.FormValidators\.IFormValidator\.IsValid')

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if this instance is valid; otherwise, `false`\.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.Value'></a>

## FormValidatorBase\.Value Property

Gets or sets the value\.

```csharp
public string Value { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The value\.
### Methods

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.CreateErrorMessage()'></a>

## FormValidatorBase\.CreateErrorMessage\(\) Method

Creates the error message\.

```csharp
protected virtual string CreateErrorMessage();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The error message\.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.Validate()'></a>

## FormValidatorBase\.Validate\(\) Method

Validates this instance\.

```csharp
public bool Validate();
```

Implements [Validate\(\)](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.Validate() 'CloudyWing\.FormValidators\.IFormValidator\.Validate\(\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
The validation result\.

<a name='CloudyWing.FormValidators.Core.FormValidatorBase.ValidateValue()'></a>

## FormValidatorBase\.ValidateValue\(\) Method

Validates the value\.

```csharp
protected abstract bool ValidateValue();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
The validation result\.