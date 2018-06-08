# FormValidators

用來驗證於輸入資料格式，適用於Web Form使用，不過Web Form本身有驗證控制項，所以此專案更多是用在記錄資料驗證的方式，偏向娛樂性質居多。

## 專案說明

Class Library：使用Standard 2.0開發。

FormValidators：主專案。

FormValidators.Tests：測試專案。

## 範例

```
// 建立容器，並將Validator加入容器裡
FormValidatorCollection fvc = new FormValidatorCollection();
// 驗證是否有值
fvc.Add(new RequiredValidator("欄位一", "值一"));
// 驗證基本原則，當值為Null、空格和空字串由RequiredValidator驗證
// 其他驗證遇到上述情況都回傳true
fvc.Add(new IntegerValidator("欄位一", "值一"));
// 一些特別情況可以使用TrueAssertValidator判斷第一個參數為true來表示驗證通過
// 也可用FalseAssertValidator判斷false為通過
fvc.Add(new TrueAssertValidator({bool}, "錯誤訊息"));

// 進行資料驗證
if (!fvc.Validate()) {
    // 驗證失敗使用fvc.ErrorMessage取得錯誤訊息，多個錯誤訊息使用<br />隔開
    // ErrorMessageWithBR等同於ErrorMessage
    // ErrorMessageWithLF，使用\n隔開
    // ErrorMessageWithNewLine，使用Environment.NewLine隔開
    
}
```
