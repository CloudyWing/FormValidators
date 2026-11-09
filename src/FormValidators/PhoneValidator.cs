using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// Validates that a value is a Taiwan landline phone number (市話).
/// </summary>
/// <remarks>
/// <para>
/// The number must start with an area code from <c>02</c> to <c>08</c> and contain 9 digits in total,
/// or 10 digits when the area code starts with <c>02</c> or <c>04</c>, such as <c>02-2345-6789</c>, <c>049-234-5678</c> or <c>037-123456</c>.
/// </para>
/// <para>
/// The area code may be enclosed in parentheses, such as <c>(02)2345-6789</c>. Up to two hyphens or spaces may separate the digits,
/// but separators cannot be consecutive or at the beginning or the end.
/// </para>
/// <para>
/// Mobile numbers (<c>09</c>), toll-free numbers such as <c>0800</c>, the country code <c>+886</c> and extensions are not accepted.
/// </para>
/// </remarks>
public sealed class PhoneValidator : BasicFormValidator {
    private const int MaxSeparatorCount = 2;

    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    public PhoneValidator(string column, string? value, Func<string, string?, string>? customErrorMessageAccessor = null)
        : base(column, value, customErrorMessageAccessor) {
    }

    /// <inheritdoc/>
    protected override Func<string, string?, string> DefaultErrorMessageAccessor => ErrorMessageProvider.ValueIsPhoneAccessor;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        return StringUtils.IsNullOrWhiteSpace(Value) || IsLandline(Value);
    }

    private static bool IsLandline(string value) {
        char[] digits = new char[10];
        int digitCount = 0;
        int index = 0;

        if (value[0] == '(') {
            int closeIndex = value.IndexOf(')');

            // 括號內為 2 到 4 碼的區碼
            if (closeIndex < 3 || closeIndex > 5) {
                return false;
            }

            for (index = 1; index < closeIndex; index++) {
                if (!TryAddDigit(value[index], digits, ref digitCount)) {
                    return false;
                }
            }

            index = closeIndex + 1;

            if (index < value.Length && IsSeparator(value[index])) {
                index++;
            }

            if (index >= value.Length) {
                return false;
            }
        }

        int separatorCount = 0;
        bool isPreviousSeparator = true;

        for (; index < value.Length; index++) {
            char c = value[index];

            if (IsSeparator(c)) {
                if (isPreviousSeparator || ++separatorCount > MaxSeparatorCount) {
                    return false;
                }

                isPreviousSeparator = true;
            } else if (TryAddDigit(c, digits, ref digitCount)) {
                isPreviousSeparator = false;
            } else {
                return false;
            }
        }

        if (isPreviousSeparator || digits[0] != '0' || digits[1] < '2' || digits[1] > '8') {
            return false;
        }

        return digitCount == 9 || (digitCount == 10 && (digits[1] == '2' || digits[1] == '4'));
    }

    private static bool IsSeparator(char c) {
        return c == '-' || c == ' ';
    }

    private static bool TryAddDigit(char c, char[] digits, ref int digitCount) {
        if (c < '0' || c > '9' || digitCount == digits.Length) {
            return false;
        }

        digits[digitCount++] = c;
        return true;
    }
}
