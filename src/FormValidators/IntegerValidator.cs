using System;
using System.Globalization;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>Validation constrains the integer format of a value.</summary>
    public sealed class IntegerValidator : ComparableTypeValidator<long> {
        /// <summary>Initializes a new instance of the <see cref="IntegerValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="allowedThousands"></param>
        /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, min, max.</param>
        public IntegerValidator(string column, string value, bool allowedThousands = false, Func<string, string, long?, long?, string> customErrorMessageAccessor = null)
            : this(column, value, null, null, allowedThousands, customErrorMessageAccessor) { }

        /// <summary>Initializes a new instance of the <see cref="IntegerValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="allowedThousands">if set to <c>true</c> [allowed thousands].</param>
        /// <param name="customErrorMessageAccessor">The custom error message accessor.</param>
        public IntegerValidator(string column, string value, long? min, long? max, bool allowedThousands = false, Func<string, string, long?, long?, string> customErrorMessageAccessor = null)
            : base(column, value, min, max, customErrorMessageAccessor) {
            AllowedThousands = allowedThousands;
        }

        /// <summary>Gets a value indicating whether [allowed thousands].</summary>
        /// <value>
        ///   <c>true</c> if [allowed thousands]; otherwise, <c>false</c>.</value>
        public bool AllowedThousands { get; }

        /// <inheritdoc/>
        protected override Func<string, string, string> CastErrorMessageAccessor => ErrorMessageProvider.ValueIsIntegerAccessor;

        /// <inheritdoc/>
        protected override bool TryParse(string value, out long result) {
            NumberStyles styles = NumberStyles.Integer;

            if (AllowedThousands) {
                styles |= NumberStyles.AllowThousands;
            }

            return long.TryParse(value, styles, null, out result);
        }
    }
}
