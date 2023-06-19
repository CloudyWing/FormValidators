#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## TrueAssertValidator Class

The true assert validator.

```csharp
public class TrueAssertValidator :
CloudyWing.FormValidators.IFormValidator
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TrueAssertValidator

Implements [IFormValidator](CloudyWing.FormValidators.IFormValidator.md 'CloudyWing.FormValidators.IFormValidator')
### Constructors

<a name='CloudyWing.FormValidators.TrueAssertValidator.TrueAssertValidator(bool,string)'></a>

## TrueAssertValidator(bool, string) Constructor

Initializes a new instance of the [TrueAssertValidator](CloudyWing.FormValidators.TrueAssertValidator.md 'CloudyWing.FormValidators.TrueAssertValidator') class.

```csharp
public TrueAssertValidator(bool isTrue, string errorMessage);
```
#### Parameters

<a name='CloudyWing.FormValidators.TrueAssertValidator.TrueAssertValidator(bool,string).isTrue'></a>

`isTrue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is true].

<a name='CloudyWing.FormValidators.TrueAssertValidator.TrueAssertValidator(bool,string).errorMessage'></a>

`errorMessage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The error message.

<a name='CloudyWing.FormValidators.TrueAssertValidator.TrueAssertValidator(System.Func_bool_,string)'></a>

## TrueAssertValidator(Func<bool>, string) Constructor

Initializes a new instance of the [TrueAssertValidator](CloudyWing.FormValidators.TrueAssertValidator.md 'CloudyWing.FormValidators.TrueAssertValidator') class.

```csharp
public TrueAssertValidator(System.Func<bool> truePredicate, string errorMessage);
```
#### Parameters

<a name='CloudyWing.FormValidators.TrueAssertValidator.TrueAssertValidator(System.Func_bool_,string).truePredicate'></a>

`truePredicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The true predicate.

<a name='CloudyWing.FormValidators.TrueAssertValidator.TrueAssertValidator(System.Func_bool_,string).errorMessage'></a>

`errorMessage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The error message.
### Properties

<a name='CloudyWing.FormValidators.TrueAssertValidator.ErrorMessage'></a>

## TrueAssertValidator.ErrorMessage Property

Gets the error message.

```csharp
public string ErrorMessage { get; set; }
```

Implements [ErrorMessage](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.ErrorMessage 'CloudyWing.FormValidators.IFormValidator.ErrorMessage')

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.

<a name='CloudyWing.FormValidators.TrueAssertValidator.IsValid'></a>

## TrueAssertValidator.IsValid Property

Returns true if ... is valid.

```csharp
public bool IsValid { get; set; }
```

Implements [IsValid](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.IsValid 'CloudyWing.FormValidators.IFormValidator.IsValid')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if this instance is valid; otherwise, `false`.
### Methods

<a name='CloudyWing.FormValidators.TrueAssertValidator.Validate()'></a>

## TrueAssertValidator.Validate() Method

Validates this instance.

```csharp
public bool Validate();
```

Implements [Validate()](CloudyWing.FormValidators.IFormValidator.md#CloudyWing.FormValidators.IFormValidator.Validate() 'CloudyWing.FormValidators.IFormValidator.Validate()')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.