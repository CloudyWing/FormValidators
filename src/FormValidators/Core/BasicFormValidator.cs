using System;

namespace CloudyWing.FormValidators.Core {
    /// <summary>The basic form validator abstract class.</summary>
    /// <seealso cref="FormValidatorBase" />
    public abstract class BasicFormValidator : FormValidatorBase {
        /// <summary>Initializes a new instance of the <see cref="FormValidatorBase" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value.</param>
        public BasicFormValidator(string column, string value, Func<string, string, string> customErrorMessageAccessor)
            : base(column, value) {
            CustomErrorMessageAccessor = customErrorMessageAccessor;
        }

        /// <summary>Gets the get default error message.</summary>
        /// <value>The get default error message.</value>
        protected abstract Func<string, string, string> DefaultErrorMessageAccessor { get; }

        /// <summary>Gets or sets the custom error message accessor.</summary>
        /// <value>The custom error message accessor.</value>
        public Func<string, string, string> CustomErrorMessageAccessor { get; }

        /// <inheritdoc/>
        protected override string DefaultErrorMessage => DefaultErrorMessageAccessor(Column, Value);

        /// <inheritdoc/>
        protected override string CustomErrorMessage => CustomErrorMessageAccessor(Column, Value);

        /// <inheritdoc/>
        protected override bool HasCustomErrorMessage => CustomErrorMessageAccessor != null;
    }
}
