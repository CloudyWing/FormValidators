namespace CloudyWing.FormValidators {
    using Core;

    public class CompareValidator : FormValidatorBase {
        public CompareValidator(string column, string value, string comparisonColumn, string comparisonValue, string customMessageFormat = null)
            : base(column, value, customMessageFormat) {
            ComparisonColumn = comparisonColumn;
            ComparisonValue = comparisonValue;
        }

        public string ComparisonColumn { get; }

        public string ComparisonValue { get; }

        public override string DefaultErrorMessageFormat => "「{0}」和「{1}」輸入不一致。";

        protected override bool ValidateValue() {
            // 是否有填資料由RequiredValidator驗證，所以沒填就不驗證
            return string.IsNullOrWhiteSpace(Value) || Value == ComparisonValue;
        }

        protected override string CreateErrorMessage() {
            return string.IsNullOrWhiteSpace(CustomErrorMessageFormat) ?
                string.Format(DefaultErrorMessageFormat, Column, ComparisonColumn) : string.Format(CustomErrorMessageFormat, Column, ComparisonColumn);
        }
    }
}