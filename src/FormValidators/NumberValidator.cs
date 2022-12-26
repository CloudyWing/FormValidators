using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>Validation constrains the number format of a value.</summary>
    public sealed class NumberValidator : ComparableTypeValidator<decimal> {
        /// <summary>Initializes a new instance of the <see cref="NumberValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
        public NumberValidator(string column, string value, Func<string, string, decimal?, decimal?, string> customErrorMessageAccessor = null)
            : this(column, value, null, null, customErrorMessageAccessor) { }

        /// <inheritdoc/>
        public NumberValidator(string column, string value, decimal? min, decimal? max, Func<string, string, decimal?, decimal?, string> customErrorMessageAccessor = null)
            : base(column, value, min, max, customErrorMessageAccessor) { }

        /// <inheritdoc/>
        protected override Func<string, string, string> CastErrorMessageAccessor => ErrorMessageProvider.ValueIsNumberAccessor;

        /// <inheritdoc/>
        protected override bool TryParse(string value, out decimal result) {
            return decimal.TryParse(value, out result);
        }
    }
}
