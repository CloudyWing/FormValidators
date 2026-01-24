# FormValidators

目前提供以下幾種預設驗證：

## 基本驗證

* RequiredValidator：`Value` 的必填驗證，如果是 Null、空字串或空格，視為沒有值。
* ValueLengthValidator：`Value` 的長度驗證。
* BulkValidator：批量驗證，參數 `isStoppedIfFail` 可控制驗證不通過時，是否繼續後續驗證。

## 型別驗證

提供驗證值是否可轉型成特定型別，及最大值和最小值驗證。

* IntegerValidator：整數和極限值驗證，資料型別為 `long`，參數 `allowedThousands` 可決定是否允許千分位符號。
* NumberValidator：數值和極限值驗證，資料型別為 `decimal`，參數 `allowedThousands` 可決定是否允許千分位符號。
* DateTimeValidator：日期和極限值驗證，資料型別為 `DateTime`。

## 比較驗證

* CompareValidator：比較兩欄位的值是否相等。
* IntegerLessThanValidator：整數欄位比較，`Value` 必須小於比較的值；`allowedEqual` 為 `true` 時，可以等於。
* NumberLessThanValidator：數值欄位比較，`Value` 必須小於比較的值；`allowedEqual` 為 `true` 時，可以等於。
* DateTimeLessThanValidator：日期欄位比較，`Value` 必須小於比較的值；`allowedEqual` 為 `true` 時，可以等於。

## 格式驗證

* RegexValidator：使用正規式驗證 `Value`。
* EmailValidator：Email 格式驗證。
* MobilePhoneValidator：手機格式驗證，可用 ``。
* IdCardValidator：身分證驗證，可用 `IdCardTypes` 設定驗證允許格式「國民身分證號」、「臺灣地區居留證統一證號」、「外僑居留證統一證號」、「遊民證號」和「新式外來人口統一證號」，預設全部允許。

## Boolean 驗證

* TrueAssertValidator：參數為 `true` 時，驗證通過；參數可用 `Func<T>` 將條件式延後到 `Validate()` 時執行。
* FalseAssertValidator：參數為 `true` 時，驗證通過；參數可用 `Func<T>` 將條件式延後到 `Validate()` 時執行。

## 注意事項

* 除了 `RequiredValidator`、`BulkValidator` 和 `Boolean` 驗證外，當 `Value` 為 Null、空字串或空格皆視為驗證通過。
