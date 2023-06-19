using System;
using System.Text.RegularExpressions;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators {
    /// <summary>The mobile phone validator.</summary>
    public sealed class MobilePhoneValidator : FormValidatorBase {
        private const string BasicPattern = @"^09\d{2}-?\d{3}-?\d{3}$";

        /// <summary>Initializes a new instance of the <see cref="MobilePhoneValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, mobile phone formats.</param>
        public MobilePhoneValidator(string column, string value, Func<string, string, MobilePhoneFormats, string> customErrorMessageAccessor = null)
            : this(column, value, MobilePhoneFormats.All, customErrorMessageAccessor) { }

        /// <summary>Initializes a new instance of the <see cref="MobilePhoneValidator" /> class.</summary>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        /// <param name="formats">The formats.</param>
        /// <param name="customErrorMessageAccessor">The custom error message accessor. The agrumts are column, value, mobile phone formats.</param>
        public MobilePhoneValidator(string column, string value, MobilePhoneFormats formats, Func<string, string, MobilePhoneFormats, string> customErrorMessageAccessor = null)
            : base(column, value) {
            Formats = formats;
            CustomErrorMessageAccessor = customErrorMessageAccessor;
        }

        /// <summary>Gets or sets the formats.</summary>
        /// <value>The formats.</value>
        public MobilePhoneFormats Formats { get; }

        /// <summary>Gets the regex pattern.</summary>
        /// <value>The regex pattern.</value>
        public string Pattern {
            get {
                if (Formats.HasFlag(MobilePhoneFormats.AllowContainDashes) && !Formats.HasFlag(MobilePhoneFormats.AllowWithoutDashes)) {
                    return BasicPattern.Replace("-?", "-");
                } else if (!Formats.HasFlag(MobilePhoneFormats.AllowContainDashes) && Formats.HasFlag(MobilePhoneFormats.AllowWithoutDashes)) {
                    return BasicPattern.Replace("-?", "");
                } else {
                    return BasicPattern;
                }
            }
        }

        /// <summary>Gets or sets the custom error message accessor.</summary>
        /// <value>The custom error message accessor.</value>
        public Func<string, string, MobilePhoneFormats, string> CustomErrorMessageAccessor { get; set; }

        /// <inheritdoc />
        protected override string DefaultErrorMessage => ErrorMessageProvider.ValueIsMobilePhoneAccessor(Column, Value, Formats);

        /// <inheritdoc />
        protected override string CustomErrorMessage => CustomErrorMessageAccessor(Column, Value, Formats);

        /// <inheritdoc />
        protected override bool HasCustomErrorMessage => CustomErrorMessageAccessor != null;

        /// <inheritdoc />
        protected override bool ValidateValue() {
            // 是否有填資料由RequiredValidator驗證，所以沒填就不驗證
            return string.IsNullOrWhiteSpace(Value) || Regex.IsMatch(Value, Pattern);
        }
    }
}
