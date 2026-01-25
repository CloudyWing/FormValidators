using System;
using System.Collections.Generic;

namespace CloudyWing.FormValidators.Core;

/// <summary>The error message provider</summary>
public static class ErrorMessageProvider {
    /// <summary>Gets the value is required accessor.</summary>
    /// <value>The value is required accessor. The agrumts are column, value.</value>
    public static Func<string, string, string> ValueIsRequiredAccessor { get; private set; } = (column, value) => $"「{column}」欄位為必填。";

    /// <summary>Gets the value greater or equal accessor.</summary>
    /// <value>The value greater or equal accessor. The agrumts are column, value, min, max.</value>
    public static Func<string, string, object, string> ValueGreaterOrEqualAccessor { get; private set; } = (column, value, min) => {
        if (min is DateTime date) {
            return $"「{column}」必須大於等於「{min:yyyy/MM/dd}」。";
        } else {
            return $"「{column}」必須大於等於「{min}」。";
        }
    };

    /// <summary>Gets the value less or equal accessor.</summary>
    /// <value>The value less or equal accessor. The arguments are column, value, max.</value>
    public static Func<string, string, object, string> ValueLessOrEqualAccessor { get; private set; } = (column, value, max) => {
        if (max is DateTime date) {
            return $"「{column}」必須小於等於「{max:yyyy/MM/dd}」。";
        } else {
            return $"「{column}」必須小於等於「{max}」。";
        }
    };

    /// <summary>Gets the value in range accessor.</summary>
    /// <value>The value in range accessor. The arguments are column, value, min, max.</value>
    public static Func<string, string, object, object, string> ValueInRangeAccessor { get; private set; } = (column, value, min, max) => {
        if (max is DateTime date) {
            return $"「{column}」必須介於「{min:yyyy/MM/dd}」和「{max:yyyy/MM/dd}」之間。";
        } else {
            return $"「{column}」必須介於「{min}」和「{max}」之間。";
        }
    };

    /// <summary>Gets the value is integer accessor.</summary>
    /// <value>The value is integer accessor. The arguments are column, value.</value>
    public static Func<string, string, string> ValueIsIntegerAccessor { get; private set; } = (column, value) => $"「{column}」必須為整數。";

    /// <summary>Gets the value is number accessor.</summary>
    /// <value>The value is number accessor. The arguments are column, value.</value>
    public static Func<string, string, string> ValueIsNumberAccessor { get; private set; } = (column, value) => $"「{column}」必須為數值。";

    /// <summary>Gets the value is date time accessor.</summary>
    /// <value>The value is date time accessor. The arguments are column, value.</value>
    public static Func<string, string, string> ValueIsDateTimeAccessor { get; private set; } = (column, value) => $"「{column}」必須為正確日期格式。";

    /// <summary>Gets the value length greater or equal accessor.</summary>
    /// <value>The value length greater or equal accessor. The arguments are column, value, min.</value>
    public static Func<string, string, long, string> ValueLengthGreaterOrEqualAccessor { get; private set; } = (column, value, min) => $"「{column}」長度必須大於等於「{min}」。";

    /// <summary>Gets the value length less or equal accessor.</summary>
    /// <value>The value length less or equal accessor. The arguments are column, value, max.</value>
    public static Func<string, string, long, string> ValueLengthLessOrEqualAccessor { get; private set; } = (column, value, max) => $"「{column}」長度必須小於等於「{max}」。";

    /// <summary>Gets the value length in range accessor.</summary>
    /// <value>The value length in range accessor. The arguments are column, value, min, max.</value>
    public static Func<string, string, long, long, string> ValueLengthInRangeAccessor { get; private set; } = (column, value, min, max) => $"「{column}」長度必須介於「{min}」和「{max}」之間。";

    /// <summary>Gets the value match regex accessor.</summary>
    /// <value>The value match regex accessor. The arguments are column, value.</value>
    public static Func<string, string, string> ValueMatchRegexAccessor { get; private set; } = (column, value) => $"「{column}」格式錯誤。";

    /// <summary>Gets the value is email accessor.</summary>
    /// <value>The value is email accessor. The arguments are column, value.</value>
    public static Func<string, string, string> ValueIsEmailAccessor { get; private set; } = (column, value) => $"「{column}」必須為正確E-mail格式。";

    /// <summary>Gets the value is mobile phone accessor.</summary>
    /// <value>The value is mobile phone accessor. The arguments are column, value, mobile phone formats.</value>
    public static Func<string, string, MobilePhoneFormats, string> ValueIsMobilePhoneAccessor { get; private set; } = (column, value, formats) => $"「{column}」必須為正確手機號碼格式。";

    /// <summary>Gets the value is identification card accessor.</summary>
    /// <value>The value is identification card accessor. The arguments are column, value, identification card types.</value>
    public static Func<string, string, IdCardTypes, string> ValueIsIdCardAccessor { get; private set; } = (column, value, types) => {
        List<string> typeNames = [];
        if (types.HasFlag(IdCardTypes.National)) {
            typeNames.Add("國民身分證號");
        }

        if (types.HasFlag(IdCardTypes.Resident)) {
            typeNames.Add("臺灣地區居留證統一證號");
        }

        if (types.HasFlag(IdCardTypes.AlienResident)) {
            typeNames.Add("外僑居留證統一證號");
        }

        if (types.HasFlag(IdCardTypes.Homeless)) {
            typeNames.Add("遊民證號");
        }

        if (types.HasFlag(IdCardTypes.NewResident)) {
            typeNames.Add("新式外來人口統一證號");
        }

        return $"「{column}」必須為正確的「{string.Join("或", typeNames)}」格式。";
    };

    /// <summary>Gets the value compare another column value accessor.</summary>
    /// <value>The value compare another column value accessor. The arguments are column, value, comparison column, comparison value.</value>
    public static Func<string, string, string, string, string> ValueCompareAnotherColumnValueAccessor { get; private set; } = (column, comparisonColumn, value, comparisonValue) => $"「{column}」和「{comparisonColumn}」輸入不一致。";

    /// <summary>Gets the value less than another column value accessor.</summary>
    /// <value>The value less than another column value accessor. The arguments are column, value, comparison column, comparison value, allowed equal.</value>
    public static Func<string, string, string, string, bool, string> ValueLessThanAnotherColumnValueAccessor { get; private set; } = (column, comparisonColumn, value, comparisonValue, allowedEqual) => $"「{column}」必須要小於{(allowedEqual ? "等於" : "")}「{comparisonColumn}」。";

    /// <summary>Sets the value is required accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsRequiredAccessor(Func<string, string, string> accessor) {
        ValueIsRequiredAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value greater or equal accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value, min.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueGreaterOrEqualAccessor(Func<string, string, object, string> accessor) {
        ValueGreaterOrEqualAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value less or equal accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value, max.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueLessOrEqualAccessor(Func<string, string, object, string> accessor) {
        ValueLessOrEqualAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value in range accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value, min, max.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueInRangeAccessor(Func<string, string, object, object, string> accessor) {
        ValueInRangeAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value is integer accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsIntegerAccessor(Func<string, string, string> accessor) {
        ValueIsIntegerAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value is number accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsNumberAccessor(Func<string, string, string> accessor) {
        ValueIsNumberAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value is date time accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsDateTimeAccessor(Func<string, string, string> accessor) {
        ValueIsDateTimeAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value length greater or equal accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value, min.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueLengthGreaterOrEqualAccessor(Func<string, string, long, string> accessor) {
        ValueLengthGreaterOrEqualAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value length less or equal accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value, max.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueLengthLessOrEqualAccessor(Func<string, string, long, string> accessor) {
        ValueLengthLessOrEqualAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value length in range accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value, min, max.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueLengthInRangeAccessor(Func<string, string, long, long, string> accessor) {
        ValueLengthInRangeAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value match regex accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueMatchRegexAccessor(Func<string, string, string> accessor) {
        ValueMatchRegexAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value is email accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsEmailAccessor(Func<string, string, string> accessor) {
        ValueIsEmailAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value is mobile phone accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value, mobile phone formats.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsMobilePhoneAccessor(Func<string, string, MobilePhoneFormats, string> accessor) {
        ValueIsMobilePhoneAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value is identification card accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value, identification card types.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsIdCardAccessor(Func<string, string, IdCardTypes, string> accessor) {
        ValueIsIdCardAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value compare another column value accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value, comparison column, comparison value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueCompareAnotherColumnValueAccessor(Func<string, string, string, string, string> accessor) {
        ValueCompareAnotherColumnValueAccessor = accessor ?? throw new(nameof(accessor));
    }

    /// <summary>Sets the value less than another column value accessor.</summary>
    /// <param name="accessor">The accessor. The arguments are column, value, comparison column, comparison value, allowed equal.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueLessThanAnotherColumnValueAccessor(Func<string, string, string, string, bool, string> accessor) {
        ValueLessThanAnotherColumnValueAccessor = accessor ?? throw new(nameof(accessor));
    }
}
