#### [CloudyWing\.FormValidators](index.md 'index')
### [CloudyWing\.FormValidators](CloudyWing.FormValidators.md 'CloudyWing\.FormValidators')

## IntegerValidator Class

Validation constrains the integer format of a value\.

```csharp
public sealed class IntegerValidator : CloudyWing.FormValidators.Core.ComparableTypeValidator<long>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [FormValidatorBase](CloudyWing.FormValidators.Core.FormValidatorBase.md 'CloudyWing\.FormValidators\.Core\.FormValidatorBase') &#129106; [CloudyWing\.FormValidators\.Core\.ComparableTypeValidator&lt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing\.FormValidators\.Core\.ComparableTypeValidator\<T\>')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](CloudyWing.FormValidators.Core.ComparableTypeValidator_T_.md 'CloudyWing\.FormValidators\.Core\.ComparableTypeValidator\<T\>') &#129106; IntegerValidator
### Constructors

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_)'></a>

## IntegerValidator\(string, string, bool, Func\<string,string,Nullable\<long\>,Nullable\<long\>,string\>\) Constructor

Initializes a new instance of the [IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing\.FormValidators\.IntegerValidator') class\.

```csharp
public IntegerValidator(string column, string value, bool allowedThousands=false, System.Func<string,string,System.Nullable<long>,System.Nullable<long>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).allowedThousands'></a>

`allowedThousands` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')

The custom error message accessor\. The agrumts are column, value, min, max\.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_)'></a>

## IntegerValidator\(string, string, Nullable\<long\>, Nullable\<long\>, bool, Func\<string,string,Nullable\<long\>,Nullable\<long\>,string\>\) Constructor

Initializes a new instance of the [IntegerValidator](CloudyWing.FormValidators.IntegerValidator.md 'CloudyWing\.FormValidators\.IntegerValidator') class\.

```csharp
public IntegerValidator(string column, string value, System.Nullable<long> min, System.Nullable<long> max, bool allowedThousands=false, System.Func<string,string,System.Nullable<long>,System.Nullable<long>,string> customErrorMessageAccessor=null);
```
#### Parameters

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).column'></a>

`column` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The column\.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value\.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).min'></a>

`min` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The minimum\.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).max'></a>

`max` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The maximum\.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).allowedThousands'></a>

`allowedThousands` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

if set to `true` \[allowed thousands\]\.

<a name='CloudyWing.FormValidators.IntegerValidator.IntegerValidator(string,string,System.Nullable_long_,System.Nullable_long_,bool,System.Func_string,string,System.Nullable_long_,System.Nullable_long_,string_).customErrorMessageAccessor'></a>

`customErrorMessageAccessor` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-5 'System\.Func\`5')

The custom error message accessor\.
### Properties

<a name='CloudyWing.FormValidators.IntegerValidator.AllowedThousands'></a>

## IntegerValidator\.AllowedThousands Property

Gets a value indicating whether \[allowed thousands\]\.

```csharp
public bool AllowedThousands { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if \[allowed thousands\]; otherwise, `false`\.

<a name='CloudyWing.FormValidators.IntegerValidator.CastErrorMessageAccessor'></a>

## IntegerValidator\.CastErrorMessageAccessor Property

Gets the cast error message accessor\.

```csharp
protected override System.Func<string,string,string> CastErrorMessageAccessor { protected get; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')  
The cast error message accessor\.