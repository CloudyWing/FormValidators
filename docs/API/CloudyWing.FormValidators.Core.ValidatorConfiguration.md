#### [CloudyWing.FormValidators](index.md 'index')
### [CloudyWing.FormValidators.Core](CloudyWing.FormValidators.Core.md 'CloudyWing.FormValidators.Core')

## ValidatorConfiguration Class

The validator configuration.

```csharp
public class ValidatorConfiguration
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ValidatorConfiguration
### Constructors

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.ValidatorConfiguration(CloudyWing.FormValidators.BulkValidator)'></a>

## ValidatorConfiguration(BulkValidator) Constructor

Initializes a new instance of the [ValidatorConfiguration](CloudyWing.FormValidators.Core.ValidatorConfiguration.md 'CloudyWing.FormValidators.Core.ValidatorConfiguration') class.

```csharp
public ValidatorConfiguration(CloudyWing.FormValidators.BulkValidator validators);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.ValidatorConfiguration(CloudyWing.FormValidators.BulkValidator).validators'></a>

`validators` [BulkValidator](CloudyWing.FormValidators.BulkValidator.md 'CloudyWing.FormValidators.BulkValidator')

The validators.
### Methods

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.Add(string,string,System.Collections.Generic.IEnumerable_System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator___)'></a>

## ValidatorConfiguration.Add(string, string, IEnumerable<Func<ValidationProvider,Func<string,string,IFormValidator>>>) Method

Adds the validators.

```csharp
public void Add(string column, string value, System.Collections.Generic.IEnumerable<System.Func<CloudyWing.FormValidators.Core.ValidationProvider,System.Func<string,string,CloudyWing.FormValidators.IFormValidator>>> validatorCreators);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.Add(string,string,System.Collections.Generic.IEnumerable_System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator___).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.Add(string,string,System.Collections.Generic.IEnumerable_System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator___).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.Add(string,string,System.Collections.Generic.IEnumerable_System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator___).validatorCreators'></a>

`validatorCreators` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[ValidationProvider](CloudyWing.FormValidators.Core.ValidationProvider.md 'CloudyWing.FormValidators.Core.ValidationProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IFormValidator](CloudyWing.FormValidators.IFormValidator.md 'CloudyWing.FormValidators.IFormValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The validator creators.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.Add(string,string,System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator__[])'></a>

## ValidatorConfiguration.Add(string, string, Func<ValidationProvider,Func<string,string,IFormValidator>>[]) Method

Adds the validators.

```csharp
public void Add(string column, string value, params System.Func<CloudyWing.FormValidators.Core.ValidationProvider,System.Func<string,string,CloudyWing.FormValidators.IFormValidator>>[] validatorCreators);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.Add(string,string,System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator__[]).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.Add(string,string,System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator__[]).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.Add(string,string,System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator__[]).validatorCreators'></a>

`validatorCreators` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[ValidationProvider](CloudyWing.FormValidators.Core.ValidationProvider.md 'CloudyWing.FormValidators.Core.ValidationProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IFormValidator](CloudyWing.FormValidators.IFormValidator.md 'CloudyWing.FormValidators.IFormValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The validator creators.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddBulk(System.Action_CloudyWing.FormValidators.Core.ValidatorConfiguration_,bool)'></a>

## ValidatorConfiguration.AddBulk(Action<ValidatorConfiguration>, bool) Method

Adds the bulk validator.

```csharp
public void AddBulk(System.Action<CloudyWing.FormValidators.Core.ValidatorConfiguration> configure, bool isStoppedIfFail=false);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddBulk(System.Action_CloudyWing.FormValidators.Core.ValidatorConfiguration_,bool).configure'></a>

`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[ValidatorConfiguration](CloudyWing.FormValidators.Core.ValidatorConfiguration.md 'CloudyWing.FormValidators.Core.ValidatorConfiguration')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The configure.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddBulk(System.Action_CloudyWing.FormValidators.Core.ValidatorConfiguration_,bool).isStoppedIfFail'></a>

`isStoppedIfFail` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is stopped if fail].

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddFalseAssert(bool,string)'></a>

## ValidatorConfiguration.AddFalseAssert(bool, string) Method

Adds the false assert validator.

```csharp
public void AddFalseAssert(bool isFalse, string message);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddFalseAssert(bool,string).isFalse'></a>

`isFalse` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is false].

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddFalseAssert(bool,string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddFalseAssert(System.Func_bool_,string)'></a>

## ValidatorConfiguration.AddFalseAssert(Func<bool>, string) Method

Adds the false assert validator.

```csharp
public void AddFalseAssert(System.Func<bool> falsePredicate, string message);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddFalseAssert(System.Func_bool_,string).falsePredicate'></a>

`falsePredicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The false predicate.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddFalseAssert(System.Func_bool_,string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddIf(bool,string,string,System.Collections.Generic.IEnumerable_System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator___)'></a>

## ValidatorConfiguration.AddIf(bool, string, string, IEnumerable<Func<ValidationProvider,Func<string,string,IFormValidator>>>) Method

Adds validators if condition is `true`.

```csharp
public void AddIf(bool condition, string column, string value, System.Collections.Generic.IEnumerable<System.Func<CloudyWing.FormValidators.Core.ValidationProvider,System.Func<string,string,CloudyWing.FormValidators.IFormValidator>>> validatorCreators);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddIf(bool,string,string,System.Collections.Generic.IEnumerable_System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator___).condition'></a>

`condition` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddIf(bool,string,string,System.Collections.Generic.IEnumerable_System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator___).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddIf(bool,string,string,System.Collections.Generic.IEnumerable_System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator___).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddIf(bool,string,string,System.Collections.Generic.IEnumerable_System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator___).validatorCreators'></a>

`validatorCreators` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[ValidationProvider](CloudyWing.FormValidators.Core.ValidationProvider.md 'CloudyWing.FormValidators.Core.ValidationProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IFormValidator](CloudyWing.FormValidators.IFormValidator.md 'CloudyWing.FormValidators.IFormValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddIf(bool,string,string,System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator__[])'></a>

## ValidatorConfiguration.AddIf(bool, string, string, Func<ValidationProvider,Func<string,string,IFormValidator>>[]) Method

Adds validators if condition is `true`.

```csharp
public void AddIf(bool condition, string column, string value, params System.Func<CloudyWing.FormValidators.Core.ValidationProvider,System.Func<string,string,CloudyWing.FormValidators.IFormValidator>>[] validatorCreators);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddIf(bool,string,string,System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator__[]).condition'></a>

`condition` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [condition].

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddIf(bool,string,string,System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator__[]).column'></a>

`column` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The column.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddIf(bool,string,string,System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator__[]).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddIf(bool,string,string,System.Func_CloudyWing.FormValidators.Core.ValidationProvider,System.Func_string,string,CloudyWing.FormValidators.IFormValidator__[]).validatorCreators'></a>

`validatorCreators` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[ValidationProvider](CloudyWing.FormValidators.Core.ValidationProvider.md 'CloudyWing.FormValidators.Core.ValidationProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[IFormValidator](CloudyWing.FormValidators.IFormValidator.md 'CloudyWing.FormValidators.IFormValidator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The validator creators.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddTrueAssert(bool,string)'></a>

## ValidatorConfiguration.AddTrueAssert(bool, string) Method

Adds the true assert validator.

```csharp
public void AddTrueAssert(bool isTrue, string message);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddTrueAssert(bool,string).isTrue'></a>

`isTrue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is true].

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddTrueAssert(bool,string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddTrueAssert(System.Func_bool_,string)'></a>

## ValidatorConfiguration.AddTrueAssert(Func<bool>, string) Method

Adds the true assert validator.

```csharp
public void AddTrueAssert(System.Func<bool> truePredicate, string message);
```
#### Parameters

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddTrueAssert(System.Func_bool_,string).truePredicate'></a>

`truePredicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The true predicate.

<a name='CloudyWing.FormValidators.Core.ValidatorConfiguration.AddTrueAssert(System.Func_bool_,string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.