using System;
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

        int sum = 0;
        int digitCount = 0;
        bool isEven = false;

        // 由右往左單次走訪，略過「-」與空白；char.IsDigit 會接受全形與其他 Unicode 數字，Luhn 計算只適用 ASCII 數字
        for (int i = Value.Length - 1; i >= 0; i--) {
            char c = Value[i];

            if (c == '-' || c == ' ') {
                continue;
            }

            if (c < '0' || c > '9') {
                return false;
            }

            int digit = c - '0';

            if (isEven) {
                digit *= 2;
                if (digit > 9) {
                    digit -= 9;
                }
            }

            sum += digit;
            isEven = !isEven;
            digitCount++;
        }

        return digitCount >= 13 && digitCount <= 19 && sum % 10 == 0;
    }
}
