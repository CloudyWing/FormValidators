# FormValidators

用來驗證於輸入資料格式，適用於Web Form使用，不過Web Form本身有驗證控制項，所以此專案更多是用在記錄資料驗證的方式，偏向娛樂性質居多。

## 專案說明

Class Library：使用Standard 2.0開發。

FormValidators：主專案。

FormValidators.Tests：測試專案。

## 範例

作法一：取得全部驗證的錯誤訊息
```
// 建立容器，並將Validator加入批次裡
BatchFormValidator batchs = new BatchFormValidator();
// 驗證是否有值
batchs.Add(new RequiredValidator("欄位一", "值一"));
// 驗證基本原則，當值為Null、空格和空字串由RequiredValidator驗證
// 其他驗證遇到上述情況都回傳true
batchs.Add(new IntegerValidator("欄位一", "值一"));
// 一些特別情況可以使用TrueAssertValidator判斷第一個參數為true來表示驗證通過
// 也可用FalseAssertValidator判斷false為通過
batchs.Add(new TrueAssertValidator({bool}, "錯誤訊息"));

// 進行資料驗證
if (!batchs.Validate()) {
    // 驗證失敗使用batchs.ErrorMessage取得錯誤訊息，多個錯誤訊息使用<br />隔開
    // ErrorMessageWithBR等同於ErrorMessage
    // ErrorMessageWithLF，使用\n隔開
    // ErrorMessageWithNewLine，使用Environment.NewLine隔開
}
```

作法二：取得第一個錯誤訊息
```
// 建立容器，並將Validator加入批次裡
BatchStopIfErrorValidator batchs = new BatchStopIfErrorValidator();
// TrueAssert遇到true，驗證成功
batchs.Add(new TrueAssertValidator(true, "錯誤訊息一"));
// TrueAssert遇到false，驗證失敗
batchs.Add(new TrueAssertValidator(false, "錯誤訊息二"));
batchs.Add(new TrueAssertValidator(false, "錯誤訊息三"));
if (!batchs.Validate()) {
    // 驗證失敗使用batchs.ErrorMessage取得錯誤訊息，錯誤訊息為"錯誤訊息二"
}
```

可將兩者搭配使用
```
BatchFormValidator batchs = new BatchFormValidator {
    new BatchStopIfErrorValidator {
        new TrueAssertValidator(true, "錯誤訊息一"),
        new TrueAssertValidator(false, "錯誤訊息二"),
        new TrueAssertValidator(false, "錯誤訊息三")
    },
    new TrueAssertValidator(true, "錯誤訊息四"),
    new TrueAssertValidator(false, "錯誤訊息五"),
    new TrueAssertValidator(false, "錯誤訊息六")
};
if (!batchs.Validate()) {
    // batchs.ErrorMessage為"錯誤訊息二<br />錯誤訊息五<br />錯誤訊息六"
}
```