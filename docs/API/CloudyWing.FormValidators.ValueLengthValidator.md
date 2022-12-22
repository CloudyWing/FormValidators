#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators](CloudyWing.FormValidators.md 'CloudyWing.FormValidators')

## ValueLengthValidator Class

The value length validator.

```csharp
public sealed class ValueLengthValidator : CloudyWing.FormValidators.Core.FormValidatorBase
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase') &#129106; ValueLengthValidator

### See Also
- [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing.FormValidators.Core.FormValidatorBase')
### Constructors

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,int,int,string)'></a>

## ValueLengthValidator(string, string, int, int, string) Constructor

Initializes a new instance of the [ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator') class.

```csharp
public ValueLengthValidator(string column, string value, int min, int max, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,int,int,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,int,int,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,int,int,string).min'></a>

`min` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The minimum.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,int,int,string).max'></a>

`max` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The maximum.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,int,int,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,int,string)'></a>

## ValueLengthValidator(string, string, int, string) Constructor

Initializes a new instance of the [ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator') class.

```csharp
public ValueLengthValidator(string column, string value, int max, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,int,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,int,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,int,string).max'></a>

`max` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The maximum.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValueLengthValidator(string,string,int,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.
### Properties

<a name='CloudyWing.FormValidators.ValueLengthValidator.DefaultErrorMessageFormat'></a>

## ValueLengthValidator.DefaultErrorMessageFormat Property

Gets the default error message format.

```csharp
public override string DefaultErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The default error message format.

<a name='CloudyWing.FormValidators.ValueLengthValidator.MaxLength'></a>

## ValueLengthValidator.MaxLength Property

Gets the maximum length.

```csharp
public int MaxLength { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The maximum length.

<a name='CloudyWing.FormValidators.ValueLengthValidator.MaxLengthErrorMessageFormat'></a>

## ValueLengthValidator.MaxLengthErrorMessageFormat Property

Gets the maximum length error message format.

```csharp
public string MaxLengthErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The maximum length error message format.

<a name='CloudyWing.FormValidators.ValueLengthValidator.MinLength'></a>

## ValueLengthValidator.MinLength Property

Gets the minimum length.

```csharp
public int MinLength { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The minimum length.

<a name='CloudyWing.FormValidators.ValueLengthValidator.MinLengthErrorMessageFormat'></a>

## ValueLengthValidator.MinLengthErrorMessageFormat Property

Gets the minimum length error message format.

```csharp
public string MinLengthErrorMessageFormat { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The minimum length error message format.
### Methods

<a name='CloudyWing.FormValidators.ValueLengthValidator.CreateErrorMessage()'></a>

## ValueLengthValidator.CreateErrorMessage() Method

Creates the error message.

```csharp
protected override string CreateErrorMessage();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.

<a name='CloudyWing.FormValidators.ValueLengthValidator.CreateMaxLength(string,string,int,string)'></a>

## ValueLengthValidator.CreateMaxLength(string, string, int, string) Method

Creates the maximum length validator.

```csharp
public static CloudyWing.FormValidators.ValueLengthValidator CreateMaxLength(string column, string value, int max, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.ValueLengthValidator.CreateMaxLength(string,string,int,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.ValueLengthValidator.CreateMaxLength(string,string,int,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.ValueLengthValidator.CreateMaxLength(string,string,int,string).max'></a>

`max` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The maximum.

<a name='CloudyWing.FormValidators.ValueLengthValidator.CreateMaxLength(string,string,int,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator')  
The maximum length validator.

<a name='CloudyWing.FormValidators.ValueLengthValidator.CreateMinLength(string,string,int,string)'></a>

## ValueLengthValidator.CreateMinLength(string, string, int, string) Method

Creates the minimum length validator.

```csharp
public static CloudyWing.FormValidators.ValueLengthValidator CreateMinLength(string column, string value, int min, string customMessageFormat=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.ValueLengthValidator.CreateMinLength(string,string,int,string).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.ValueLengthValidator.CreateMinLength(string,string,int,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.ValueLengthValidator.CreateMinLength(string,string,int,string).min'></a>

`min` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The minimum.

<a name='CloudyWing.FormValidators.ValueLengthValidator.CreateMinLength(string,string,int,string).customMessageFormat'></a>

`customMessageFormat` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The custom message format.

#### Returns
[ValueLengthValidator](CloudyWing.FormValidators.ValueLengthValidator.md 'CloudyWing.FormValidators.ValueLengthValidator')  
The minimum length validator.

<a name='CloudyWing.FormValidators.ValueLengthValidator.ValidateValue()'></a>

## ValueLengthValidator.ValidateValue() Method

Validates the value.

```csharp
protected override bool ValidateValue();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The validation result.