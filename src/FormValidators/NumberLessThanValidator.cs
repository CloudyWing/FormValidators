using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>Validate that an number value is less than another column value.</summary>
    public sealed class NumberLessThanValidator : LessThanValidator<decimal> {
        /// <summary>Initializes a new instance of the <see cref="NumberLessThanValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="comparisonColumn">The comparison column.</param>
        /// <param name="comparisonValue">The comparison value.</param>
        /// <param name="allowedEqual">if set to <c>true</c> [allowed equal].</param>
        /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, comparison column, comparison value, allowed equal.</param>
        public NumberLessThanValidator(string column, string value, string comparisonColumn, string comparisonValue,
            bool allowedEqual = true, Func<string, string, string, string, bool, string> customErrorMessageAccessor = null
        ) : base(column, value, comparisonColumn, comparisonValue, allowedEqual, customErrorMessageAccessor) { }

        /// <inheritdoc/>
        protected override bool TryParse(string value, out decimal result) {
            return decimal.TryParse(value, out result);
        }
    }
}
