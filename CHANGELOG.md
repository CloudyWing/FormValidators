# Changelog

## [v3.2.0] - 2026-11-09

### Security
- `UrlValidator` 在 3.x 為了相容，預設仍接受任何 scheme，包含 `javascript:` 與 `file:`。驗證使用者輸入的網址時，建議以 `allowedSchemes` 限定為 `http` 與 `https`，例如 `opt.Url(UriKind.Absolute, ["http", "https"])`。用法與警告見文件的 URL 驗證章節。

### Added
- 新增非同步驗證，包含 `IAsyncFormValidator`、`BulkValidatorExtensions.ValidateAsync`、`AsyncCustomValidator` 與 `ValidationProvider.CustomAsync`。非同步驗證器依序執行，對其呼叫同步的 `Validate` 會拋出 `NotSupportedException`。
- 新增 `BulkValidator.Errors`，以 `ValidationError` 提供欄位名稱、錯誤訊息、驗證器與驗證器型別，既有的 `ErrorMessages` 不變。
- 新增 `ErrorMessageProvider.BeginScope` 與 `ErrorMessageOverrides`，可在範圍內覆寫錯誤訊息 accessor 而不修改全域設定，範圍隨執行內容流動並支援巢狀。
- 新增 `CustomValidator`、`AllowedValuesValidator`、`GuidValidator`、`TaiwanUniformNumberValidator` 與 `PhoneValidator`，以及對應的 `ValidationProvider` 方法（`Custom`、`In`、`Guid`、`TaiwanUniformNumber`、`Phone`）與預設訊息 accessor。
- 新增 `UrlValidator.AllowedSchemes` 與 `ValidationProvider.Url` 的 `allowedSchemes` 多載，可限定絕對網址允許的 scheme，比較時不分大小寫。未指定時維持接受任意 scheme。
- 新增 `TextLengthUnit` 與 `ValueLengthValidator` 的長度計算單位選項，可選擇 UTF-16 code unit、Unicode scalar 或 text element，預設維持 UTF-16 code unit。`MinLength`、`MaxLength` 與 `LengthRange` 提供對應多載。
- 新增 `IntegerValidator`、`NumberValidator` 與 `DateTimeValidator` 指定 `IFormatProvider` 的多載，以及 `DateTimeValidator` 指定精確格式的多載。未指定時維持使用目前文化特性。
- 新增 `RegexValidator` 與 `ValidationProvider.Regex` 指定 `RegexOptions` 與 match timeout 的多載、接受 `Regex` 物件的 `ValidationProvider.Regex` 多載，以及全域預設的 `ValidatorDefaults.RegexTimeout`。預設為不逾時，維持既有行為，逾時一律視為驗證失敗。
- 新增 `FormValidatorBase.SetValidationResult`，供衍生類別在 `Validate` 以外記錄驗證結果。
- 新增 NuGet 套件專用 README，以及符號套件（snupkg）。

### Changed
- 啟用 Nullable Reference Types，公開 API 補上可空標註，例如驗證器的 `Value` 與 `ComparisonValue` 為 `string?`，自訂訊息 accessor 的 value 參數為 `string?`。既有專案升級後可能出現新的 Nullable 編譯器警告，自訂驗證器與擴充方法請同步改為 `string?`。
- `FormValidatorBase.ErrorMessage` 在呼叫 `Validate` 前由 `null` 改為空字串。
- `ValueLengthValidator` 的 `min` 與 `max` 皆大於 0 且 `min` 大於 `max` 時，建構時拋出 `ArgumentException`，原本不檢查而永遠驗證失敗。
- `TrueAssertValidator` 與 `FalseAssertValidator` 傳入 `null` 的 predicate 時，改為建構時拋出 `ArgumentNullException`，原本在 `Validate` 時拋出 `NullReferenceException`。
- `BulkValidator` 傳入 `null` 的 `configure` 時，改為拋出 `ArgumentNullException`，原本拋出 `NullReferenceException`。
- `ErrorMessageProvider` 的 `Set` 方法與 `RegexValidator` 傳入 `null` 時，改為拋出 `ArgumentNullException`，原本拋出 `System.Exception`。
- 預設日期範圍錯誤訊息的日期固定以 `yyyy/MM/dd` 西曆格式輸出，不再受目前文化特性的日期分隔符號與曆法影響。
- Email 與手機驗證遇到 `RegexMatchTimeoutException` 時視為驗證失敗，內建 Regex 的 match timeout 為 1 秒。
- 減少 `BulkValidator`、信用卡驗證與身分證預設訊息的記憶體配置。
- `ErrorMessageProvider` 的 accessor 改以 `volatile` 欄位保存，`Set` 後其他執行緒可立即讀到新委派。
- 新增僅用於建置的 `Microsoft.CodeAnalysis.PublicApiAnalyzers`，並以 `PublicAPI.Shipped.txt` 與 `PublicAPI.Unshipped.txt` 追蹤公開 API。分析器為私用相依性，不會成為套件的執行期相依性。
- 啟用以 v3.1.0 為基準的 PackageValidation，檢查套件相容性。
- 方案檔改為 `FormValidators.slnx`。
- CI 改用 devops-templates 的 reusable workflow，於 Ubuntu 與 Windows 執行建置、測試與打包，測試專案新增 `net8.0` 與 Windows 上的 `net48` 目標框架。
- 發佈流程改為推送版本標籤時，驗證後建立 GitHub Release 並以 NuGet Trusted Publishing 發佈，不再需要 `NUGET_API_KEY`。
- 文件網站改以 GitHub Pages artifact 部署，儲存庫的 Pages Source 需設為 GitHub Actions。
- 新增 Dependabot 設定。
- 文件補充新增功能的用法與升級注意事項，並修正無法編譯的範例與不一致的描述。

### Fixed
- 修正 `EmailValidator` 與 `MobilePhoneValidator` 接受結尾換行字元，兩者的 pattern 結尾改為 `\z`。
- 修正 `MobilePhoneValidator` 與 `CreditCardValidator` 接受全形或其他 Unicode 數字，改為只接受 ASCII 數字。
- 修正 `EmailValidator` 的 pattern 在長字串上的多項式回溯，接受與拒絕的格式不變。
- 修正 `IPAddressValidator` 接受 IPv4 簡寫、八進位與十六進位寫法。IPv4 現需為剛好 4 段、每段 0 到 255 的十進位數字，不接受 `1`、`192.168.1` 等簡寫，也不接受前導零。
- 修正 `UrlValidator` 在 Linux 將 `/path` 等隱含檔案路徑視為絕對網址。`UriKind.Absolute` 下，未明確帶有 scheme 的 `/path`、`C:\path` 與 UNC 路徑視為驗證失敗，各平台結果一致。
- 修正 `IntegerLessThanValidator` 以 `NumberStyles.Any` 解析而接受小數點、指數與貨幣符號。現與 `IntegerValidator` 一致只接受整數格式並保留千分位，其餘輸入視為無法解析，依 LessThan 系列既有規則略過比較。
- 修正 `CompareValidator` 的預設錯誤訊息把欄位值當成比較欄位名稱。
- 修正 `LessThanValidator` 傳給全域 accessor 的參數順序與 XML 文件不一致，現依 column、value、comparison column、comparison value、allowed equal 的順序呼叫。

### Removed
- 移除以 API Key 發佈 NuGet 的 `nuget-publish.yml` 工作流程。

## [v3.1.0] - 2026-02-01

### Added
- 支援 **.NET 10** 目標框架 (net10.0)。
- 全新 **DocFX** 文檔系統，包含現代化的文章結構與 API 參考。
- 新增文檔 Logo 與 Favicon。

### Changed
- 遷移文檔架構至 `docs/articles` 與 `docs/api`。
- 專案檔更新：調整 TargetFrameworks 順序為 `net10.0;netstandard2.0;net45`。
- CI/CD：更新 GitHub Workflows 以支援 .NET 10 建置。

### Removed
- 移除 **DefaultDocumentation** 套件依賴。
- 舊版 Markdown API 文檔。
