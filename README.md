# FormValidators

用於驗證資料格式，適用於如 Web Form 控制項等輸入值皆為字串之場合。
不過 Web Form 本身有 Validation Controls，所以除非捨棄 Validation Controls，自行定義驗證方式，否則此專案更多是用於記錄資料驗證的方式，偏向娛樂性質居多。

## Supported Frameworks

* .NET 10
* .NET Standard 2.0
* .NET Framework 4.5

## 功能

* 必填、長度、整數、數值、日期與欄位比較驗證。
* Email、手機、市話、身分證、統一編號、信用卡、URL、IP 位址與 GUID 格式驗證。
* 允許值清單（`In`）、自訂判斷式（`Custom`）與非同步判斷式（`CustomAsync`）驗證。
* `BulkValidator` 批量驗證，可取得字串或結構化的 `Errors` 錯誤結果，並支援 `ValidateAsync` 非同步驗證。
* 以 `ErrorMessageProvider` 全域設定預設錯誤訊息，或以 `BeginScope` 在限定範圍內覆寫。

## 注意事項

* 整數、數值與日期預設以目前的文化特性解析，需要固定格式時請傳入 `IFormatProvider` 或日期格式。
* 驗證器執行個體會保存最後一次驗證的結果，不是執行緒安全的型別，請不要跨執行緒共用。
* `ErrorMessageProvider` 與 `ValidatorDefaults` 是整個應用程式共用的設定，請在應用程式啟動時設定。
* `UrlValidator` 為了相容舊版，預設接受任何 scheme，包含 `javascript:` 與 `file:`。驗證使用者輸入的連結時，請傳入 `allowedSchemes` 限定為 `http` 與 `https`，例如 `opt.Url(UriKind.Absolute, ["http", "https"])`，詳見[驗證器介紹](./docs/articles/validators.md#urlvalidator)。

## Documentation

完整文檔請參考：<https://cloudywing.github.io/FormValidators/>

或查看以下主要文章：

* [快速開始](./docs/articles/getting-started.md)
* [驗證器介紹](./docs/articles/validators.md)
* [使用範例](./docs/articles/usage-examples.md)
* [客製化驗證](./docs/articles/customization.md)
* [錯誤訊息設定](./docs/articles/error-messages.md)
* [API 參考](./docs/api/index.md)

## License

This project is MIT [licensed](https://github.com/CloudyWing/FormValidators/blob/main/LICENSE.md).
