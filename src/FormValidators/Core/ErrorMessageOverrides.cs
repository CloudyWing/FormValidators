using System;
using System.Collections.Generic;

namespace CloudyWing.FormValidators.Core;

/// <summary>
/// The accessors that override the global accessors of <see cref="ErrorMessageProvider" /> within a scope.
/// </summary>
/// <remarks>
/// Pass an instance to <see cref="ErrorMessageProvider.BeginScope(ErrorMessageOverrides)" />. Accessors left <see langword="null" /> are not overridden.
/// </remarks>
public sealed class ErrorMessageOverrides {
    /// <summary>
    /// Gets or sets the value is required accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsRequiredAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string>? ValueIsRequiredAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value greater or equal accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueGreaterOrEqualAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, object, string>? ValueGreaterOrEqualAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value less or equal accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueLessOrEqualAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, object, string>? ValueLessOrEqualAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value in range accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueInRangeAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, object, object, string>? ValueInRangeAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value is integer accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsIntegerAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string>? ValueIsIntegerAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value is number accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsNumberAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string>? ValueIsNumberAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value is date time accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsDateTimeAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string>? ValueIsDateTimeAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value length greater or equal accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueLengthGreaterOrEqualAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, long, string>? ValueLengthGreaterOrEqualAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value length less or equal accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueLengthLessOrEqualAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, long, string>? ValueLengthLessOrEqualAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value length in range accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueLengthInRangeAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, long, long, string>? ValueLengthInRangeAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value match regex accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueMatchRegexAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string>? ValueMatchRegexAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value is email accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsEmailAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string>? ValueIsEmailAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value is mobile phone accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsMobilePhoneAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, MobilePhoneFormats, string>? ValueIsMobilePhoneAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value is id card accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsIdCardAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, IdCardTypes, string>? ValueIsIdCardAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value compare another column value accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueCompareAnotherColumnValueAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string, string?, string>? ValueCompareAnotherColumnValueAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value less than another column value accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueLessThanAnotherColumnValueAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string, string?, bool, string>? ValueLessThanAnotherColumnValueAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value is url accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsUrlAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string>? ValueIsUrlAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value is i p address accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsIPAddressAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, IPAddressTypes, string>? ValueIsIPAddressAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value is credit card accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsCreditCardAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string>? ValueIsCreditCardAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value match custom rule accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueMatchCustomRuleAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string>? ValueMatchCustomRuleAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value is in allowed values accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsInAllowedValuesAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, IReadOnlyList<string>, string>? ValueIsInAllowedValuesAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value is guid accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsGuidAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string>? ValueIsGuidAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value is taiwan uniform number accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsTaiwanUniformNumberAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string>? ValueIsTaiwanUniformNumberAccessor { get; set; }

    /// <summary>
    /// Gets or sets the value is phone accessor used in the scope.
    /// </summary>
    /// <value>The accessor, or <see langword="null" /> to use <see cref="ErrorMessageProvider.ValueIsPhoneAccessor" /> of the outer scope or the global setting.</value>
    public Func<string, string?, string>? ValueIsPhoneAccessor { get; set; }

    internal ErrorMessageOverrides MergeOver(ErrorMessageOverrides? outer) {
        return new ErrorMessageOverrides {
            ValueIsRequiredAccessor = ValueIsRequiredAccessor ?? outer?.ValueIsRequiredAccessor,
            ValueGreaterOrEqualAccessor = ValueGreaterOrEqualAccessor ?? outer?.ValueGreaterOrEqualAccessor,
            ValueLessOrEqualAccessor = ValueLessOrEqualAccessor ?? outer?.ValueLessOrEqualAccessor,
            ValueInRangeAccessor = ValueInRangeAccessor ?? outer?.ValueInRangeAccessor,
            ValueIsIntegerAccessor = ValueIsIntegerAccessor ?? outer?.ValueIsIntegerAccessor,
            ValueIsNumberAccessor = ValueIsNumberAccessor ?? outer?.ValueIsNumberAccessor,
            ValueIsDateTimeAccessor = ValueIsDateTimeAccessor ?? outer?.ValueIsDateTimeAccessor,
            ValueLengthGreaterOrEqualAccessor = ValueLengthGreaterOrEqualAccessor ?? outer?.ValueLengthGreaterOrEqualAccessor,
            ValueLengthLessOrEqualAccessor = ValueLengthLessOrEqualAccessor ?? outer?.ValueLengthLessOrEqualAccessor,
            ValueLengthInRangeAccessor = ValueLengthInRangeAccessor ?? outer?.ValueLengthInRangeAccessor,
            ValueMatchRegexAccessor = ValueMatchRegexAccessor ?? outer?.ValueMatchRegexAccessor,
            ValueIsEmailAccessor = ValueIsEmailAccessor ?? outer?.ValueIsEmailAccessor,
            ValueIsMobilePhoneAccessor = ValueIsMobilePhoneAccessor ?? outer?.ValueIsMobilePhoneAccessor,
            ValueIsIdCardAccessor = ValueIsIdCardAccessor ?? outer?.ValueIsIdCardAccessor,
            ValueCompareAnotherColumnValueAccessor = ValueCompareAnotherColumnValueAccessor ?? outer?.ValueCompareAnotherColumnValueAccessor,
            ValueLessThanAnotherColumnValueAccessor = ValueLessThanAnotherColumnValueAccessor ?? outer?.ValueLessThanAnotherColumnValueAccessor,
            ValueIsUrlAccessor = ValueIsUrlAccessor ?? outer?.ValueIsUrlAccessor,
            ValueIsIPAddressAccessor = ValueIsIPAddressAccessor ?? outer?.ValueIsIPAddressAccessor,
            ValueIsCreditCardAccessor = ValueIsCreditCardAccessor ?? outer?.ValueIsCreditCardAccessor,
            ValueMatchCustomRuleAccessor = ValueMatchCustomRuleAccessor ?? outer?.ValueMatchCustomRuleAccessor,
            ValueIsInAllowedValuesAccessor = ValueIsInAllowedValuesAccessor ?? outer?.ValueIsInAllowedValuesAccessor,
            ValueIsGuidAccessor = ValueIsGuidAccessor ?? outer?.ValueIsGuidAccessor,
            ValueIsTaiwanUniformNumberAccessor = ValueIsTaiwanUniformNumberAccessor ?? outer?.ValueIsTaiwanUniformNumberAccessor,
            ValueIsPhoneAccessor = ValueIsPhoneAccessor ?? outer?.ValueIsPhoneAccessor
        };
    }
}
