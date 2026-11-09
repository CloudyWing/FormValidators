using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// The identity card validator.
/// </summary>
public sealed class IdCardValidator : FormValidatorBase {
    /// <summary>
    /// Initializes a new instance of the <see cref="IdCardValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="idCardType">Type of the identification card.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value, identification card types.</param>
    public IdCardValidator(string column, string? value,
        IdCardTypes idCardType = IdCardTypes.All, Func<string, string?, IdCardTypes, string>? customErrorMessageAccessor = null)
        : base(column, value) {
        IdCardType = idCardType;
        CustomErrorMessageAccessor = customErrorMessageAccessor;
    }

    private static readonly int[] Weights = { 1, 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 };
    private const string LetterMapping = "ABCDEFGHJKLMNPQRSTUVXYWZIO";

    /// <summary>
    /// Gets the type of the identification card.
    /// </summary>
    /// <value>The type of the identification card.</value>
    public IdCardTypes IdCardType { get; }

    /// <summary>
    /// Gets or sets the custom error message accessor.
    /// </summary>
    /// <value>The custom error message accessor.</value>
    public Func<string, string?, IdCardTypes, string>? CustomErrorMessageAccessor { get; }

    /// <inheritdoc/>
    protected override string DefaultErrorMessage => ErrorMessageProvider.ValueIsIdCardAccessor(Column, Value, IdCardType);

    /// <inheritdoc/>
    protected override string CustomErrorMessage => CustomErrorMessageAccessor!(Column, Value, IdCardType);

    /// <inheritdoc/>
    protected override bool HasCustomErrorMessage => CustomErrorMessageAccessor != null;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        if (StringUtils.IsNullOrWhiteSpace(Value)) {
            return true;
        }

        if (Value.Length != 10) {
            return false;
        }

        if (!IsAsciiLetter(Value[0]) || !IsAllowedSecondChar(ToUpper(Value[1]))) {
            return false;
        }

        for (int i = 2; i < Value.Length; i++) {
            if (Value[i] < '0' || Value[i] > '9') {
                return false;
            }
        }

        return ValidateCheckCode(Value);
    }

    private static bool IsAsciiLetter(char c) {
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
    }

    private bool IsAllowedSecondChar(char c) {
        return c switch {
            '1' or '2' => IdCardType.HasFlag(IdCardTypes.National),
            'A' or 'B' => IdCardType.HasFlag(IdCardTypes.Resident),
            'C' or 'D' => IdCardType.HasFlag(IdCardTypes.AlienResident),
            'Y' or 'X' => IdCardType.HasFlag(IdCardTypes.Homeless),
            '8' or '9' => IdCardType.HasFlag(IdCardTypes.NewResident),
            _ => false
        };
    }

    private static bool ValidateCheckCode(string value) {
        int sum = 0;

        int firstCharVal = ConvertToNumber(value[0]);
        sum += firstCharVal / 10 * Weights[0];
        sum += firstCharVal % 10 * Weights[1];

        int secondCharVal = ConvertToNumber(value[1]);
        sum += secondCharVal % 10 * Weights[2];

        for (int i = 2; i < 10; i++) {
            sum += (value[i] - '0') * Weights[i + 1];
        }

        return sum % 10 == 0;
    }

    private static int ConvertToNumber(char c) {
        if (c >= '0' && c <= '9') {
            return c - '0';
        }

        char upper = ToUpper(c);
        int index = LetterMapping.IndexOf(upper);

        if (index != -1) {
            return index + 10;
        }

        return 9;
    }

    private static char ToUpper(char c) {
        return (c >= 'a' && c <= 'z') ? (char)(c - 32) : c;
    }
}
