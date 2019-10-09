using System.Text.RegularExpressions;

namespace CloudyWing.FormValidators {
    public class IdCardValidator : FormValidatorBase {
        public IdCardValidator(string column, string value,
            IdCardTypes idCardType = IdCardTypes.All, string customMessageFormat = null)
            : base(column, value, customMessageFormat) {
            IdCardType = idCardType;
        }

        public IdCardTypes IdCardType { get; }

        public override string DefaultErrorMessageFormat => "「{0}」必須為正確身分證格式格式。";

        protected override bool ValidateValue() {
            if (string.IsNullOrWhiteSpace(Value)) {
                return true;
            }

            if (Value.Length != 10) {
                return false;
            }

            if (!Regex.IsMatch(Value, GetIdRegexPattern(), RegexOptions.IgnoreCase)) {
                return false;
            }

            return ValidateCheckCode();
        }

        private string GetIdRegexPattern() {
            string secondCharPattern = "";

            if (IdCardType.HasFlag(IdCardTypes.National)) {
                secondCharPattern += "12";
            }

            if (IdCardType.HasFlag(IdCardTypes.Resident)) {
                secondCharPattern += "AB";
            }

            if (IdCardType.HasFlag(IdCardTypes.AlienResident)) {
                secondCharPattern += "CD";
            }

            if (IdCardType.HasFlag(IdCardTypes.Homeless)) {
                secondCharPattern += "YX";
            }

            return $@"[A-Z][{secondCharPattern}][0-9]{{8}}";
        }

        private bool ValidateCheckCode() {
            int[] weights = { 1, 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 };
            int sum = 0;
            string numbers = ConvertToNumber(Value[0]).ToString()
                + (ConvertToNumber(Value[1]) % 10).ToString()
                + Value.Substring(2);

            for (int i = 0; i < numbers.Length; i++) {
                sum += int.Parse(numbers[i].ToString()) * weights[i];
            }

            return sum % 10 == 0;
        }

        private int ConvertToNumber(char fromChar) {
            string valueMap = "ABCDEFGHJKLMNPQRSTUVXYWZIO";

            return int.TryParse(fromChar.ToString(), out int result)
                ? result : (valueMap.IndexOf(fromChar) + 10);
        }
    }
}