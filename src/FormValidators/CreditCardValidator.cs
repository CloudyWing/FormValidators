using System;
using System.Linq;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// The credit card validator.
/// </summary>
public sealed class CreditCardValidator : BasicFormValidator {
    /// <summary>
    /// Initializes a new instance of the <see cref="CreditCardValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    public CreditCardValidator(string column, string value, Func<string, string, string> customErrorMessageAccessor = null)
        : base(column, value, customErrorMessageAccessor) {
    }

    /// <inheritdoc/>
    protected override Func<string, string, string> DefaultErrorMessageAccessor => ErrorMessageProvider.ValueIsCreditCardAccessor;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        if (string.IsNullOrWhiteSpace(Value)) {
            return true;
        }

        string normalized = Value.Replace("-", "").Replace(" ", "");

        // char.IsDigit 會接受全形與其他 Unicode 數字，Luhn 計算只適用 ASCII 數字
        if (!normalized.All(IsAsciiDigit) || normalized.Length < 13 || normalized.Length > 19) {
            return false;
        }

        return IsLuhnValid(normalized);
    }

    private static bool IsAsciiDigit(char c) {
        return c >= '0' && c <= '9';
    }

    private static bool IsLuhnValid(string digits) {
        int sum = 0;
        bool isEven = false;

        for (int i = digits.Length - 1; i >= 0; i--) {
            int digit = digits[i] - '0';

            if (isEven) {
                digit *= 2;
                if (digit > 9) {
                    digit -= 9;
                }
            }

            sum += digit;
            isEven = !isEven;
        }

        return sum % 10 == 0;
    }
}
