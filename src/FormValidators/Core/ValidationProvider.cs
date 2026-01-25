using System;

namespace CloudyWing.FormValidators.Core;

/// <summary>The validation provider.</summary>
public class ValidationProvider {
    /// <summary>Validation indicate that a value is required.</summary>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, RequiredValidator> Required(string customErrorMessageFormat) {
        return Required((_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>Validation indicate that a value is required.</summary>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, RequiredValidator> Required(
        Func<string, string, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, customErrorMessageAccessor);
    }

    /// <summary>Validation indicate that a value is integer.</summary>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, IntegerValidator> Integer(bool allowedThousands, string customErrorMessageFormat) {
        return Integer(allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation indicate that a value is integer.</summary>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, IntegerValidator> Integer(
        bool allowedThousands = false, Func<string, string, long?, long?, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>Validation constrains the minimum integer of a value.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, IntegerValidator> MinInt(long min, bool allowedThousands, string customErrorMessageFormat) {
        return MinInt(min, allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation constrains the minimum integer of a value.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="allowedThousands"></param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, IntegerValidator> MinInt(
        long min, bool allowedThousands = false, Func<string, string, long?, long?, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, null, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>Validation constrains the maximum integer of a value.</summary>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, IntegerValidator> MaxInt(long max, bool allowedThousands, string customErrorMessageFormat) {
        return MaxInt(max, allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation constrains the maximum integer of a value.</summary>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, IntegerValidator> MaxInt(
        long max, bool allowedThousands = false, Func<string, string, long?, long?, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, null, max, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>Validation constrains the integer range of a value.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, IntegerValidator> IntRange(long min, long max, bool allowedThousands, string customErrorMessageFormat) {
        return IntRange(min, max, allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation constrains the integer range of a value.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, IntegerValidator> IntRange(
        long min, long max, bool allowedThousands = false, Func<string, string, long?, long?, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, max, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>Validation indicate that a value is number.</summary>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, NumberValidator> Number(bool allowedThousands, string customErrorMessageFormat) {
        return Number(allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation indicate that a value is number.</summary>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, NumberValidator> Number(
        bool allowedThousands = false, Func<string, string, decimal?, decimal?, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>Validation constrains the minimum number of a value.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, NumberValidator> MinNumber(decimal min, bool allowedThousands, string customErrorMessageFormat) {
        return MinNumber(min, allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation constrains the minimum number of a value.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, NumberValidator> MinNumber(
        decimal min, bool allowedThousands = false, Func<string, string, decimal?, decimal?, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, null, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>Validation constrains the maximum number of a value.</summary>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, NumberValidator> MaxNumber(decimal max, bool allowedThousands, string customErrorMessageFormat) {
        return MaxNumber(max, allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation constrains the maximum number of a value.</summary>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, NumberValidator> MaxNumber(
        decimal max, bool allowedThousands = false, Func<string, string, decimal?, decimal?, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, null, max, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>Validation constrains the number range of a value.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, NumberValidator> NumberRange(decimal min, decimal max, bool allowedThousands, string customErrorMessageFormat) {
        return NumberRange(min, max, allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation constrains the number range of a value.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, NumberValidator> NumberRange(
        decimal min, decimal max, bool allowedThousands = false, Func<string, string, decimal?, decimal?, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, max, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>Validation indicate that a value is date time.</summary>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, DateTimeValidator> DateTime(string customErrorMessageFormat) {
        return DateTime((_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation indicate that a value is date time.</summary>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, DateTimeValidator> DateTime(
        Func<string, string, DateTime?, DateTime?, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, customErrorMessageAccessor);
    }

    /// <summary>Validation constrains the minimum date time of a value.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, DateTimeValidator> MinDateTime(DateTime min, string customErrorMessageFormat) {
        return MinDateTime(min, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation constrains the minimum date time of a value.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, DateTimeValidator> MinDateTime(
        DateTime min, Func<string, string, DateTime?, DateTime?, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, null, customErrorMessageAccessor);
    }

    /// <summary>Validation constrains the maximum date time of a value.</summary>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, DateTimeValidator> MaxDateTime(DateTime max, string customErrorMessageFormat) {
        return MaxDateTime(max, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation constrains the maximum date time of a value.</summary>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, DateTimeValidator> MaxDateTime(
        DateTime max, Func<string, string, DateTime?, DateTime?, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, null, max, customErrorMessageAccessor);
    }

    /// <summary>Validation constrains the date time range of a value.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, DateTimeValidator> DateTimeRange(
        DateTime min, DateTime max, string customErrorMessageFormat
    ) {
        return DateTimeRange(min, max, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation constrains the date time range of a value.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, DateTimeValidator> DateTimeRange(
        DateTime min, DateTime max, Func<string, string, DateTime?, DateTime?, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, max, customErrorMessageAccessor);
    }

    /// <summary>Validation to constrains a value does not exceed a minimum length.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, ValueLengthValidator> MinLength(long min, string customErrorMessageFormat) {
        return MinLength(min, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation to constrains a value does not exceed a minimum length.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, ValueLengthValidator> MinLength(
        long min, Func<string, string, long, long, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, 0, customErrorMessageAccessor);
    }

    /// <summary>Validation to constrains a value does not exceed a maximum length.</summary>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, ValueLengthValidator> MaxLength(long max, string customErrorMessageFormat) {
        return MaxLength(max, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation to constrains a value does not exceed a maximum length.</summary>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, ValueLengthValidator> MaxLength(
        long max, Func<string, string, long, long, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, 0, max, customErrorMessageAccessor);
    }

    /// <summary>Validation constraints a value does not exceed the length range.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, ValueLengthValidator> LengthRange(
        int min, int max, string customErrorMessageFormat
    ) {
        return LengthRange(min, max, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>Validation constraints a value does not exceed the length range.</summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, ValueLengthValidator> LengthRange(
        int min, int max, Func<string, string, long, long, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, max, customErrorMessageAccessor);
    }

    /// <summary>Regex validation.</summary>
    /// <param name="pattern">The pattern.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, RegexValidator> Regex(string pattern, string customErrorMessageFormat) {
        return Regex(pattern, (_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>Regex validation.</summary>
    /// <param name="pattern">The pattern.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, RegexValidator> Regex(
        string pattern, Func<string, string, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, pattern, customErrorMessageAccessor);
    }

    /// <summary>Email validation.</summary>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, RegexValidator> Email(string customErrorMessageFormat) {
        return Email((_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>Email validation.</summary>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, EmailValidator> Email(
        Func<string, string, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, customErrorMessageAccessor);
    }

    /// <summary>Mobile phone validation.</summary>
    /// <param name="formats">The formats.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, The mobile phone formats.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, MobilePhoneValidator> MobilePhone(
        MobilePhoneFormats formats, string customErrorMessageFormat
    ) {
        return MobilePhone(formats, (_column, _value, _formats) => string.Format(customErrorMessageFormat, _column, _value, _formats));
    }

    /// <summary>Mobile phone validation.</summary>
    /// <param name="formats">The formats.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, The mobile phone formats.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, MobilePhoneValidator> MobilePhone(
        MobilePhoneFormats formats = MobilePhoneFormats.All,
        Func<string, string, MobilePhoneFormats, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, formats, customErrorMessageAccessor);
    }

    /// <summary>Identification card validation.</summary>
    /// <param name="idTypes">The Identification types.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, The identification card types.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, IdCardValidator> IdCard(IdCardTypes idTypes, string customErrorMessageFormat) {
        return IdCard(idTypes, (_column, _value, _idTypes) => string.Format(customErrorMessageFormat, _column, _value, _idTypes));
    }

    /// <summary>Identification card validation.</summary>
    /// <param name="idTypes">The Identification types.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, The identification card types.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, IdCardValidator> IdCard(
        IdCardTypes idTypes = IdCardTypes.All,
        Func<string, string, IdCardTypes, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, idTypes, customErrorMessageAccessor);
    }

    /// <summary>Compare the value of one column with the value of another column.</summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, comparison column, comparison value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, CompareValidator> Compare(
        string comparisonColumn, string comparisonValue, string customErrorMessageFormat
    ) {
        return Compare(
            comparisonColumn, comparisonValue,
            (_column, _value, _comparisonColumn, _comparisonValue)
                => string.Format(customErrorMessageFormat, _column, _value, _comparisonColumn, comparisonValue)
        );
    }

    /// <summary>Compare the value of one column with the value of another column.</summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, comparison column, comparison value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, CompareValidator> Compare(
        string comparisonColumn, string comparisonValue,
        Func<string, string, string, string, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, comparisonColumn, comparisonValue, customErrorMessageAccessor);
    }

    /// <summary>Validate that an integer value is less than another column value.</summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, comparison column, comparison value, allowed equal.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, IntegerLessThanValidator> IntegerLessThan(
        string comparisonColumn, string comparisonValue, bool allowedEqual, string customErrorMessageFormat
    ) {
        return IntegerLessThan(
            comparisonColumn, comparisonValue, allowedEqual,
            (_column, _value, _comparisonColumn, _comparisonValue, _allowedEqual)
                => string.Format(customErrorMessageFormat, _column, _value, _comparisonColumn, comparisonValue, _allowedEqual)
        );
    }

    /// <summary>Validate that an integer value is less than another column value.</summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, comparison column, comparison value, allowed equal.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, IntegerLessThanValidator> IntegerLessThan(
        string comparisonColumn, string comparisonValue, bool allowedEqual = true,
        Func<string, string, string, string, bool, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, comparisonColumn, comparisonValue, allowedEqual, customErrorMessageAccessor);
    }

    /// <summary>Validate that an number value is less than another column value.</summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, comparison column, comparison value, allowed equal.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, NumberLessThanValidator> NumberLessThan(
        string comparisonColumn, string comparisonValue, bool allowedEqual, string customErrorMessageFormat
    ) {
        return NumberLessThan(
            comparisonColumn, comparisonValue, allowedEqual,
            (_column, _value, _comparisonColumn, _comparisonValue, _allowedEqual)
                => string.Format(customErrorMessageFormat, _column, _value, _comparisonColumn, comparisonValue, _allowedEqual)
        );
    }

    /// <summary>Validate that an number value is less than another column value.</summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, comparison column, comparison value, allowed equal.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, NumberLessThanValidator> NumberLessThan(
        string comparisonColumn, string comparisonValue, bool allowedEqual = true,
        Func<string, string, string, string, bool, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, comparisonColumn, comparisonValue, allowedEqual, customErrorMessageAccessor);
    }

    /// <summary>Validate that an date time value is less than another column value.</summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The agrumts are column, value, comparison column, comparison value, allowed equal.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, DateTimeLessThanValidator> DateTimeLessThan(
        string comparisonColumn, string comparisonValue, bool allowedEqual, string customErrorMessageFormat
    ) {
        return DateTimeLessThan(
            comparisonColumn, comparisonValue, allowedEqual,
            (_column, _value, _comparisonColumn, _comparisonValue, _allowedEqual)
                => string.Format(customErrorMessageFormat, _column, _value, _comparisonColumn, comparisonValue, _allowedEqual)
        );
    }

    /// <summary>Validate that an date time value is less than another column value.</summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, comparison column, comparison value, allowed equal.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string, DateTimeLessThanValidator> DateTimeLessThan(
        string comparisonColumn, string comparisonValue, bool allowedEqual = true,
        Func<string, string, string, string, bool, string> customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, comparisonColumn, comparisonValue, allowedEqual, customErrorMessageAccessor);
    }
}
