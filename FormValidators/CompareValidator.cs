namespace CloudyWing.FormValidators {
    using Core;

    public class CompareValidator : FormValidatorBase {
        public CompareValidator(string column, string value, string validationValue, string customMessageFormat = null)
            : base(column, value, customMessageFormat) {
            ValidationValue = validationValue;
        }

        public string ValidationValue { get; }

        public override string DefaultErrorMessageFormat => "「{0}」兩次輸入不一致。";

        protected override bool ValidateValue() {
            // 是否有填資料由RequiredValidator驗證，所以沒填就不驗證
            return string.IsNullOrWhiteSpace(Value) || Value == ValidationValue;
        }
    }
}