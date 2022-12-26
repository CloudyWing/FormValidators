#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators.Core](CloudyWing.FormValidators.Core.md 'CloudyWing.FormValidators.Core')

## ErrorMessageProvider Class

The error message provider

```csharp
public static class ErrorMessageProvider
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ErrorMessageProvider
### Properties

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueCompareAnotherColumnValueAccessor'></a>

## ErrorMessageProvider.ValueCompareAnotherColumnValueAccessor Property

Gets the value compare another column value accessor.

```csharp
public static System.Func<string,string,string,string,string> ValueCompareAnotherColumnValueAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')  
The value compare another column value accessor. The arguments are column, value, comparison column, comparison value.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueGreaterOrEqualAccessor'></a>

## ErrorMessageProvider.ValueGreaterOrEqualAccessor Property

Gets the value greater or equal accessor.

```csharp
public static System.Func<string,string,object,string> ValueGreaterOrEqualAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')  
The value greater or equal accessor. The agrumts are column, value, min, max.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueInRangeAccessor'></a>

## ErrorMessageProvider.ValueInRangeAccessor Property

Gets the value in range accessor.

```csharp
public static System.Func<string,string,object,object,string> ValueInRangeAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')  
The value in range accessor. The arguments are column, value, min, max.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueIsDateTimeAccessor'></a>

## ErrorMessageProvider.ValueIsDateTimeAccessor Property

Gets the value is date time accessor.

```csharp
public static System.Func<string,string,string> ValueIsDateTimeAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The value is date time accessor. The arguments are column, value.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueIsEmailAccessor'></a>

## ErrorMessageProvider.ValueIsEmailAccessor Property

Gets the value is email accessor.

```csharp
public static System.Func<string,string,string> ValueIsEmailAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The value is email accessor. The arguments are column, value.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueIsIdCardAccessor'></a>

## ErrorMessageProvider.ValueIsIdCardAccessor Property

Gets the value is identification card accessor.

```csharp
public static System.Func<string,string,CloudyWing.FormValidators.IdCardTypes,string> ValueIsIdCardAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[IdCardTypes](CloudyWing.FormValidators.IdCardTypes.md 'CloudyWing.FormValidators.IdCardTypes')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')  
The value is identification card accessor. The arguments are column, value, identification card types.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueIsIntegerAccessor'></a>

## ErrorMessageProvider.ValueIsIntegerAccessor Property

Gets the value is integer accessor.

```csharp
public static System.Func<string,string,string> ValueIsIntegerAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The value is integer accessor. The arguments are column, value.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueIsMobilePhoneAccessor'></a>

## ErrorMessageProvider.ValueIsMobilePhoneAccessor Property

Gets the value is mobile phone accessor.

```csharp
public static System.Func<string,string,CloudyWing.FormValidators.MobilePhoneFormats,string> ValueIsMobilePhoneAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[MobilePhoneFormats](CloudyWing.FormValidators.MobilePhoneFormats.md 'CloudyWing.FormValidators.MobilePhoneFormats')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')  
The value is mobile phone accessor. The arguments are column, value, mobile phone formats.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueIsNumberAccessor'></a>

## ErrorMessageProvider.ValueIsNumberAccessor Property

Gets the value is number accessor.

```csharp
public static System.Func<string,string,string> ValueIsNumberAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The value is number accessor. The arguments are column, value.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueIsRequiredAccessor'></a>

## ErrorMessageProvider.ValueIsRequiredAccessor Property

Gets the value is required accessor.

```csharp
public static System.Func<string,string,string> ValueIsRequiredAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The value is required accessor. The agrumts are column, value.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueLengthGreaterOrEqualAccessor'></a>

## ErrorMessageProvider.ValueLengthGreaterOrEqualAccessor Property

Gets the value length greater or equal accessor.

```csharp
public static System.Func<string,string,long,string> ValueLengthGreaterOrEqualAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')  
The value length greater or equal accessor. The arguments are column, value, min.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueLengthInRangeAccessor'></a>

## ErrorMessageProvider.ValueLengthInRangeAccessor Property

Gets the value length in range accessor.

```csharp
public static System.Func<string,string,long,long,string> ValueLengthInRangeAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')  
The value length in range accessor. The arguments are column, value, min, max.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueLengthLessOrEqualAccessor'></a>

## ErrorMessageProvider.ValueLengthLessOrEqualAccessor Property

Gets the value length less or equal accessor.

```csharp
public static System.Func<string,string,long,string> ValueLengthLessOrEqualAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')  
The value length less or equal accessor. The arguments are column, value, max.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueLessOrEqualAccessor'></a>

## ErrorMessageProvider.ValueLessOrEqualAccessor Property

Gets the value less or equal accessor.

```csharp
public static System.Func<string,string,object,string> ValueLessOrEqualAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')  
The value less or equal accessor. The arguments are column, value, max.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueLessThanAnotherColumnValueAccessor'></a>

## ErrorMessageProvider.ValueLessThanAnotherColumnValueAccessor Property

Gets the value less than another column value accessor.

```csharp
public static System.Func<string,string,string,string,bool,string> ValueLessThanAnotherColumnValueAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')  
The value less than another column value accessor. The arguments are column, value, comparison column, comparison value, allowed equal.

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.ValueMatchRegexAccessor'></a>

## ErrorMessageProvider.ValueMatchRegexAccessor Property

Gets the value match regex accessor.

```csharp
public static System.Func<string,string,string> ValueMatchRegexAccessor { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The value match regex accessor. The arguments are column, value.
### Methods

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueCompareAnotherColumnValueAccessor(System.Func_string,string,string,string,string_)'></a>

## ErrorMessageProvider.SetValueCompareAnotherColumnValueAccessor(Func<string,string,string,string,string>) Method

Sets the value compare another column value accessor.

```csharp
public static void SetValueCompareAnotherColumnValueAccessor(System.Func<string,string,string,string,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueCompareAnotherColumnValueAccessor(System.Func_string,string,string,string,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The accessor. The arguments are column, value, comparison column, comparison value.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueGreaterOrEqualAccessor(System.Func_string,string,object,string_)'></a>

## ErrorMessageProvider.SetValueGreaterOrEqualAccessor(Func<string,string,object,string>) Method

Sets the value greater or equal accessor.

```csharp
public static void SetValueGreaterOrEqualAccessor(System.Func<string,string,object,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueGreaterOrEqualAccessor(System.Func_string,string,object,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

The accessor. The arguments are column, value, min.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueInRangeAccessor(System.Func_string,string,object,object,string_)'></a>

## ErrorMessageProvider.SetValueInRangeAccessor(Func<string,string,object,object,string>) Method

Sets the value in range accessor.

```csharp
public static void SetValueInRangeAccessor(System.Func<string,string,object,object,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueInRangeAccessor(System.Func_string,string,object,object,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The accessor. The arguments are column, value, min, max.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsDateTimeAccessor(System.Func_string,string,string_)'></a>

## ErrorMessageProvider.SetValueIsDateTimeAccessor(Func<string,string,string>) Method

Sets the value is date time accessor.

```csharp
public static void SetValueIsDateTimeAccessor(System.Func<string,string,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsDateTimeAccessor(System.Func_string,string,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

The accessor. The arguments are column, value.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsEmailAccessor(System.Func_string,string,string_)'></a>

## ErrorMessageProvider.SetValueIsEmailAccessor(Func<string,string,string>) Method

Sets the value is email accessor.

```csharp
public static void SetValueIsEmailAccessor(System.Func<string,string,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsEmailAccessor(System.Func_string,string,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

The accessor. The arguments are column, value.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsIdCardAccessor(System.Func_string,string,CloudyWing.FormValidators.IdCardTypes,string_)'></a>

## ErrorMessageProvider.SetValueIsIdCardAccessor(Func<string,string,IdCardTypes,string>) Method

Sets the value is identification card accessor.

```csharp
public static void SetValueIsIdCardAccessor(System.Func<string,string,CloudyWing.FormValidators.IdCardTypes,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsIdCardAccessor(System.Func_string,string,CloudyWing.FormValidators.IdCardTypes,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[IdCardTypes](CloudyWing.FormValidators.IdCardTypes.md 'CloudyWing.FormValidators.IdCardTypes')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

The accessor. The arguments are column, value, identification card types.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsIntegerAccessor(System.Func_string,string,string_)'></a>

## ErrorMessageProvider.SetValueIsIntegerAccessor(Func<string,string,string>) Method

Sets the value is integer accessor.

```csharp
public static void SetValueIsIntegerAccessor(System.Func<string,string,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsIntegerAccessor(System.Func_string,string,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

The accessor. The arguments are column, value.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsMobilePhoneAccessor(System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_)'></a>

## ErrorMessageProvider.SetValueIsMobilePhoneAccessor(Func<string,string,MobilePhoneFormats,string>) Method

Sets the value is mobile phone accessor.

```csharp
public static void SetValueIsMobilePhoneAccessor(System.Func<string,string,CloudyWing.FormValidators.MobilePhoneFormats,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsMobilePhoneAccessor(System.Func_string,string,CloudyWing.FormValidators.MobilePhoneFormats,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[MobilePhoneFormats](CloudyWing.FormValidators.MobilePhoneFormats.md 'CloudyWing.FormValidators.MobilePhoneFormats')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

The accessor. The arguments are column, value, mobile phone formats.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsNumberAccessor(System.Func_string,string,string_)'></a>

## ErrorMessageProvider.SetValueIsNumberAccessor(Func<string,string,string>) Method

Sets the value is number accessor.

```csharp
public static void SetValueIsNumberAccessor(System.Func<string,string,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsNumberAccessor(System.Func_string,string,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

The accessor. The arguments are column, value.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsRequiredAccessor(System.Func_string,string,string_)'></a>

## ErrorMessageProvider.SetValueIsRequiredAccessor(Func<string,string,string>) Method

Sets the value is required accessor.

```csharp
public static void SetValueIsRequiredAccessor(System.Func<string,string,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueIsRequiredAccessor(System.Func_string,string,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

The accessor. The arguments are column, value.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueLengthGreaterOrEqualAccessor(System.Func_string,string,long,string_)'></a>

## ErrorMessageProvider.SetValueLengthGreaterOrEqualAccessor(Func<string,string,long,string>) Method

Sets the value length greater or equal accessor.

```csharp
public static void SetValueLengthGreaterOrEqualAccessor(System.Func<string,string,long,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueLengthGreaterOrEqualAccessor(System.Func_string,string,long,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

The accessor. The arguments are column, value, min.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueLengthInRangeAccessor(System.Func_string,string,long,long,string_)'></a>

## ErrorMessageProvider.SetValueLengthInRangeAccessor(Func<string,string,long,long,string>) Method

Sets the value length in range accessor.

```csharp
public static void SetValueLengthInRangeAccessor(System.Func<string,string,long,long,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueLengthInRangeAccessor(System.Func_string,string,long,long,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The accessor. The arguments are column, value, min, max.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueLengthLessOrEqualAccessor(System.Func_string,string,long,string_)'></a>

## ErrorMessageProvider.SetValueLengthLessOrEqualAccessor(Func<string,string,long,string>) Method

Sets the value length less or equal accessor.

```csharp
public static void SetValueLengthLessOrEqualAccessor(System.Func<string,string,long,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueLengthLessOrEqualAccessor(System.Func_string,string,long,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

The accessor. The arguments are column, value, max.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueLessOrEqualAccessor(System.Func_string,string,object,string_)'></a>

## ErrorMessageProvider.SetValueLessOrEqualAccessor(Func<string,string,object,string>) Method

Sets the value less or equal accessor.

```csharp
public static void SetValueLessOrEqualAccessor(System.Func<string,string,object,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueLessOrEqualAccessor(System.Func_string,string,object,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

The accessor. The arguments are column, value, max.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueLessThanAnotherColumnValueAccessor(System.Func_string,string,string,string,bool,string_)'></a>

## ErrorMessageProvider.SetValueLessThanAnotherColumnValueAccessor(Func<string,string,string,string,bool,string>) Method

Sets the value less than another column value accessor.

```csharp
public static void SetValueLessThanAnotherColumnValueAccessor(System.Func<string,string,string,string,bool,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueLessThanAnotherColumnValueAccessor(System.Func_string,string,string,string,bool,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-6 'System.Func`6')

The accessor. The arguments are column, value, comparison column, comparison value, allowed equal.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueMatchRegexAccessor(System.Func_string,string,string_)'></a>

## ErrorMessageProvider.SetValueMatchRegexAccessor(Func<string,string,string>) Method

Sets the value match regex accessor.

```csharp
public static void SetValueMatchRegexAccessor(System.Func<string,string,string> accessor);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ErrorMessageProvider.SetValueMatchRegexAccessor(System.Func_string,string,string_).accessor'></a>

`accessor` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

The accessor. The arguments are column, value.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
accessor