using System;

namespace CloudyWing.FormValidators.Core {

    public class ValidationProvider {
        public Func<string, string, RequiredValidator> Required(string customMessageFormat = null)
            => (column, value) => new RequiredValidator(column, value, customMessageFormat);

        public Func<string, string, IntegerValidator> Integer(string customMessageFormat = null)
            => (column, value) => new IntegerValidator(column, value, customMessageFormat);

        public Func<string, string, IntegerValidator> MinInt(int min, string minValueErrorMessageFormat = null)
            => (column, value) => IntegerValidator.CreateMinValue(column, value, min, null, minValueErrorMessageFormat);

        public Func<string, string, IntegerValidator> MaxInt(int max, string maxValueErrorMessageFormat = null)
            => (column, value) => IntegerValidator.CreateMaxValue(column, value, max, null, maxValueErrorMessageFormat);

        public Func<string, string, IntegerValidator> IntRange(int min, int max, string errorMessageFormat = null)
            => (column, value) => new IntegerValidator(column, value, min, max, null, errorMessageFormat);

        public Func<string, string, DateTimeValidator> DateTime(string customMessageFormat = null)
            => (column, value) => new DateTimeValidator(column, value, customMessageFormat);

        public Func<string, string, DateTimeValidator> MinDateTime(DateTime min, string minDateTimeErrorMessageFormat = null)
            => (column, value) => DateTimeValidator.CreateMinDateTime(column, value, min, null, minDateTimeErrorMessageFormat);

        public Func<string, string, DateTimeValidator> MaxDateTime(DateTime max, string maxDateTimeErrorMessageFormat = null)
            => (column, value) => DateTimeValidator.CreateMaxDateTime(column, value, max, null, maxDateTimeErrorMessageFormat);

        public Func<string, string, DateTimeValidator> DateTimeRange(DateTime min, DateTime max, string errorMessageFormat = null)
            => (column, value) => new DateTimeValidator(column, value, min, max, null, errorMessageFormat);

        public Func<string, string, ValueLengthValidator> MinLength(int min, string customMessageFormat = null)
            => (column, value) => ValueLengthValidator.CreateMinLength(column, value, min, customMessageFormat);

        public Func<string, string, ValueLengthValidator> MaxLength(int max, string customMessageFormat = null)
            => (column, value) => ValueLengthValidator.CreateMaxLength(column, value, max, customMessageFormat);

        public Func<string, string, ValueLengthValidator> LengthRange(int min, int max, string customMessageFormat = null)
            => (column, value) => new ValueLengthValidator(column, value, min, max, customMessageFormat);

        public Func<string, string, RegexValidator> Regex(string pattern, string customMessageFormat = null)
            => (column, value) => new RegexValidator(column, value, pattern, customMessageFormat);

        public Func<string, string, EmailValidator> Email(string customMessageFormat = null)
            => (column, value) => new EmailValidator(column, value, customMessageFormat);

        public Func<string, string, MobilePhoneValidator> MobilePhone(string customMessageFormat = null)
            => (column, value) => new MobilePhoneValidator(column, value, customMessageFormat);

        public Func<string, string, IdCardValidator> IdCard(IdCardTypes idTypes = IdCardTypes.All, string customMessageFormat = null)
            => (column, value) => new IdCardValidator(column, value, idTypes, customMessageFormat);

        public Func<string, string, CompareValidator> Compare(string validationValue, string customMessageFormat = null)
            => (column, value) => new CompareValidator(column, value, validationValue, customMessageFormat);

        public Func<string, string, IntegerLessThanValidator> IntegerLessThan(
            string comparisonColumn, string comparisonValue, bool allowedEquals, string customMessageFormat = null
        ) => (column, value) => new IntegerLessThanValidator(column, value, comparisonColumn, comparisonValue, allowedEquals, customMessageFormat);

        public Func<string, string, NumberLessThanValidator> NumberLessThan(
            string comparisonColumn, string comparisonValue, bool allowedEquals, string customMessageFormat = null
        ) => (column, value) => new NumberLessThanValidator(column, value, comparisonColumn, comparisonValue, allowedEquals, customMessageFormat);

        public Func<string, string, DateTimeLessThanValidator> DateTimeLessThan(
            string comparisonColumn, string comparisonValue, bool allowedEquals, string customMessageFormat = null
        ) => (column, value) => new DateTimeLessThanValidator(column, value, comparisonColumn, comparisonValue, allowedEquals, customMessageFormat);
    }

}