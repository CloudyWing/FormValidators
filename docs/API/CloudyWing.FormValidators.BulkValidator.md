#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## BulkValidator Class

The bulk validator.

```csharp
public class BulkValidator : System.Collections.ObjectModel.Collection<CloudyWing.FormValidators.IFormValidator>,
CloudyWing.FormValidators.IFormValidator
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Collections.ObjectModel.Collection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.Collection-1 'System.Collections.ObjectModel.Collection`1')[IFormValidator](CloudyWing.FormValidators.IFormValidator.md 'CloudyWing.FormValidators.IFormValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.Collection-1 'System.Collections.ObjectModel.Collection`1') &#129106; BulkValidator

Implements [IFormValidator](CloudyWing.FormValidators.IFormValidator.md 'CloudyWing.FormValidators.IFormValidator')
### Constructors

<a name='CloudyWing.FormValidators.BulkValidator.BulkValidator(bool)'></a>

## BulkValidator(bool) Constructor

Initializes a new instance of the [BulkValidator](CloudyWing.FormValidators.BulkValidator.md 'CloudyWing.FormValidators.BulkValidator') class.

```csharp
public BulkValidator(bool isStoppedIfFail=false);
```
#### Parameters

<a name='CloudyWing.FormValidators.BulkValidator.BulkValidator(bool).isStoppedIfFail'></a>

`isStoppedIfFail` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is stopped if fail].

<a name='CloudyWing.FormValidators.BulkValidator.BulkValidator(System.Action_CloudyWing.FormValidators.Core.ValidatorConfiguration_,bool)'></a>

## BulkValidator(Action<ValidatorConfiguration>, bool) Constructor

Initializes a new instance of the [BulkValidator](CloudyWing.FormValidators.BulkValidator.md 'CloudyWing.FormValidators.BulkValidator') class.

```csharp
public BulkValidator(System.Action<CloudyWing.FormValidators.Core.ValidatorConfiguration> configure, bool isStoppedIfFail=false);
```
#### Parameters

<a name='CloudyWing.FormValidators.BulkValidator.BulkValidator(System.Action_CloudyWing.FormValidators.Core.ValidatorConfiguration_,bool).configure'></a>

`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[ValidatorConfiguration](CloudyWing.FormValidators.Core.ValidatorConfiguration.md 'CloudyWing.FormValidators.Core.ValidatorConfiguration')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The configure.

<a name='CloudyWing.FormValidators.BulkValidator.BulkValidator(System.Action_CloudyWing.FormValidators.Core.ValidatorConfiguration_,bool).isStoppedIfFail'></a>

`isStoppedIfFail` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is stopped if fail].
### Properties

<a name='CloudyWing.FormValidators.BulkValidator.ErrorMessage'></a>

## BulkValidator.ErrorMessage Property

Gets the error message, separated by br.

```csharp
public string ErrorMessage { get; }
```

Implements [ErrorMessage](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.ErrorMessage 'CloudyWing.FormValidators.IFormValidator.ErrorMessage')

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.

<a name='CloudyWing.FormValidators.BulkValidator.ErrorMessages'></a>

## BulkValidator.ErrorMessages Property

Gets the error messages.

```csharp
public System.Collections.Generic.IReadOnlyCollection<string> ErrorMessages { get; }
```

#### Property Value
[System.Collections.Generic.IReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')  
The error messages.

<a name='CloudyWing.FormValidators.BulkValidator.ErrorMessageWithBreak'></a>

## BulkValidator.ErrorMessageWithBreak Property

Gets the error message, separated by br.

```csharp
public string ErrorMessageWithBreak { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message separated by br.

<a name='CloudyWing.FormValidators.BulkValidator.ErrorMessageWithLF'></a>

## BulkValidator.ErrorMessageWithLF Property

Gets the error message, separated by `\n`.

```csharp
public string ErrorMessageWithLF { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message separated by `\n`.

<a name='CloudyWing.FormValidators.BulkValidator.ErrorMessageWithNewLine'></a>

## BulkValidator.ErrorMessageWithNewLine Property

Gets the error message, separated by newlines.

```csharp
public string ErrorMessageWithNewLine { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message separated by new line.

<a name='CloudyWing.FormValidators.BulkValidator.IsStoppedIfFail'></a>

## BulkValidator.IsStoppedIfFail Property

Gets a value indicating whether this instance is stopped if fail.

```csharp
public bool IsStoppedIfFail { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if this instance is stopped if fail; otherwise, `false`.

<a name='CloudyWing.FormValidators.BulkValidator.IsValid'></a>

## BulkValidator.IsValid Property

Returns true if ... is valid.

```csharp
public bool IsValid { get; set; }
```

Implements [IsValid](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.IsValid 'CloudyWing.FormValidators.IFormValidator.IsValid')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if this instance is valid; otherwise, `false`.
### Methods

<a name='CloudyWing.FormValidators.BulkValidator.Validate()'></a>

## BulkValidator.Validate() Method

Validates this instance.

```csharp
public bool Validate();
```

Implements [Validate()](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.Validate() 'CloudyWing.FormValidators.IFormValidator.Validate()')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.