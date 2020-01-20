# FormValidators

用於驗證資料格式，適用於如Web Form控制項等輸入值皆為字串之場合。
不過Web Form本身有Validation Controls，所以除非捨棄Validation Controls，自行定義驗證方式，否則此專案更多是用於記錄資料驗證的方式，偏向娛樂性質居多。

## Supported Frameworks
* .NET Standard 2.0
* .NET Framework 4.5

## Documentation

### FormValidators：

* 基本驗證
  * RequiredValidator：Value的必填驗證，如果是Null、空字串或空格，視為沒有值。
  * ValueLengthValidator：Value的長度驗證。
  * BulkValidator：批量驗證，參數isStoppedIfFail可控制驗證不通過時，是否繼續後續驗證。
* 型別驗證
  * IntegerValidator：整數和極限值驗證。
  * NumberValidator：數值和極限值驗證。
  * DateTimeValidator：日期和極限值驗證。
* 比較驗證
  * CompareValidator：比較兩欄位的值是否相等。
  * IntegerLessThanValidator：整數起訖值驗證，目標值必須小於驗證值；allowedEquals為true時，可以等於。
  * NumberLessThanValidator：數值起訖值驗證，目標值必須小於驗證值；allowedEquals為true時，可以等於。
  * DateTimeLessThanValidator：日期起訖值驗證，目標值必須小於驗證值；allowedEquals為true時，可以等於。
* 格式驗證
  * RegexValidator：使用正規式驗證Value。
  * EmailValidator：Email格式驗證。
  * MobilePhoneValidator：手機格式驗證。
  * IdCardValidator：身分證驗證，可用IdCardTypes設定驗證允許格式「國民身分證」、「臺灣地區居留證」、「外僑居留證」和「遊民證」，預設全部允許。
* Boolean驗證
  * TrueAssertValidator：參數為true時，驗證通過；參數可用Func\<T\>將條件式延後到Validate()時執行。
  * FalseAssertValidator：參數為true時，驗證通過；參數可用Func\<T\>將條件式延後到Validate()時執行。

需注意除了RequiredValidator、BulkValidator和Boolean驗證外，當Value為Null、空字串或空格皆視為驗證通過。

## Examples

作法一：取得全部驗證的錯誤訊息
```
// 建立容器，並將Validator加入Bulk裡
BulkValidator validators = new BulkValidator();
// 驗證是否有值
validators.Add(new RequiredValidator("欄位一", "值一"));
// 驗證基本原則，當值為Null、空格和空字串由RequiredValidator驗證
// 其他驗證遇到上述情況都回傳true
validators.Add(new IntegerValidator("欄位一", "值一"));
// 一些特別情況可以使用TrueAssertValidator判斷第一個參數為true來表示驗證通過
// 也可用FalseAssertValidator判斷false為通過
validators.Add(new TrueAssertValidator({bool}, "錯誤訊息"));

// 進行資料驗證
if (!validators.Validate()) {
    // 驗證失敗使用validators.ErrorMessage取得錯誤訊息，多個錯誤訊息使用<br />隔開
    // ErrorMessageWithBreak等同於ErrorMessage
    // ErrorMessageWithLF，使用\n隔開
    // ErrorMessageWithNewLine，使用Environment.NewLine隔開
}
```

作法二：取得第一個錯誤訊息
```
// 建立容器，並將Validator加入批量裡
BulkValidator validators = new BulkValidator(true);
// TrueAssert遇到true，驗證成功
validators.Add(new TrueAssertValidator(true, "錯誤訊息一"));
// TrueAssert遇到false，驗證失敗
validators.Add(new TrueAssertValidator(false, "錯誤訊息二"));
validators.Add(new TrueAssertValidator(false, "錯誤訊息三"));
if (!validators.Validate()) {
    // 驗證失敗使用validators.ErrorMessage取得錯誤訊息，錯誤訊息為"錯誤訊息二"
}
```

可將兩者搭配使用
```
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
    // validators.ErrorMessage為"錯誤訊息二<br />錯誤訊息五<br />錯誤訊息六"
}
```

可使用搭配ValidatorConfiguration建立BulkValidator
```
BulkValidator validators = new BulkValidator(cfg => {
    cfg.Add("欄位一", "值一", opt => opt.Required()); // 增加一個驗證
    cfg.Add("欄位二", "值二", opt => opt.Required(), opt => opt.DateTime()); // 增加多個驗證
    cfg.AddIf(condition, "欄位三", "值三", opt => opt.Required(), opt => opt.DateTime()); // condition為true時，才會驗證
    cfg.AddTrueAssert(true, "錯誤訊息");
});
```

## License
This project is MIT [licensed](https://github.com/CloudyWing/FormValidators/blob/master/LICENSE.md).