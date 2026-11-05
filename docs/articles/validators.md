---
title: 驗證器介紹
description: FormValidators 提供的所有內建驗證器說明
---

FormValidators 提供多種預設驗證器，涵蓋常見的資料驗證需求。

## 基本驗證

### RequiredValidator

驗證 `Value` 是否為必填。如果值為 `null`、空字串或空格，視為沒有值。

**相關 API**：@CloudyWing.FormValidators.RequiredValidator

### ValueLengthValidator

驗證 `Value` 的長度是否符合指定範圍。最小值與最大值小於等於 0 時表示不限制；兩者皆大於 0 且最小值大於最大值時，建構時會拋出 `ArgumentException`。

**參數**：

- `TextLengthUnit`：長度的計算單位，預設為 `Utf16CodeUnit`，與 `string.Length` 相同，emoji 等 BMP 以外的字元算 2 個長度
  - `UnicodeScalar`：以 Unicode scalar 計算，成對的 surrogate 算 1 個長度
  - `TextElement`：以使用者看到的字元計算（`StringInfo`）。.NET 5 以上會把以 ZWJ 組合的 emoji 算成 1 個長度，.NET Framework 可能算成多個

```csharp
cfg.Add("暱稱", nickName,
    opt => opt.MaxLength(10, TextLengthUnit.TextElement)
);
```

**相關 API**：@CloudyWing.FormValidators.ValueLengthValidator

### BulkValidator

批量驗證容器，可包含多個驗證器。參數 `isStoppedIfFail` 可控制驗證不通過時，是否繼續後續驗證。

驗證後除了 `ErrorMessage`、`ErrorMessages` 等字串結果，也可以從 `Errors` 取得結構化的 @CloudyWing.FormValidators.ValidationError，內容包含欄位名稱 `Column`、錯誤訊息 `Message`、驗證器 `Validator` 與驗證器型別 `ValidatorType`。巢狀的 `BulkValidator` 會攤平，順序與 `ErrorMessages` 相同。`TrueAssertValidator` 等沒有欄位的驗證器，`Column` 為 `null`。

包含非同步驗證器時，改用 `ValidateAsync` 擴充方法，用法見 [使用範例](usage-examples.md)。

**相關 API**：@CloudyWing.FormValidators.BulkValidator、@CloudyWing.FormValidators.BulkValidatorExtensions

## 型別驗證

提供驗證值是否可轉型成特定型別，及最大值和最小值驗證。

### IntegerValidator

整數和極限值驗證，資料型別為 `long`。

**參數**：

- `allowedThousands`：是否允許千分位符號
- `formatProvider`：解析時使用的格式，例如 `CultureInfo.InvariantCulture`；未指定時使用目前的文化特性

**相關 API**：@CloudyWing.FormValidators.IntegerValidator

### NumberValidator

數值和極限值驗證，資料型別為 `decimal`。

**參數**：

- `allowedThousands`：是否允許千分位符號
- `formatProvider`：解析時使用的格式，例如 `CultureInfo.InvariantCulture`；未指定時使用目前的文化特性

**相關 API**：@CloudyWing.FormValidators.NumberValidator

### DateTimeValidator

日期和極限值驗證，資料型別為 `DateTime`。

**參數**：

- `formatProvider`：解析時使用的格式，例如 `CultureInfo.InvariantCulture`；未指定時使用目前的文化特性
- `formats`：允許的精確格式，例如 `yyyy/MM/dd`；指定後改以 `DateTime.TryParseExact` 解析

```csharp
cfg.Add("生日", birthday,
    opt => opt.DateTime(["yyyy/MM/dd"], CultureInfo.InvariantCulture)
);
```

**相關 API**：@CloudyWing.FormValidators.DateTimeValidator

## 比較驗證

### CompareValidator

比較兩欄位的值是否相等。

**相關 API**：@CloudyWing.FormValidators.CompareValidator

### IntegerLessThanValidator

整數欄位比較，`Value` 必須小於比較的值。只接受整數與千分位格式，與 `IntegerValidator` 一致；任一值無法解析時略過比較。

**參數**：

- `allowedEqual`：設為 `true` 時，可以等於比較值

**相關 API**：@CloudyWing.FormValidators.IntegerLessThanValidator

### NumberLessThanValidator

數值欄位比較，`Value` 必須小於比較的值。

**參數**：

- `allowedEqual`：設為 `true` 時，可以等於比較值

**相關 API**：@CloudyWing.FormValidators.NumberLessThanValidator

### DateTimeLessThanValidator

日期欄位比較，`Value` 必須小於比較的值。

**參數**：

- `allowedEqual`：設為 `true` 時，可以等於比較值

**相關 API**：@CloudyWing.FormValidators.DateTimeLessThanValidator

## 格式驗證

### RegexValidator

使用正規表示式驗證 `Value`。

- 可傳入 `Regex` 執行個體，或指定 `RegexOptions` 與 match timeout。
- 只傳入 pattern 字串時，使用 @CloudyWing.FormValidators.Core.ValidatorDefaults 的 `RegexTimeout`，預設為 `Regex.InfiniteMatchTimeout`。
- 比對逾時一律視為驗證失敗，不會拋出 `RegexMatchTimeoutException`。

```csharp
// 使用者輸入的 pattern 建議設定 timeout
ValidatorDefaults.RegexTimeout = TimeSpan.FromSeconds(1);

cfg.Add("代碼", code,
    opt => opt.Regex("^[a-z]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(500))
);
```

**相關 API**：@CloudyWing.FormValidators.RegexValidator

### EmailValidator

Email 格式驗證。內建 pattern 不會因長字串產生大量回溯，且不接受結尾的換行字元。

**相關 API**：@CloudyWing.FormValidators.EmailValidator

### MobilePhoneValidator

手機格式驗證，只接受 ASCII 數字，不接受全形數字與結尾的換行字元。

**參數**：

- `MobilePhoneFormats`：可指定允許的手機號碼格式

**相關 API**：@CloudyWing.FormValidators.MobilePhoneValidator

### IdCardValidator

身分證驗證。

**參數**：

- `IdCardTypes`：設定驗證允許格式，包括：
  - 國民身分證號
  - 臺灣地區居留證統一證號
  - 外僑居留證統一證號
  - 遊民證號
  - 新式外來人口統一證號

預設允許全部格式。

**相關 API**：@CloudyWing.FormValidators.IdCardValidator

### CreditCardValidator

信用卡號碼驗證，以 Luhn 演算法檢查 13 到 19 碼的 ASCII 數字，可包含 `-` 與空白。

**相關 API**：@CloudyWing.FormValidators.CreditCardValidator

### UrlValidator

URL 格式驗證，預設為 `UriKind.Absolute`。

- 預設接受任何 scheme，包含 `ftp:`、`mailto:`、`javascript:` 與 `file:`。網址會輸出成連結或由伺服器請求時，建議以 `allowedSchemes` 限定為 `http`、`https`。
- `/path`、`C:\path` 與 UNC 路徑等未明確寫出 scheme 的檔案路徑，在各平台都不視為絕對網址。

```csharp
cfg.Add("網站", website,
    opt => opt.Url(UriKind.Absolute, ["http", "https"])
);
```

**相關 API**：@CloudyWing.FormValidators.UrlValidator

### IPAddressValidator

IP 位址驗證。IPv4 必須為 4 段 0 到 255 的十進位數字，不接受 `192.168.1` 等簡寫、八進位與十六進位寫法，也不接受每段的前導零。

**參數**：

- `IPAddressTypes`：可指定允許的 IP 類型（IPv4、IPv6 或兩者）

**相關 API**：@CloudyWing.FormValidators.IPAddressValidator

### GuidValidator

GUID 格式驗證，以 `Guid.TryParse` 解析，接受 `N`、`D`、`B`、`P`、`X` 格式，並忽略前後空白。

**相關 API**：@CloudyWing.FormValidators.GuidValidator

### TaiwanUniformNumberValidator

統一編號驗證，必須為 8 碼 ASCII 數字。各碼依序乘上 1、2、1、2、1、2、4、1，再把每個乘積的十位數與個位數相加，總和可被 5 整除即為正確。這是財政部自 2023 年起擴充編號後的規則，原本可被 10 整除的統一編號也都符合。第 7 碼為 7 時，總和加 1 可被 5 整除也視為正確。

**相關 API**：@CloudyWing.FormValidators.TaiwanUniformNumberValidator

### PhoneValidator

台灣市話驗證，規則如下：

- 以 `02` 到 `08` 的區碼開頭，總碼數為 9 碼；`02`、`04` 開頭可為 10 碼，例如 `02-2345-6789`、`049-234-5678`、`037-123456`。
- 區碼可用括號包住，例如 `(02)2345-6789`。
- 最多兩個 `-` 或空白分隔，分隔符號不可連續，也不可在開頭或結尾。
- 不接受手機（`09`）、`0800` 等免付費電話、國碼 `+886` 與分機。

**相關 API**：@CloudyWing.FormValidators.PhoneValidator

## 清單與自訂驗證

### AllowedValuesValidator

驗證 `Value` 是否為允許的值之一，以 `opt.In(...)` 建立。預設以 `StringComparison.Ordinal` 比較，會區分大小寫，也不會移除前後空白；需要不分大小寫時，傳入 `StringComparison.OrdinalIgnoreCase`。

```csharp
cfg.Add("性別", gender,
    opt => opt.In("M", "F")
);

cfg.Add("幣別", currency,
    opt => opt.In(["TWD", "USD"], StringComparison.OrdinalIgnoreCase)
);
```

**相關 API**：@CloudyWing.FormValidators.AllowedValuesValidator

### CustomValidator

以自訂的 `Func<string, bool>` 判斷值是否正確，以 `opt.Custom(...)` 建立。

```csharp
cfg.Add("密碼", password,
    opt => opt.Custom(x => x.Any(char.IsDigit), "{0}必須包含數字。")
);
```

**相關 API**：@CloudyWing.FormValidators.CustomValidator

### AsyncCustomValidator

以自訂的非同步判斷式驗證，例如檢查帳號是否已被使用，以 `opt.CustomAsync(...)` 建立。此驗證器只能透過 `ValidateAsync` 執行，呼叫同步的 `Validate` 會拋出 `NotSupportedException`。

**相關 API**：@CloudyWing.FormValidators.AsyncCustomValidator、@CloudyWing.FormValidators.IAsyncFormValidator

## Boolean 驗證

### TrueAssertValidator

當條件為 `true` 時，驗證通過。

**特色**：參數可使用 `Func<bool>` 將條件式延後到 `Validate()` 時執行。

**相關 API**：@CloudyWing.FormValidators.TrueAssertValidator

### FalseAssertValidator

當條件為 `false` 時，驗證通過。

**特色**：參數可使用 `Func<bool>` 將條件式延後到 `Validate()` 時執行。

**相關 API**：@CloudyWing.FormValidators.FalseAssertValidator

## 重要注意事項

> [!IMPORTANT]
> 除了 `RequiredValidator`、`BulkValidator` 和 Boolean 驗證外，當 `Value` 為 `null`、空字串或空格時，皆視為驗證通過。
>
> 這意味著如果您需要驗證必填欄位，必須同時使用 `RequiredValidator` 和其他型別驗證器。

## 文化特性

- `IntegerValidator`、`NumberValidator`、`DateTimeValidator` 與 LessThan 系列預設以目前的文化特性（`CultureInfo.CurrentCulture`）解析，例如 de-DE 的小數點為 `,`、en-US 的 `03/04` 為 3 月 4 日。
- 需要固定格式時，傳入 `formatProvider` 或日期的 `formats`。
- 預設錯誤訊息中的日期固定以西曆 `yyyy/MM/dd` 顯示，不受文化特性的日期分隔符號與曆法影響。

## 執行緒安全

- 驗證器執行個體會保存最後一次驗證的結果，不是執行緒安全的型別。請在每次驗證時建立新的驗證器，不要跨執行緒共用同一個執行個體。
- `ErrorMessageProvider` 與 `ValidatorDefaults` 是整個應用程式共用的設定，單一設定的讀寫是原子操作，但請在應用程式啟動時設定。需要依請求切換訊息時，使用 `ErrorMessageProvider.BeginScope`，用法見 [錯誤訊息設定](error-messages.md)。

## 範例

查看 [使用範例](usage-examples.md) 了解如何在實際應用中使用這些驗證器。
