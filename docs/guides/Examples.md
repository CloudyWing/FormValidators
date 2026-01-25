# Examples

## 驗證全部項目，並取得全部驗證的錯誤訊息
```csharp
// 建立容器，並將 Validator加入 Bulk 裡
BulkValidator validators = new BulkValidator();
// 驗證是否有值
validators.Add(new RequiredValidator("欄位一", "值一"));
// 驗證基本原則，當值為 Null、空格和空字串由RequiredValidator驗證
// 其他驗證遇到上述情況都回傳 true
validators.Add(new IntegerValidator("欄位一", "值一"));
// 一些特別情況可以使用 TrueAssertValidator 判斷第一個參數為 true 來表示驗證通過
// 也可用 FalseAssertValidator 判斷 false 為通過
validators.Add(new TrueAssertValidator({bool}, "錯誤訊息"));

// 進行資料驗證
if (!validators.Validate()) {
    // 驗證失敗使用 validators.ErrorMessage 取得錯誤訊息，多個錯誤訊息使用 <br /> 隔開
    // ErrorMessageWithBR 等同於 ErrorMessage
    // ErrorMessageWithLF，使用 \n 隔開
    // ErrorMessageWithNewLine，使用 Environment.NewLine 隔開
}
```

## 驗證失敗後，停止驗證後續項目，只取得第一個錯誤訊息
```csharp
// 建立容器，並將 Validator 加入批量裡
BulkValidator validators = new BulkValidator(true);
// TrueAssert 遇到 true，驗證成功
validators.Add(new TrueAssertValidator(true, "錯誤訊息一"));
// TrueAssert 遇到 false，驗證失敗
validators.Add(new TrueAssertValidator(false, "錯誤訊息二"));
validators.Add(new TrueAssertValidator(false, "錯誤訊息三"));
if (!validators.Validate()) {
    // 驗證失敗使用 validators.ErrorMessage 取得錯誤訊息，錯誤訊息為「錯誤訊息二」"
}
```

## 混合使用
```csharp
BulkValidator validators = new BulkValidator {
    new BulkValidator(true) {
        new TrueAssertValidator(true, "錯誤訊息一"),
        new TrueAssertValidator(false, "錯誤訊息二"),
        new TrueAssertValidator(false, "錯誤訊息三")
    },
    new TrueAssertValidator(true, "錯誤訊息四"),
    new TrueAssertValidator(false, "錯誤訊息五"),
    new TrueAssertValidator(false, "錯誤訊息六")
};
if (!validators.Validate()) {
    // validators.ErrorMessage 為 "錯誤訊息二<br />錯誤訊息五<br />錯誤訊息六"
}
```

## 使用 BulkValidator(Action\<ValidatorConfiguration\> configure) 簡化建立程式碼
```csharp
BulkValidator validators = new BulkValidator(cfg => {
    cfg.Add("欄位一", "值一", opt => opt.Required()); // 增加一個驗證
    cfg.Add("欄位二", "值二", opt => opt.Required(), opt => opt.DateTime()); // 增加多個驗證
    cfg.AddIf(condition, "欄位三", "值三", opt => opt.Required(), opt => opt.DateTime()); // condition 為 true 時，才會驗證
    cfg.AddTrueAssert(true, "錯誤訊息");
    cfg.AddBulk(_cfg => {
         _cfg.Add("欄位四", "值四", opt => opt.Required());
    });
});
```