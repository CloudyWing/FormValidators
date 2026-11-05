using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// Validates that a value is a Taiwan business uniform number (統一編號).
/// </summary>
/// <remarks>
/// The value must be 8 ASCII digits. Each digit is multiplied by the weights 1, 2, 1, 2, 1, 2, 4, 1 and the digits of each product are added.
/// The number is valid when the sum is divisible by 5, the rule used by the Ministry of Finance since 2023, which also accepts every number that is divisible by 10 under the previous rule.
/// When the 7th digit is 7, its product 28 can be counted as 1 or 0, so the sum plus 1 divisible by 5 is also valid.
/// </remarks>
public sealed class TaiwanUniformNumberValidator : BasicFormValidator {
    private static readonly int[] Weights = [1, 2, 1, 2, 1, 2, 4, 1];

    /// <summary>
    /// Initializes a new instance of the <see cref="TaiwanUniformNumberValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    public TaiwanUniformNumberValidator(string column, string? value, Func<string, string?, string>? customErrorMessageAccessor = null)
        : base(column, value, customErrorMessageAccessor) {
    }

    /// <inheritdoc/>
    protected override Func<string, string?, string> DefaultErrorMessageAccessor => ErrorMessageProvider.ValueIsTaiwanUniformNumberAccessor;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        if (StringUtils.IsNullOrWhiteSpace(Value)) {
            return true;
        }

        if (Value.Length != Weights.Length) {
            return false;
        }

        int sum = 0;

        for (int i = 0; i < Value.Length; i++) {
            char c = Value[i];

            if (c < '0' || c > '9') {
                return false;
            }

            int product = (c - '0') * Weights[i];
            sum += (product / 10) + (product % 10);
        }

        // 財政部自 2023 年起將檢查邏輯由可被 10 整除放寬為可被 5 整除
        if (sum % 5 == 0) {
            return true;
        }

        // 第 7 碼為 7 時乘積 28 的位數和 10 可再視為 1 或 0
        return Value[6] == '7' && (sum + 1) % 5 == 0;
    }
}
