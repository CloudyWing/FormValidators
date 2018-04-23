namespace CloudyWing.FormValidators {

    public class RequiredValidator : FormValidatorBase {

        public RequiredValidator(string column, string value, string customMessageFormat = null)
            : base(column, value, customMessageFormat) { }

        public override string DefaultErrorMessageFormat => "「{0}」欄位為必填。";

        protected override bool ValidateValue() => !string.IsNullOrWhiteSpace(Value);
    }
}
