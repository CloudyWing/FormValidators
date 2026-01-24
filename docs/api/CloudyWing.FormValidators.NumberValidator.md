#### [CloudyWing\.FormValidators](index.md 'index')
### [CloudyWing\.FormValidators](CloudyWing.FormValidators.md 'CloudyWing\.FormValidators')

## NumberValidator Class

Validation constrains the number format of a value\.

```csharp
public sealed class NumberValidator : CloudyWing.FormValidators.Core.ComparableTypeValidator<decimal>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') &#129106; [CloudyWing\.FormValidators\.Core\.ComparableTypeValidator&lt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing\.FormValidators\.Core\.ComparableTypeValidator\<T\>')[System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')[&gt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing\.FormValidators\.Core\.ComparableTypeValidator\<T\>') &#129106; NumberValidator
### Constructors

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_)'></a>

## NumberValidator\(string, string, bool, Func\<string,string,Nullable\<decimal\>,Nullable\<decimal\>,string\>\) Constructor

Initializes a new instance of the [NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing\.FormValidators\.NumberValidator') class\.

```csharp
public NumberValidator(string column, string value, bool allowedThousands=false, System.Func<string,string,System.Nullable<decimal>,System.Nullable<decimal>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).allowedThousands'></a>

`allowedThousands` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

if set to `true` \[allowed thousands\]\.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')

The custom error message accessor\. The agrumts are column, value, min, max\.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_)'></a>

## NumberValidator\(string, string, Nullable\<decimal\>, Nullable\<decimal\>, bool, Func\<string,string,Nullable\<decimal\>,Nullable\<decimal\>,string\>\) Constructor

Initializes a new instance of the [NumberValidator](CloudyWing.FormValidators.NumberValidator.md 'CloudyWing\.FormValidators\.NumberValidator') class\.

```csharp
public NumberValidator(string column, string value, System.Nullable<decimal> min, System.Nullable<decimal> max, bool allowedThousands=false, System.Func<string,string,System.Nullable<decimal>,System.Nullable<decimal>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).min'></a>

`min` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The minimum\.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).max'></a>

`max` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The maximum\.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).allowedThousands'></a>

`allowedThousands` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

if set to `true` \[allowed thousands\]\.

<a name='CloudyWing.FormValidators.NumberValidator.NumberValidator(string,string,System.Nullable_decimal_,System.Nullable_decimal_,bool,System.Func_string,string,System.Nullable_decimal_,System.Nullable_decimal_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')

The custom error message accessor\.
### Properties

<a name='CloudyWing.FormValidators.NumberValidator.AllowedThousands'></a>

## NumberValidator\.AllowedThousands Property

Gets a value indicating whether \[allowed thousands\]\.

```csharp
public bool AllowedThousands { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if \[allowed thousands\]; otherwise, `false`\.

<a name='CloudyWing.FormValidators.NumberValidator.CastErrorMessageAccessor'></a>

## NumberValidator\.CastErrorMessageAccessor Property

Gets the cast error message accessor\.

```csharp
protected override System.Func<string,string,string> CastErrorMessageAccessor { protected get; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')  
The cast error message accessor\.