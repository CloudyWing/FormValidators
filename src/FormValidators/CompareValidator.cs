using System;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>Compare the value of one column with the value of another column.</summary>
    /// <seealso cref="FormValidatorBase" />
    public class CompareValidator : FormValidatorBase {
        /// <summary>Initializes a new instance of the <see cref="CompareValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="comparisonColumn">The comparison column.</param>
        /// <param name="comparisonValue">The comparison value.</param>
        /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, comparison column, comparison value.</param>
        public CompareValidator(
            string column, string value, string comparisonColumn, string comparisonValue,
            Func<string, string, string, string, string> customErrorMessageAccessor = null
        ) : base(column, value) {
            ComparisonColumn = comparisonColumn;
            ComparisonValue = comparisonValue;
            CustomErrorMessageAccessor = customErrorMessageAccessor;
        }

        /// <summary>Gets the comparison column.</summary>
        /// <value>The comparison column.</value>
        public string ComparisonColumn { get; }

        /// <summary>Gets the comparison value.</summary>
        /// <value>The comparison value.</value>
        public string ComparisonValue { get; }

        /// <summary>Gets the custom range message format.</summary>
        /// <value>The custom range message format.</value>
        public Func<string, string, string, string, string> CustomErrorMessageAccessor { get; set; }

        /// <inheritdoc/>
        protected override string DefaultErrorMessage => ErrorMessageProvider.ValueCompareAnotherColumnValueAccessor(Column, Value, ComparisonColumn, ComparisonValue);

        /// <inheritdoc/>
        protected override string CustomErrorMessage => CustomErrorMessageAccessor(Column, Value, ComparisonColumn, ComparisonValue);

        /// <inheritdoc/>
        protected override bool HasCustomErrorMessage => CustomErrorMessageAccessor != null;

        /// <inheritdoc/>
        protected override bool ValidateValue() {
            // 是否有填資料由RequiredValidator驗證，所以沒填就不驗證
            return string.IsNullOrWhiteSpace(Value) || Value == ComparisonValue;
        }
    }
}
