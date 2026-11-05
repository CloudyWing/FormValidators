using System;
using System.Collections.Generic;
using System.Globalization;

namespace CloudyWing.FormValidators.Core;

/// <summary>
/// The error message provider.
/// </summary>
/// <remarks>
/// The accessors are global, application-wide settings. Each <c>Set*Accessor</c> method replaces a single delegate
/// reference atomically and the new value is immediately visible to other threads, but replacing several accessors
/// is not a transaction. Configure the accessors once when the application starts.
/// </remarks>
public static class ErrorMessageProvider {
    // 預設值欄位必須宣告在可變欄位之前，靜態欄位依宣告順序初始化
    private static readonly string[] IdCardTypeNames = CreateIdCardTypeNames();
    private static readonly Func<string, string, string> DefaultValueIsRequiredAccessor = (column, value) => $"「{column}」欄位為必填。";
    private static readonly Func<string, string, object, string> DefaultValueGreaterOrEqualAccessor = (column, value, min) => {
        if (min is DateTime date) {
            return $"「{column}」必須大於等於「{FormatDate(date)}」。";
        } else {
            return $"「{column}」必須大於等於「{min}」。";
        }
    };
    private static readonly Func<string, string, object, string> DefaultValueLessOrEqualAccessor = (column, value, max) => {
        if (max is DateTime date) {
            return $"「{column}」必須小於等於「{FormatDate(date)}」。";
        } else {
            return $"「{column}」必須小於等於「{max}」。";
        }
    };
    private static readonly Func<string, string, object, object, string> DefaultValueInRangeAccessor = (column, value, min, max) => {
        if (max is DateTime date) {
            return $"「{column}」必須介於「{FormatDate(min)}」和「{FormatDate(date)}」之間。";
        } else {
            return $"「{column}」必須介於「{min}」和「{max}」之間。";
        }
    };
    private static readonly Func<string, string, string> DefaultValueIsIntegerAccessor = (column, value) => $"「{column}」必須為整數。";
    private static readonly Func<string, string, string> DefaultValueIsNumberAccessor = (column, value) => $"「{column}」必須為數值。";
    private static readonly Func<string, string, string> DefaultValueIsDateTimeAccessor = (column, value) => $"「{column}」必須為正確日期格式。";
    private static readonly Func<string, string, long, string> DefaultValueLengthGreaterOrEqualAccessor = (column, value, min) => $"「{column}」長度必須大於等於「{min}」。";
    private static readonly Func<string, string, long, string> DefaultValueLengthLessOrEqualAccessor = (column, value, max) => $"「{column}」長度必須小於等於「{max}」。";
    private static readonly Func<string, string, long, long, string> DefaultValueLengthInRangeAccessor = (column, value, min, max) => $"「{column}」長度必須介於「{min}」和「{max}」之間。";
    private static readonly Func<string, string, string> DefaultValueMatchRegexAccessor = (column, value) => $"「{column}」格式錯誤。";
    private static readonly Func<string, string, string> DefaultValueIsEmailAccessor = (column, value) => $"「{column}」必須為正確E-mail格式。";
    private static readonly Func<string, string, MobilePhoneFormats, string> DefaultValueIsMobilePhoneAccessor = (column, value, formats) => $"「{column}」必須為正確手機號碼格式。";
    private static readonly Func<string, string, IdCardTypes, string> DefaultValueIsIdCardAccessor = (column, value, types) => {
        int index = (int)types;
        string typeNames = index >= 0 && index < IdCardTypeNames.Length ? IdCardTypeNames[index] : JoinIdCardTypeNames(types);

        return $"「{column}」必須為正確的「{typeNames}」格式。";
    };
    private static readonly Func<string, string, string, string, string> DefaultValueCompareAnotherColumnValueAccessor = (column, value, comparisonColumn, comparisonValue) => $"「{column}」和「{comparisonColumn}」輸入不一致。";
    private static readonly Func<string, string, string, string, bool, string> DefaultValueLessThanAnotherColumnValueAccessor = (column, value, comparisonColumn, comparisonValue, allowedEqual) => $"「{column}」必須要小於{(allowedEqual ? "等於" : "")}「{comparisonColumn}」。";
    private static readonly Func<string, string, string> DefaultValueIsUrlAccessor = (column, value) => $"「{column}」必須為正確的網址格式。";
    private static readonly Func<string, string, IPAddressTypes, string> DefaultValueIsIPAddressAccessor = (column, value, types) => $"「{column}」必須為正確的IP位址格式。";
    private static readonly Func<string, string, string> DefaultValueIsCreditCardAccessor = (column, value) => $"「{column}」必須為正確的信用卡號碼。";
    private static volatile Func<string, string, string> valueIsRequiredAccessor = DefaultValueIsRequiredAccessor;
    private static volatile Func<string, string, object, string> valueGreaterOrEqualAccessor = DefaultValueGreaterOrEqualAccessor;
    private static volatile Func<string, string, object, string> valueLessOrEqualAccessor = DefaultValueLessOrEqualAccessor;
    private static volatile Func<string, string, object, object, string> valueInRangeAccessor = DefaultValueInRangeAccessor;
    private static volatile Func<string, string, string> valueIsIntegerAccessor = DefaultValueIsIntegerAccessor;
    private static volatile Func<string, string, string> valueIsNumberAccessor = DefaultValueIsNumberAccessor;
    private static volatile Func<string, string, string> valueIsDateTimeAccessor = DefaultValueIsDateTimeAccessor;
    private static volatile Func<string, string, long, string> valueLengthGreaterOrEqualAccessor = DefaultValueLengthGreaterOrEqualAccessor;
    private static volatile Func<string, string, long, string> valueLengthLessOrEqualAccessor = DefaultValueLengthLessOrEqualAccessor;
    private static volatile Func<string, string, long, long, string> valueLengthInRangeAccessor = DefaultValueLengthInRangeAccessor;
    private static volatile Func<string, string, string> valueMatchRegexAccessor = DefaultValueMatchRegexAccessor;
    private static volatile Func<string, string, string> valueIsEmailAccessor = DefaultValueIsEmailAccessor;
    private static volatile Func<string, string, MobilePhoneFormats, string> valueIsMobilePhoneAccessor = DefaultValueIsMobilePhoneAccessor;
    private static volatile Func<string, string, IdCardTypes, string> valueIsIdCardAccessor = DefaultValueIsIdCardAccessor;
    private static volatile Func<string, string, string, string, string> valueCompareAnotherColumnValueAccessor = DefaultValueCompareAnotherColumnValueAccessor;
    private static volatile Func<string, string, string, string, bool, string> valueLessThanAnotherColumnValueAccessor = DefaultValueLessThanAnotherColumnValueAccessor;
    private static volatile Func<string, string, string> valueIsUrlAccessor = DefaultValueIsUrlAccessor;
    private static volatile Func<string, string, IPAddressTypes, string> valueIsIPAddressAccessor = DefaultValueIsIPAddressAccessor;
    private static volatile Func<string, string, string> valueIsCreditCardAccessor = DefaultValueIsCreditCardAccessor;

    /// <summary>
    /// Gets the value is required accessor.
    /// </summary>
    /// <value>The value is required accessor. The arguments are column, value.</value>
    public static Func<string, string, string> ValueIsRequiredAccessor => valueIsRequiredAccessor;

    /// <summary>
    /// Gets the value greater or equal accessor.
    /// </summary>
    /// <value>The value greater or equal accessor. The arguments are column, value, min, max.</value>
    public static Func<string, string, object, string> ValueGreaterOrEqualAccessor => valueGreaterOrEqualAccessor;

    /// <summary>
    /// Gets the value less or equal accessor.
    /// </summary>
    /// <value>The value less or equal accessor. The arguments are column, value, max.</value>
    public static Func<string, string, object, string> ValueLessOrEqualAccessor => valueLessOrEqualAccessor;

    /// <summary>
    /// Gets the value in range accessor.
    /// </summary>
    /// <value>The value in range accessor. The arguments are column, value, min, max.</value>
    public static Func<string, string, object, object, string> ValueInRangeAccessor => valueInRangeAccessor;

    /// <summary>
    /// Gets the value is integer accessor.
    /// </summary>
    /// <value>The value is integer accessor. The arguments are column, value.</value>
    public static Func<string, string, string> ValueIsIntegerAccessor => valueIsIntegerAccessor;

    /// <summary>
    /// Gets the value is number accessor.
    /// </summary>
    /// <value>The value is number accessor. The arguments are column, value.</value>
    public static Func<string, string, string> ValueIsNumberAccessor => valueIsNumberAccessor;

    /// <summary>
    /// Gets the value is date time accessor.
    /// </summary>
    /// <value>The value is date time accessor. The arguments are column, value.</value>
    public static Func<string, string, string> ValueIsDateTimeAccessor => valueIsDateTimeAccessor;

    /// <summary>
    /// Gets the value length greater or equal accessor.
    /// </summary>
    /// <value>The value length greater or equal accessor. The arguments are column, value, min.</value>
    public static Func<string, string, long, string> ValueLengthGreaterOrEqualAccessor => valueLengthGreaterOrEqualAccessor;

    /// <summary>
    /// Gets the value length less or equal accessor.
    /// </summary>
    /// <value>The value length less or equal accessor. The arguments are column, value, max.</value>
    public static Func<string, string, long, string> ValueLengthLessOrEqualAccessor => valueLengthLessOrEqualAccessor;

    /// <summary>
    /// Gets the value length in range accessor.
    /// </summary>
    /// <value>The value length in range accessor. The arguments are column, value, min, max.</value>
    public static Func<string, string, long, long, string> ValueLengthInRangeAccessor => valueLengthInRangeAccessor;

    /// <summary>
    /// Gets the value match regex accessor.
    /// </summary>
    /// <value>The value match regex accessor. The arguments are column, value.</value>
    public static Func<string, string, string> ValueMatchRegexAccessor => valueMatchRegexAccessor;

    /// <summary>
    /// Gets the value is email accessor.
    /// </summary>
    /// <value>The value is email accessor. The arguments are column, value.</value>
    public static Func<string, string, string> ValueIsEmailAccessor => valueIsEmailAccessor;

    /// <summary>
    /// Gets the value is mobile phone accessor.
    /// </summary>
    /// <value>The value is mobile phone accessor. The arguments are column, value, mobile phone formats.</value>
    public static Func<string, string, MobilePhoneFormats, string> ValueIsMobilePhoneAccessor => valueIsMobilePhoneAccessor;

    /// <summary>
    /// Gets the value is identification card accessor.
    /// </summary>
    /// <value>The value is identification card accessor. The arguments are column, value, identification card types.</value>
    public static Func<string, string, IdCardTypes, string> ValueIsIdCardAccessor => valueIsIdCardAccessor;

    /// <summary>
    /// Gets the value compare another column value accessor.
    /// </summary>
    /// <value>The value compare another column value accessor. The arguments are column, value, comparison column, comparison value.</value>
    public static Func<string, string, string, string, string> ValueCompareAnotherColumnValueAccessor => valueCompareAnotherColumnValueAccessor;

    /// <summary>
    /// Gets the value less than another column value accessor.
    /// </summary>
    /// <value>The value less than another column value accessor. The arguments are column, value, comparison column, comparison value, allowed equal.</value>
    public static Func<string, string, string, string, bool, string> ValueLessThanAnotherColumnValueAccessor => valueLessThanAnotherColumnValueAccessor;

    /// <summary>
    /// Sets the value is required accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsRequiredAccessor(Func<string, string, string> accessor) {
        valueIsRequiredAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value greater or equal accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value, min.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueGreaterOrEqualAccessor(Func<string, string, object, string> accessor) {
        valueGreaterOrEqualAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value less or equal accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value, max.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueLessOrEqualAccessor(Func<string, string, object, string> accessor) {
        valueLessOrEqualAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value in range accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value, min, max.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueInRangeAccessor(Func<string, string, object, object, string> accessor) {
        valueInRangeAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value is integer accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsIntegerAccessor(Func<string, string, string> accessor) {
        valueIsIntegerAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value is number accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsNumberAccessor(Func<string, string, string> accessor) {
        valueIsNumberAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value is date time accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsDateTimeAccessor(Func<string, string, string> accessor) {
        valueIsDateTimeAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value length greater or equal accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value, min.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueLengthGreaterOrEqualAccessor(Func<string, string, long, string> accessor) {
        valueLengthGreaterOrEqualAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value length less or equal accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value, max.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueLengthLessOrEqualAccessor(Func<string, string, long, string> accessor) {
        valueLengthLessOrEqualAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value length in range accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value, min, max.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueLengthInRangeAccessor(Func<string, string, long, long, string> accessor) {
        valueLengthInRangeAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value match regex accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueMatchRegexAccessor(Func<string, string, string> accessor) {
        valueMatchRegexAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value is email accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsEmailAccessor(Func<string, string, string> accessor) {
        valueIsEmailAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value is mobile phone accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value, mobile phone formats.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsMobilePhoneAccessor(Func<string, string, MobilePhoneFormats, string> accessor) {
        valueIsMobilePhoneAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value is identification card accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value, identification card types.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsIdCardAccessor(Func<string, string, IdCardTypes, string> accessor) {
        valueIsIdCardAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value compare another column value accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value, comparison column, comparison value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueCompareAnotherColumnValueAccessor(Func<string, string, string, string, string> accessor) {
        valueCompareAnotherColumnValueAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Sets the value less than another column value accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value, comparison column, comparison value, allowed equal.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueLessThanAnotherColumnValueAccessor(Func<string, string, string, string, bool, string> accessor) {
        valueLessThanAnotherColumnValueAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Gets the value is URL accessor.
    /// </summary>
    /// <value>The value is URL accessor. The arguments are column, value.</value>
    public static Func<string, string, string> ValueIsUrlAccessor => valueIsUrlAccessor;

    /// <summary>
    /// Sets the value is URL accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsUrlAccessor(Func<string, string, string> accessor) {
        valueIsUrlAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Gets the value is IP address accessor.
    /// </summary>
    /// <value>The value is IP address accessor. The arguments are column, value, IP address types.</value>
    public static Func<string, string, IPAddressTypes, string> ValueIsIPAddressAccessor => valueIsIPAddressAccessor;

    /// <summary>
    /// Sets the value is IP address accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value, IP address types.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsIPAddressAccessor(Func<string, string, IPAddressTypes, string> accessor) {
        valueIsIPAddressAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Gets the value is credit card accessor.
    /// </summary>
    /// <value>The value is credit card accessor. The arguments are column, value.</value>
    public static Func<string, string, string> ValueIsCreditCardAccessor => valueIsCreditCardAccessor;

    /// <summary>
    /// Sets the value is credit card accessor.
    /// </summary>
    /// <param name="accessor">The accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException">accessor</exception>
    public static void SetValueIsCreditCardAccessor(Func<string, string, string> accessor) {
        valueIsCreditCardAccessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
    }

    /// <summary>
    /// Resets all accessors to their default values.
    /// </summary>
    internal static void ResetToDefaults() {
        valueIsRequiredAccessor = DefaultValueIsRequiredAccessor;
        valueGreaterOrEqualAccessor = DefaultValueGreaterOrEqualAccessor;
        valueLessOrEqualAccessor = DefaultValueLessOrEqualAccessor;
        valueInRangeAccessor = DefaultValueInRangeAccessor;
        valueIsIntegerAccessor = DefaultValueIsIntegerAccessor;
        valueIsNumberAccessor = DefaultValueIsNumberAccessor;
        valueIsDateTimeAccessor = DefaultValueIsDateTimeAccessor;
        valueLengthGreaterOrEqualAccessor = DefaultValueLengthGreaterOrEqualAccessor;
        valueLengthLessOrEqualAccessor = DefaultValueLengthLessOrEqualAccessor;
        valueLengthInRangeAccessor = DefaultValueLengthInRangeAccessor;
        valueMatchRegexAccessor = DefaultValueMatchRegexAccessor;
        valueIsEmailAccessor = DefaultValueIsEmailAccessor;
        valueIsMobilePhoneAccessor = DefaultValueIsMobilePhoneAccessor;
        valueIsIdCardAccessor = DefaultValueIsIdCardAccessor;
        valueCompareAnotherColumnValueAccessor = DefaultValueCompareAnotherColumnValueAccessor;
        valueLessThanAnotherColumnValueAccessor = DefaultValueLessThanAnotherColumnValueAccessor;
        valueIsUrlAccessor = DefaultValueIsUrlAccessor;
        valueIsIPAddressAccessor = DefaultValueIsIPAddressAccessor;
        valueIsCreditCardAccessor = DefaultValueIsCreditCardAccessor;
    }

    // 以 InvariantCulture 格式化，避免「/」被替換成文化特性的日期分隔符號或改用非西曆年份
    private static string FormatDate(object value) {
        return value is DateTime date
            ? date.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)
            : Convert.ToString(value, CultureInfo.CurrentCulture);
    }

    private static string[] CreateIdCardTypeNames() {
        string[] names = new string[(int)IdCardTypes.All + 1];

        for (int i = 0; i < names.Length; i++) {
            names[i] = JoinIdCardTypeNames((IdCardTypes)i);
        }

        return names;
    }

    private static string JoinIdCardTypeNames(IdCardTypes types) {
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

        return string.Join("或", typeNames);
    }
}
