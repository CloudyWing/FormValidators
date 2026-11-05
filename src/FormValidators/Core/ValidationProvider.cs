using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CloudyWing.FormValidators.Core;

/// <summary>
/// The validation provider.
/// </summary>
public class ValidationProvider {
    /// <summary>
    /// Validation indicate that a value is required.
    /// </summary>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, RequiredValidator> Required(string customErrorMessageFormat) {
        return Required((_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>
    /// Validation indicate that a value is required.
    /// </summary>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, RequiredValidator> Required(
        Func<string, string?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is integer.
    /// </summary>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> Integer(bool allowedThousands, string customErrorMessageFormat) {
        return Integer(allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation indicate that a value is integer.
    /// </summary>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> Integer(
        bool allowedThousands = false, Func<string, string?, long?, long?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the minimum integer of a value.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> MinInt(long min, bool allowedThousands, string customErrorMessageFormat) {
        return MinInt(min, allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation constrains the minimum integer of a value.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="allowedThousands"></param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> MinInt(
        long min, bool allowedThousands = false, Func<string, string?, long?, long?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, null, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the maximum integer of a value.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> MaxInt(long max, bool allowedThousands, string customErrorMessageFormat) {
        return MaxInt(max, allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation constrains the maximum integer of a value.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> MaxInt(
        long max, bool allowedThousands = false, Func<string, string?, long?, long?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, null, max, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the integer range of a value.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> IntRange(long min, long max, bool allowedThousands, string customErrorMessageFormat) {
        return IntRange(min, max, allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation constrains the integer range of a value.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> IntRange(
        long min, long max, bool allowedThousands = false, Func<string, string?, long?, long?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, max, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is integer parsed with the format provider.
    /// </summary>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> Integer(bool allowedThousands, IFormatProvider? formatProvider) {
        return Integer(allowedThousands, formatProvider, (Func<string, string?, long?, long?, string>?)null);
    }

    /// <summary>
    /// Validation indicate that a value is integer parsed with the format provider.
    /// </summary>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> Integer(
        bool allowedThousands, IFormatProvider? formatProvider,
        Func<string, string?, long?, long?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, null, null, allowedThousands, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the minimum integer of a value parsed with the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> MinInt(long min, bool allowedThousands, IFormatProvider? formatProvider) {
        return MinInt(min, allowedThousands, formatProvider, (Func<string, string?, long?, long?, string>?)null);
    }

    /// <summary>
    /// Validation constrains the minimum integer of a value parsed with the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> MinInt(
        long min, bool allowedThousands, IFormatProvider? formatProvider,
        Func<string, string?, long?, long?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, min, null, allowedThousands, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the maximum integer of a value parsed with the format provider.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> MaxInt(long max, bool allowedThousands, IFormatProvider? formatProvider) {
        return MaxInt(max, allowedThousands, formatProvider, (Func<string, string?, long?, long?, string>?)null);
    }

    /// <summary>
    /// Validation constrains the maximum integer of a value parsed with the format provider.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> MaxInt(
        long max, bool allowedThousands, IFormatProvider? formatProvider,
        Func<string, string?, long?, long?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, null, max, allowedThousands, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the integer range of a value parsed with the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> IntRange(long min, long max, bool allowedThousands, IFormatProvider? formatProvider) {
        return IntRange(min, max, allowedThousands, formatProvider, (Func<string, string?, long?, long?, string>?)null);
    }

    /// <summary>
    /// Validation constrains the integer range of a value parsed with the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerValidator> IntRange(
        long min, long max, bool allowedThousands, IFormatProvider? formatProvider,
        Func<string, string?, long?, long?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, min, max, allowedThousands, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is number.
    /// </summary>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> Number(bool allowedThousands, string customErrorMessageFormat) {
        return Number(allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation indicate that a value is number.
    /// </summary>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> Number(
        bool allowedThousands = false, Func<string, string?, decimal?, decimal?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the minimum number of a value.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> MinNumber(decimal min, bool allowedThousands, string customErrorMessageFormat) {
        return MinNumber(min, allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation constrains the minimum number of a value.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> MinNumber(
        decimal min, bool allowedThousands = false, Func<string, string?, decimal?, decimal?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, null, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the maximum number of a value.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> MaxNumber(decimal max, bool allowedThousands, string customErrorMessageFormat) {
        return MaxNumber(max, allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation constrains the maximum number of a value.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> MaxNumber(
        decimal max, bool allowedThousands = false, Func<string, string?, decimal?, decimal?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, null, max, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the number range of a value.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> NumberRange(decimal min, decimal max, bool allowedThousands, string customErrorMessageFormat) {
        return NumberRange(min, max, allowedThousands, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation constrains the number range of a value.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> NumberRange(
        decimal min, decimal max, bool allowedThousands = false, Func<string, string?, decimal?, decimal?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, max, allowedThousands, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is number parsed with the format provider.
    /// </summary>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> Number(bool allowedThousands, IFormatProvider? formatProvider) {
        return Number(allowedThousands, formatProvider, (Func<string, string?, decimal?, decimal?, string>?)null);
    }

    /// <summary>
    /// Validation indicate that a value is number parsed with the format provider.
    /// </summary>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> Number(
        bool allowedThousands, IFormatProvider? formatProvider,
        Func<string, string?, decimal?, decimal?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, null, null, allowedThousands, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the minimum number of a value parsed with the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> MinNumber(decimal min, bool allowedThousands, IFormatProvider? formatProvider) {
        return MinNumber(min, allowedThousands, formatProvider, (Func<string, string?, decimal?, decimal?, string>?)null);
    }

    /// <summary>
    /// Validation constrains the minimum number of a value parsed with the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> MinNumber(
        decimal min, bool allowedThousands, IFormatProvider? formatProvider,
        Func<string, string?, decimal?, decimal?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, min, null, allowedThousands, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the maximum number of a value parsed with the format provider.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> MaxNumber(decimal max, bool allowedThousands, IFormatProvider? formatProvider) {
        return MaxNumber(max, allowedThousands, formatProvider, (Func<string, string?, decimal?, decimal?, string>?)null);
    }

    /// <summary>
    /// Validation constrains the maximum number of a value parsed with the format provider.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> MaxNumber(
        decimal max, bool allowedThousands, IFormatProvider? formatProvider,
        Func<string, string?, decimal?, decimal?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, null, max, allowedThousands, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the number range of a value parsed with the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> NumberRange(decimal min, decimal max, bool allowedThousands, IFormatProvider? formatProvider) {
        return NumberRange(min, max, allowedThousands, formatProvider, (Func<string, string?, decimal?, decimal?, string>?)null);
    }

    /// <summary>
    /// Validation constrains the number range of a value parsed with the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberValidator> NumberRange(
        decimal min, decimal max, bool allowedThousands, IFormatProvider? formatProvider,
        Func<string, string?, decimal?, decimal?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, min, max, allowedThousands, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is date time.
    /// </summary>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> DateTime(string customErrorMessageFormat) {
        return DateTime((_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation indicate that a value is date time.
    /// </summary>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> DateTime(
        Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the minimum date time of a value.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> MinDateTime(DateTime min, string customErrorMessageFormat) {
        return MinDateTime(min, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation constrains the minimum date time of a value.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> MinDateTime(
        DateTime min, Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, null, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the maximum date time of a value.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> MaxDateTime(DateTime max, string customErrorMessageFormat) {
        return MaxDateTime(max, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation constrains the maximum date time of a value.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> MaxDateTime(
        DateTime max, Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, null, max, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the date time range of a value.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> DateTimeRange(
        DateTime min, DateTime max, string customErrorMessageFormat
    ) {
        return DateTimeRange(min, max, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation constrains the date time range of a value.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> DateTimeRange(
        DateTime min, DateTime max, Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, max, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is date time parsed with the format provider.
    /// </summary>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> DateTime(IFormatProvider? formatProvider) {
        return DateTime(formatProvider, (Func<string, string?, DateTime?, DateTime?, string>?)null);
    }

    /// <summary>
    /// Validation indicate that a value is date time parsed with the format provider.
    /// </summary>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> DateTime(
        IFormatProvider? formatProvider,
        Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, null, null, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is date time parsed with the exact formats and the format provider.
    /// </summary>
    /// <param name="formats">The allowed exact formats, such as <c>yyyy/MM/dd</c>. An empty collection allows any format recognized by the format provider.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> DateTime(IEnumerable<string> formats, IFormatProvider? formatProvider) {
        return DateTime(formats, formatProvider, (Func<string, string?, DateTime?, DateTime?, string>?)null);
    }

    /// <summary>
    /// Validation indicate that a value is date time parsed with the exact formats and the format provider.
    /// </summary>
    /// <param name="formats">The allowed exact formats, such as <c>yyyy/MM/dd</c>. An empty collection allows any format recognized by the format provider.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> DateTime(
        IEnumerable<string> formats, IFormatProvider? formatProvider,
        Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, null, null, formats, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the minimum date time of a value parsed with the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> MinDateTime(DateTime min, IFormatProvider? formatProvider) {
        return MinDateTime(min, formatProvider, (Func<string, string?, DateTime?, DateTime?, string>?)null);
    }

    /// <summary>
    /// Validation constrains the minimum date time of a value parsed with the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> MinDateTime(
        DateTime min, IFormatProvider? formatProvider,
        Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, min, null, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the minimum date time of a value parsed with the exact formats and the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="formats">The allowed exact formats, such as <c>yyyy/MM/dd</c>. An empty collection allows any format recognized by the format provider.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> MinDateTime(DateTime min, IEnumerable<string> formats, IFormatProvider? formatProvider) {
        return MinDateTime(min, formats, formatProvider, (Func<string, string?, DateTime?, DateTime?, string>?)null);
    }

    /// <summary>
    /// Validation constrains the minimum date time of a value parsed with the exact formats and the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="formats">The allowed exact formats, such as <c>yyyy/MM/dd</c>. An empty collection allows any format recognized by the format provider.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> MinDateTime(
        DateTime min, IEnumerable<string> formats, IFormatProvider? formatProvider,
        Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, min, null, formats, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the maximum date time of a value parsed with the format provider.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> MaxDateTime(DateTime max, IFormatProvider? formatProvider) {
        return MaxDateTime(max, formatProvider, (Func<string, string?, DateTime?, DateTime?, string>?)null);
    }

    /// <summary>
    /// Validation constrains the maximum date time of a value parsed with the format provider.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> MaxDateTime(
        DateTime max, IFormatProvider? formatProvider,
        Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, null, max, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the maximum date time of a value parsed with the exact formats and the format provider.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="formats">The allowed exact formats, such as <c>yyyy/MM/dd</c>. An empty collection allows any format recognized by the format provider.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> MaxDateTime(DateTime max, IEnumerable<string> formats, IFormatProvider? formatProvider) {
        return MaxDateTime(max, formats, formatProvider, (Func<string, string?, DateTime?, DateTime?, string>?)null);
    }

    /// <summary>
    /// Validation constrains the maximum date time of a value parsed with the exact formats and the format provider.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="formats">The allowed exact formats, such as <c>yyyy/MM/dd</c>. An empty collection allows any format recognized by the format provider.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> MaxDateTime(
        DateTime max, IEnumerable<string> formats, IFormatProvider? formatProvider,
        Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, null, max, formats, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the date time range of a value parsed with the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> DateTimeRange(DateTime min, DateTime max, IFormatProvider? formatProvider) {
        return DateTimeRange(min, max, formatProvider, (Func<string, string?, DateTime?, DateTime?, string>?)null);
    }

    /// <summary>
    /// Validation constrains the date time range of a value parsed with the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> DateTimeRange(
        DateTime min, DateTime max, IFormatProvider? formatProvider,
        Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, min, max, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constrains the date time range of a value parsed with the exact formats and the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="formats">The allowed exact formats, such as <c>yyyy/MM/dd</c>. An empty collection allows any format recognized by the format provider.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> DateTimeRange(DateTime min, DateTime max, IEnumerable<string> formats, IFormatProvider? formatProvider) {
        return DateTimeRange(min, max, formats, formatProvider, (Func<string, string?, DateTime?, DateTime?, string>?)null);
    }

    /// <summary>
    /// Validation constrains the date time range of a value parsed with the exact formats and the format provider.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="formats">The allowed exact formats, such as <c>yyyy/MM/dd</c>. An empty collection allows any format recognized by the format provider.</param>
    /// <param name="formatProvider">The format provider used to parse the value, such as <see cref="System.Globalization.CultureInfo.InvariantCulture" />. <see langword="null" /> uses the current culture.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeValidator> DateTimeRange(
        DateTime min, DateTime max, IEnumerable<string> formats, IFormatProvider? formatProvider,
        Func<string, string?, DateTime?, DateTime?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, min, max, formats, formatProvider, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation to constrains a value does not exceed a minimum length.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> MinLength(long min, string customErrorMessageFormat) {
        return MinLength(min, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation to constrains a value does not exceed a minimum length.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> MinLength(
        long min, Func<string, string?, long, long, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, 0, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation to constrains a value does not exceed a maximum length.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> MaxLength(long max, string customErrorMessageFormat) {
        return MaxLength(max, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation to constrains a value does not exceed a maximum length.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> MaxLength(
        long max, Func<string, string?, long, long, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, 0, max, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constraints a value does not exceed the length range.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> LengthRange(
        int min, int max, string customErrorMessageFormat
    ) {
        return LengthRange(min, max, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation constraints a value does not exceed the length range.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> LengthRange(
        int min, int max, Func<string, string?, long, long, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, min, max, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation to constrains a value does not exceed a minimum length counted by the specified unit.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="unit">The unit used to count the length.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> MinLength(long min, TextLengthUnit unit) {
        return MinLength(min, unit, (Func<string, string?, long, long, string>?)null);
    }

    /// <summary>
    /// Validation to constrains a value does not exceed a minimum length counted by the specified unit.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="unit">The unit used to count the length.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> MinLength(long min, TextLengthUnit unit, string customErrorMessageFormat) {
        return MinLength(min, unit, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation to constrains a value does not exceed a minimum length counted by the specified unit.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="unit">The unit used to count the length.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> MinLength(
        long min, TextLengthUnit unit, Func<string, string?, long, long, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, min, 0, unit, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation to constrains a value does not exceed a maximum length counted by the specified unit.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="unit">The unit used to count the length.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> MaxLength(long max, TextLengthUnit unit) {
        return MaxLength(max, unit, (Func<string, string?, long, long, string>?)null);
    }

    /// <summary>
    /// Validation to constrains a value does not exceed a maximum length counted by the specified unit.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="unit">The unit used to count the length.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> MaxLength(long max, TextLengthUnit unit, string customErrorMessageFormat) {
        return MaxLength(max, unit, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation to constrains a value does not exceed a maximum length counted by the specified unit.
    /// </summary>
    /// <param name="max">The maximum.</param>
    /// <param name="unit">The unit used to count the length.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> MaxLength(
        long max, TextLengthUnit unit, Func<string, string?, long, long, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, 0, max, unit, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation constraints a value does not exceed the length range counted by the specified unit.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="unit">The unit used to count the length.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> LengthRange(int min, int max, TextLengthUnit unit) {
        return LengthRange(min, max, unit, (Func<string, string?, long, long, string>?)null);
    }

    /// <summary>
    /// Validation constraints a value does not exceed the length range counted by the specified unit.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="unit">The unit used to count the length.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> LengthRange(int min, int max, TextLengthUnit unit, string customErrorMessageFormat) {
        return LengthRange(min, max, unit, (_column, _value, _min, _max) => string.Format(customErrorMessageFormat, _column, _value, _min, _max));
    }

    /// <summary>
    /// Validation constraints a value does not exceed the length range counted by the specified unit.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <param name="unit">The unit used to count the length.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, min, max.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, ValueLengthValidator> LengthRange(
        int min, int max, TextLengthUnit unit, Func<string, string?, long, long, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, min, max, unit, customErrorMessageAccessor);
    }

    /// <summary>
    /// Regex validation.
    /// </summary>
    /// <param name="pattern">The pattern.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, RegexValidator> Regex(string pattern, string customErrorMessageFormat) {
        return Regex(pattern, (_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>
    /// Regex validation.
    /// </summary>
    /// <param name="pattern">The pattern.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, RegexValidator> Regex(
        string pattern, Func<string, string?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, pattern, customErrorMessageAccessor);
    }

    /// <summary>
    /// Regex validation with the regex instance.
    /// </summary>
    /// <param name="regex">The regex. Its options and match timeout are used as is.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, RegexValidator> Regex(Regex regex, string customErrorMessageFormat) {
        return Regex(regex, (_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>
    /// Regex validation with the regex instance.
    /// </summary>
    /// <param name="regex">The regex. Its options and match timeout are used as is.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="regex" /> is <see langword="null" />.</exception>
    public Func<string, string?, RegexValidator> Regex(
        Regex regex, Func<string, string?, string>? customErrorMessageAccessor = null
    ) {
        if (regex is null) {
            throw new ArgumentNullException(nameof(regex));
        }

        return (column, value) => new(column, value, regex, customErrorMessageAccessor);
    }

    /// <summary>
    /// Regex validation with the regex options and the match timeout.
    /// </summary>
    /// <param name="pattern">The pattern.</param>
    /// <param name="options">The regex options.</param>
    /// <param name="matchTimeout">The match timeout, or <see cref="System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" />. When a match times out, the validation fails.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, RegexValidator> Regex(
        string pattern, RegexOptions options, TimeSpan matchTimeout, string customErrorMessageFormat
    ) {
        return Regex(pattern, options, matchTimeout, (_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>
    /// Regex validation with the regex options and the match timeout.
    /// </summary>
    /// <param name="pattern">The pattern.</param>
    /// <param name="options">The regex options.</param>
    /// <param name="matchTimeout">The match timeout, or <see cref="System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" />. When a match times out, the validation fails.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, RegexValidator> Regex(string pattern, RegexOptions options, TimeSpan matchTimeout) {
        return Regex(pattern, options, matchTimeout, (Func<string, string?, string>?)null);
    }

    /// <summary>
    /// Regex validation with the regex options and the match timeout.
    /// </summary>
    /// <param name="pattern">The pattern.</param>
    /// <param name="options">The regex options.</param>
    /// <param name="matchTimeout">The match timeout, or <see cref="System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" />. When a match times out, the validation fails.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="pattern" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException"><paramref name="pattern" /> is not a valid regular expression.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="matchTimeout" /> is zero, negative or too large, and is not <see cref="System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" />.</exception>
    public Func<string, string?, RegexValidator> Regex(
        string pattern, RegexOptions options, TimeSpan matchTimeout, Func<string, string?, string>? customErrorMessageAccessor
    ) {
        if (pattern is null) {
            throw new ArgumentNullException(nameof(pattern));
        }

        ValidatorDefaults.ValidateRegexTimeout(matchTimeout, nameof(matchTimeout));

        // 建立一次 Regex 供所有由此 creator 產生的 validator 共用
        Regex regex = new(pattern, options, matchTimeout);

        return (column, value) => new(column, value, regex, customErrorMessageAccessor);
    }

    /// <summary>
    /// Email validation.
    /// </summary>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, RegexValidator> Email(string customErrorMessageFormat) {
        return Email((_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>
    /// Email validation.
    /// </summary>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, EmailValidator> Email(
        Func<string, string?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, customErrorMessageAccessor);
    }

    /// <summary>
    /// Mobile phone validation.
    /// </summary>
    /// <param name="formats">The formats.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, The mobile phone formats.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, MobilePhoneValidator> MobilePhone(
        MobilePhoneFormats formats, string customErrorMessageFormat
    ) {
        return MobilePhone(formats, (_column, _value, _formats) => string.Format(customErrorMessageFormat, _column, _value, _formats));
    }

    /// <summary>
    /// Mobile phone validation.
    /// </summary>
    /// <param name="formats">The formats.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, The mobile phone formats.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, MobilePhoneValidator> MobilePhone(
        MobilePhoneFormats formats = MobilePhoneFormats.All,
        Func<string, string?, MobilePhoneFormats, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, formats, customErrorMessageAccessor);
    }

    /// <summary>
    /// Identification card validation.
    /// </summary>
    /// <param name="idTypes">The Identification types.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, The identification card types.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IdCardValidator> IdCard(IdCardTypes idTypes, string customErrorMessageFormat) {
        return IdCard(idTypes, (_column, _value, _idTypes) => string.Format(customErrorMessageFormat, _column, _value, _idTypes));
    }

    /// <summary>
    /// Identification card validation.
    /// </summary>
    /// <param name="idTypes">The Identification types.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, The identification card types.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IdCardValidator> IdCard(
        IdCardTypes idTypes = IdCardTypes.All,
        Func<string, string?, IdCardTypes, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, idTypes, customErrorMessageAccessor);
    }

    /// <summary>
    /// Compare the value of one column with the value of another column.
    /// </summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, comparison column, comparison value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, CompareValidator> Compare(
        string comparisonColumn, string? comparisonValue, string customErrorMessageFormat
    ) {
        return Compare(
            comparisonColumn, comparisonValue,
            (_column, _value, _comparisonColumn, _comparisonValue)
                => string.Format(customErrorMessageFormat, _column, _value, _comparisonColumn, comparisonValue)
        );
    }

    /// <summary>
    /// Compare the value of one column with the value of another column.
    /// </summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, comparison column, comparison value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, CompareValidator> Compare(
        string comparisonColumn, string? comparisonValue,
        Func<string, string?, string, string?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, comparisonColumn, comparisonValue, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validate that an integer value is less than another column value.
    /// </summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, comparison column, comparison value, allowed equal.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerLessThanValidator> IntegerLessThan(
        string comparisonColumn, string? comparisonValue, bool allowedEqual, string customErrorMessageFormat
    ) {
        return IntegerLessThan(
            comparisonColumn, comparisonValue, allowedEqual,
            (_column, _value, _comparisonColumn, _comparisonValue, _allowedEqual)
                => string.Format(customErrorMessageFormat, _column, _value, _comparisonColumn, comparisonValue, _allowedEqual)
        );
    }

    /// <summary>
    /// Validate that an integer value is less than another column value.
    /// </summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, comparison column, comparison value, allowed equal.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IntegerLessThanValidator> IntegerLessThan(
        string comparisonColumn, string? comparisonValue, bool allowedEqual = true,
        Func<string, string?, string, string?, bool, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, comparisonColumn, comparisonValue, allowedEqual, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validate that an number value is less than another column value.
    /// </summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, comparison column, comparison value, allowed equal.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberLessThanValidator> NumberLessThan(
        string comparisonColumn, string? comparisonValue, bool allowedEqual, string customErrorMessageFormat
    ) {
        return NumberLessThan(
            comparisonColumn, comparisonValue, allowedEqual,
            (_column, _value, _comparisonColumn, _comparisonValue, _allowedEqual)
                => string.Format(customErrorMessageFormat, _column, _value, _comparisonColumn, comparisonValue, _allowedEqual)
        );
    }

    /// <summary>
    /// Validate that an number value is less than another column value.
    /// </summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, comparison column, comparison value, allowed equal.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, NumberLessThanValidator> NumberLessThan(
        string comparisonColumn, string? comparisonValue, bool allowedEqual = true,
        Func<string, string?, string, string?, bool, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, comparisonColumn, comparisonValue, allowedEqual, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validate that an date time value is less than another column value.
    /// </summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, comparison column, comparison value, allowed equal.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeLessThanValidator> DateTimeLessThan(
        string comparisonColumn, string? comparisonValue, bool allowedEqual, string customErrorMessageFormat
    ) {
        return DateTimeLessThan(
            comparisonColumn, comparisonValue, allowedEqual,
            (_column, _value, _comparisonColumn, _comparisonValue, _allowedEqual)
                => string.Format(customErrorMessageFormat, _column, _value, _comparisonColumn, comparisonValue, _allowedEqual)
        );
    }

    /// <summary>
    /// Validate that an date time value is less than another column value.
    /// </summary>
    /// <param name="comparisonColumn">The comparison column.</param>
    /// <param name="comparisonValue">The comparison value.</param>
    /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, comparison column, comparison value, allowed equal.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, DateTimeLessThanValidator> DateTimeLessThan(
        string comparisonColumn, string? comparisonValue, bool allowedEqual = true,
        Func<string, string?, string, string?, bool, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, comparisonColumn, comparisonValue, allowedEqual, customErrorMessageAccessor);
    }
    /// <summary>
    /// Validation indicate that a value is URL.
    /// </summary>
    /// <param name="kind">The kind.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, UrlValidator> Url(
        UriKind kind, string customErrorMessageFormat
    ) {
        return Url(kind, (_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>
    /// Validation indicate that a value is URL.
    /// </summary>
    /// <param name="kind">The kind.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, UrlValidator> Url(
        UriKind kind = UriKind.Absolute,
        Func<string, string?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, kind, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is URL with one of the allowed schemes.
    /// </summary>
    /// <param name="kind">The kind.</param>
    /// <param name="allowedSchemes">The allowed schemes of an absolute URL, such as <c>http</c> and <c>https</c>. An empty collection allows any scheme.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, UrlValidator> Url(
        UriKind kind, IEnumerable<string> allowedSchemes, string customErrorMessageFormat
    ) {
        return Url(kind, allowedSchemes, (_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>
    /// Validation indicate that a value is URL with one of the allowed schemes.
    /// </summary>
    /// <param name="kind">The kind.</param>
    /// <param name="allowedSchemes">The allowed schemes of an absolute URL, such as <c>http</c> and <c>https</c>. An empty collection allows any scheme.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, UrlValidator> Url(UriKind kind, IEnumerable<string> allowedSchemes) {
        return Url(kind, allowedSchemes, (Func<string, string?, string>?)null);
    }

    /// <summary>
    /// Validation indicate that a value is URL with one of the allowed schemes.
    /// </summary>
    /// <param name="kind">The kind.</param>
    /// <param name="allowedSchemes">The allowed schemes of an absolute URL, such as <c>http</c> and <c>https</c>. An empty collection allows any scheme.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, UrlValidator> Url(
        UriKind kind, IEnumerable<string> allowedSchemes, Func<string, string?, string>? customErrorMessageAccessor
    ) {
        return (column, value) => new(column, value, kind, allowedSchemes, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is IP address.
    /// </summary>
    /// <param name="types">The types.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value, The IP address types.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IPAddressValidator> IPAddress(
        IPAddressTypes types, string customErrorMessageFormat
    ) {
        return IPAddress(types, (_column, _value, _types) => string.Format(customErrorMessageFormat, _column, _value, _types));
    }

    /// <summary>
    /// Validation indicate that a value is IP address.
    /// </summary>
    /// <param name="types">The types.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, The IP address types.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, IPAddressValidator> IPAddress(
        IPAddressTypes types = IPAddressTypes.All,
        Func<string, string?, IPAddressTypes, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, types, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is credit card.
    /// </summary>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, CreditCardValidator> CreditCard(string customErrorMessageFormat) {
        return CreditCard((_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>
    /// Validation indicate that a value is credit card.
    /// </summary>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, CreditCardValidator> CreditCard(
        Func<string, string?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation with a custom predicate. The predicate is not called for a <see langword="null" />, empty or white space value.
    /// </summary>
    /// <param name="predicate">The predicate that returns <see langword="true" /> when the value is valid.</param>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, CustomValidator> Custom(Func<string, bool> predicate, string customErrorMessageFormat) {
        return Custom(predicate, (_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>
    /// Validation with a custom predicate. The predicate is not called for a <see langword="null" />, empty or white space value.
    /// </summary>
    /// <param name="predicate">The predicate that returns <see langword="true" /> when the value is valid.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="predicate" /> is <see langword="null" />.</exception>
    public Func<string, string?, CustomValidator> Custom(
        Func<string, bool> predicate, Func<string, string?, string>? customErrorMessageAccessor = null
    ) {
        if (predicate is null) {
            throw new ArgumentNullException(nameof(predicate));
        }

        return (column, value) => new(column, value, predicate, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is one of the allowed values, compared by <see cref="StringComparison.Ordinal" /> (case-sensitive).
    /// </summary>
    /// <param name="allowedValues">The allowed values.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, AllowedValuesValidator> In(params string[] allowedValues) {
        return In(allowedValues, StringComparison.Ordinal, null);
    }

    /// <summary>
    /// Validation indicate that a value is one of the allowed values.
    /// </summary>
    /// <param name="allowedValues">The allowed values.</param>
    /// <param name="comparisonType">The rule used to compare the value with the allowed values, such as <see cref="StringComparison.OrdinalIgnoreCase" />.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, AllowedValuesValidator> In(IEnumerable<string> allowedValues, StringComparison comparisonType) {
        return In(allowedValues, comparisonType, null);
    }

    /// <summary>
    /// Validation indicate that a value is one of the allowed values.
    /// </summary>
    /// <param name="allowedValues">The allowed values.</param>
    /// <param name="comparisonType">The rule used to compare the value with the allowed values, such as <see cref="StringComparison.OrdinalIgnoreCase" />.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, allowed values.</param>
    /// <returns>The validator creator.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="allowedValues" /> is <see langword="null" />.</exception>
    public Func<string, string?, AllowedValuesValidator> In(
        IEnumerable<string> allowedValues, StringComparison comparisonType,
        Func<string, string?, IReadOnlyList<string>, string>? customErrorMessageAccessor
    ) {
        if (allowedValues is null) {
            throw new ArgumentNullException(nameof(allowedValues));
        }

        // 先複製一份，避免呼叫端之後修改來源集合影響已建立的 creator
        string[] values = [.. allowedValues];

        return (column, value) => new(column, value, values, comparisonType, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is GUID.
    /// </summary>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, GuidValidator> Guid(string customErrorMessageFormat) {
        return Guid((_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>
    /// Validation indicate that a value is GUID.
    /// </summary>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, GuidValidator> Guid(
        Func<string, string?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is Taiwan business uniform number (統一編號).
    /// </summary>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, TaiwanUniformNumberValidator> TaiwanUniformNumber(string customErrorMessageFormat) {
        return TaiwanUniformNumber((_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>
    /// Validation indicate that a value is Taiwan business uniform number (統一編號).
    /// </summary>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, TaiwanUniformNumberValidator> TaiwanUniformNumber(
        Func<string, string?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, customErrorMessageAccessor);
    }

    /// <summary>
    /// Validation indicate that a value is Taiwan landline phone number (市話).
    /// </summary>
    /// <param name="customErrorMessageFormat">The custom error message format. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, PhoneValidator> Phone(string customErrorMessageFormat) {
        return Phone((_column, _value) => string.Format(customErrorMessageFormat, _column, _value));
    }

    /// <summary>
    /// Validation indicate that a value is Taiwan landline phone number (市話).
    /// </summary>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <returns>The validator creator.</returns>
    public Func<string, string?, PhoneValidator> Phone(
        Func<string, string?, string>? customErrorMessageAccessor = null
    ) {
        return (column, value) => new(column, value, customErrorMessageAccessor);
    }
}
