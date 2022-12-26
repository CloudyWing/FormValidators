using System;

namespace CloudyWing.FormValidators.Core {
    /// <summary>The validation provider.</summary>
    public class ValidationProvider {
        /// <summary>Validation value is required.</summary>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, RequiredValidator> Required(string customMessageFormat = null) {
            return (column, value) => new RequiredValidator(column, value, customMessageFormat);
        }

        /// <summary>Validation value is integer.</summary>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, IntegerValidator> Integer(string customMessageFormat = null) {
            return (column, value) => new IntegerValidator(column, value, customMessageFormat);
        }

        /// <summary>Minimum integer value for the validation value.</summary>
        /// <param name="min">The minimum.</param>
        /// <param name="minValueErrorMessageFormat">The minimum value error message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, IntegerValidator> MinInt(int min, string minValueErrorMessageFormat = null) {
            return (column, value) => IntegerValidator.CreateMinValue(column, value, min, null, minValueErrorMessageFormat);
        }

        /// <summary>Max integer value for the validation value.</summary>
        /// <param name="max">The maximum.</param>
        /// <param name="maxValueErrorMessageFormat">The maximum value error message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, IntegerValidator> MaxInt(int max, string maxValueErrorMessageFormat = null) {
            return (column, value) => IntegerValidator.CreateMaxValue(column, value, max, null, maxValueErrorMessageFormat);
        }

        /// <summary>Integer range of validation values.</summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="errorMessageFormat">The error message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, IntegerValidator> IntRange(int min, int max, string errorMessageFormat = null) {
            return (column, value) => new IntegerValidator(column, value, min, max, null, errorMessageFormat);
        }

        /// <summary>Validation value is date time.</summary>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, DateTimeValidator> DateTime(string customMessageFormat = null) {
            return (column, value) => new DateTimeValidator(column, value, customMessageFormat);
        }

        /// <summary>Minimum date time value for the validation value.</summary>
        /// <param name="min">The minimum.</param>
        /// <param name="minDateTimeErrorMessageFormat">The minimum date time error message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, DateTimeValidator> MinDateTime(DateTime min, string minDateTimeErrorMessageFormat = null) {
            return (column, value) => DateTimeValidator.CreateMinDateTime(column, value, min, null, minDateTimeErrorMessageFormat);
        }

        /// <summary>Max date time value for the validation value.</summary>
        /// <param name="max">The maximum.</param>
        /// <param name="maxDateTimeErrorMessageFormat">The maximum date time error message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, DateTimeValidator> MaxDateTime(DateTime max, string maxDateTimeErrorMessageFormat = null) {
            return (column, value) => DateTimeValidator.CreateMaxDateTime(column, value, max, null, maxDateTimeErrorMessageFormat);
        }

        /// <summary>Date time range of validation values.</summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="errorMessageFormat">The error message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, DateTimeValidator> DateTimeRange(DateTime min, DateTime max, string errorMessageFormat = null) {
            return (column, value) => new DateTimeValidator(column, value, min, max, null, errorMessageFormat);
        }

        /// <summary>The minimum string length of the validation value.</summary>
        /// <param name="min">The minimum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, ValueLengthValidator> MinLength(int min, string customMessageFormat = null) {
            return (column, value) => ValueLengthValidator.CreateMinLength(column, value, min, customMessageFormat);
        }

        /// <summary>The maximum string length of the validation value.</summary>
        /// <param name="max">The maximum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, ValueLengthValidator> MaxLength(int max, string customMessageFormat = null) {
            return (column, value) => ValueLengthValidator.CreateMaxLength(column, value, max, customMessageFormat);
        }

        /// <summary>Validation value string length range.</summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, ValueLengthValidator> LengthRange(int min, int max, string customMessageFormat = null) {
            return (column, value) => new ValueLengthValidator(column, value, min, max, customMessageFormat);
        }

        /// <summary>Regex validation.</summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, RegexValidator> Regex(string pattern, string customMessageFormat = null) {
            return (column, value) => new RegexValidator(column, value, pattern, customMessageFormat);
        }

        /// <summary>Email validation.</summary>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, EmailValidator> Email(string customMessageFormat = null) {
            return (column, value) => new EmailValidator(column, value, customMessageFormat);
        }

        /// <summary>Mobile phone validation.</summary>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, MobilePhoneValidator> MobilePhone(string customMessageFormat = null) {
            return (column, value) => new MobilePhoneValidator(column, value, customMessageFormat);
        }

        /// <summary>Mobile phone validation.</summary>
        /// <param name="formats">The formats.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, MobilePhoneValidator> MobilePhone(MobilePhoneFormats formats, string customMessageFormat = null) {
            return (column, value) => new MobilePhoneValidator(column, value, formats, customMessageFormat);
        }

        /// <summary>Identifiers card validation.</summary>
        /// <param name="idTypes">The identifier types.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, IdCardValidator> IdCard(IdCardTypes idTypes = IdCardTypes.All, string customMessageFormat = null) {
            return (column, value) => new IdCardValidator(column, value, idTypes, customMessageFormat);
        }

        /// <summary>Compares validation.</summary>
        /// <param name="comparisonColumn">The comparison column.</param>
        /// <param name="comparisonValue">The comparison value.</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, CompareValidator> Compare(string comparisonColumn, string comparisonValue, string customMessageFormat = null) {
            return (column, value) => new CompareValidator(column, value, comparisonColumn, comparisonValue, customMessageFormat);
        }

        /// <summary>Integer less than validation.</summary>
        /// <param name="comparisonColumn">The comparison column.</param>
        /// <param name="comparisonValue">The comparison value.</param>
        /// <param name="allowedEquals">if set to <c>true</c> [allowed equals].</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, IntegerLessThanValidator> IntegerLessThan(
            string comparisonColumn, string comparisonValue, bool allowedEquals = true, string customMessageFormat = null
        ) {
            return (column, value) => new IntegerLessThanValidator(column, value, comparisonColumn, comparisonValue, allowedEquals, customMessageFormat);
        }

        /// <summary>Number less than validation.</summary>
        /// <param name="comparisonColumn">The comparison column.</param>
        /// <param name="comparisonValue">The comparison value.</param>
        /// <param name="allowedEquals">if set to <c>true</c> [allowed equals].</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, NumberLessThanValidator> NumberLessThan(
            string comparisonColumn, string comparisonValue, bool allowedEquals = true, string customMessageFormat = null
        ) {
            return (column, value) => new NumberLessThanValidator(column, value, comparisonColumn, comparisonValue, allowedEquals, customMessageFormat);
        }

        /// <summary>DateTime less than validation.</summary>
        /// <param name="comparisonColumn">The comparison column.</param>
        /// <param name="comparisonValue">The comparison value.</param>
        /// <param name="allowedEquals">if set to <c>true</c> [allowed equals].</param>
        /// <param name="customMessageFormat">The custom message format.</param>
        /// <returns>The validator creator.</returns>
        public Func<string, string, DateTimeLessThanValidator> DateTimeLessThan(
            string comparisonColumn, string comparisonValue, bool allowedEquals = true, string customMessageFormat = null
        ) {
            return (column, value) => new DateTimeLessThanValidator(column, value, comparisonColumn, comparisonValue, allowedEquals, customMessageFormat);
        }
    }

}
