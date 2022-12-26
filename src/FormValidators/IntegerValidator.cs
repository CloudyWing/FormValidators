using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>Validation constrains the integer format of a value.</summary>
    public sealed class IntegerValidator : ComparableTypeValidator<long> {
        /// <summary>Initializes a new instance of the <see cref="IntegerValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
        public IntegerValidator(string column, string value, Func<string, string, long?, long?, string> customErrorMessageAccessor = null)
            : this(column, value, null, null, customErrorMessageAccessor) { }

        /// <inheritdoc/>
        public IntegerValidator(string column, string value, long? min, long? max, Func<string, string, long?, long?, string> customErrorMessageAccessor = null)
            : base(column, value, min, max, customErrorMessageAccessor) { }

        /// <inheritdoc/>
        protected override Func<string, string, string> CastErrorMessageAccessor => ErrorMessageProvider.ValueIsIntegerAccessor;

        /// <inheritdoc/>
        protected override bool TryParse(string value, out long result) {
            return long.TryParse(value, out result);
        }
    }
}
