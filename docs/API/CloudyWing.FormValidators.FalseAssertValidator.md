#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## FalseAssertValidator Class

The false assert validator.

```csharp
public class FalseAssertValidator :
CloudyWing.FormValidators.IFormValidator
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FalseAssertValidator

Implements [IFormValidator](CloudyWing.FormValidators.IFormValidator.md 'CloudyWing.FormValidators.IFormValidator')
### Constructors

<a name='CloudyWing.FormValidators.FalseAssertValidator.FalseAssertValidator(bool,string)'></a>

## FalseAssertValidator(bool, string) Constructor

Initializes a new instance of the [FalseAssertValidator](CloudyWing.FormValidators.FalseAssertValidator.md 'CloudyWing.FormValidators.FalseAssertValidator') class.

```csharp
public FalseAssertValidator(bool isFalse, string errorMessage);
```
#### Parameters

<a name='CloudyWing.FormValidators.FalseAssertValidator.FalseAssertValidator(bool,string).isFalse'></a>

`isFalse` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is false].

<a name='CloudyWing.FormValidators.FalseAssertValidator.FalseAssertValidator(bool,string).errorMessage'></a>

`errorMessage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The error message.

<a name='CloudyWing.FormValidators.FalseAssertValidator.FalseAssertValidator(System.Func_bool_,string)'></a>

## FalseAssertValidator(Func<bool>, string) Constructor

Initializes a new instance of the [FalseAssertValidator](CloudyWing.FormValidators.FalseAssertValidator.md 'CloudyWing.FormValidators.FalseAssertValidator') class.

```csharp
public FalseAssertValidator(System.Func<bool> falsePredicate, string errorMessage);
```
#### Parameters

<a name='CloudyWing.FormValidators.FalseAssertValidator.FalseAssertValidator(System.Func_bool_,string).falsePredicate'></a>

`falsePredicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The false predicate.

<a name='CloudyWing.FormValidators.FalseAssertValidator.FalseAssertValidator(System.Func_bool_,string).errorMessage'></a>

`errorMessage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The error message.
### Properties

<a name='CloudyWing.FormValidators.FalseAssertValidator.ErrorMessage'></a>

## FalseAssertValidator.ErrorMessage Property

Gets the error message.

```csharp
public string ErrorMessage { get; set; }
```

Implements [ErrorMessage](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.ErrorMessage 'CloudyWing.FormValidators.IFormValidator.ErrorMessage')

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.

<a name='CloudyWing.FormValidators.FalseAssertValidator.IsValid'></a>

## FalseAssertValidator.IsValid Property

Returns true if ... is valid.

```csharp
public bool IsValid { get; set; }
```

Implements [IsValid](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.IsValid 'CloudyWing.FormValidators.IFormValidator.IsValid')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if this instance is valid; otherwise, `false`.
### Methods

<a name='CloudyWing.FormValidators.FalseAssertValidator.Validate()'></a>

## FalseAssertValidator.Validate() Method

Validates this instance.

```csharp
public bool Validate();
```

Implements [Validate()](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.Validate() 'CloudyWing.FormValidators.IFormValidator.Validate()')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.