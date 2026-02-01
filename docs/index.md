---
_layout: landing
---

# FormValidators

用於驗證資料格式，適用於如 Web Form 控制項等輸入值皆為字串之場合。

## 特色

- ✓ **豐富的內建驗證器**：支援必填、型別、比較、格式等多種驗證
- ✓ **易於客製化**：可輕鬆建立自訂驗證器
- ✓ **批量驗證管理**：統一管理多個驗證器和錯誤訊息
- ✓ **Fluent API**：使用 `ValidationProvider` 提供簡潔的語法
- ✓ **跨框架支援**：支援 .NET 10、.NET Standard 2.0 和 .NET Framework 4.5

## 快速開始

### 安裝

```powershell
Install-Package CloudyWing.FormValidators
```

### 基本使用

```csharp
using CloudyWing.FormValidators;

BulkValidator validators = new BulkValidator(cfg => {
    cfg.Add("使用者名稱", userName, opt => opt.Required());
    cfg.Add("Email", email, opt => opt.Required(), opt => opt.Email());
    cfg.Add("年齡", age, opt => opt.Integer(18, 100));
});

if (!validators.Validate()) {
    Console.WriteLine(validators.ErrorMessage);
}
```

查看 [快速開始指南](articles/getting-started.md) 了解更多詳情。

## 文檔導航

### 使用指南

- [快速開始](articles/getting-started.md) - 安裝與基本使用
- [驗證器介紹](articles/validators.md) - 了解所有內建驗證器
- [使用範例](articles/usage-examples.md) - 實際程式碼範例
- [客製化驗證](articles/customization.md) - 建立自訂驗證器
- [錯誤訊息設定](articles/error-messages.md) - 自訂錯誤訊息

### API 參考

- [API 文檔](api/index.md) - 完整的 API 參考文檔

## 授權

本專案採用 [MIT 授權](https://github.com/CloudyWing/FormValidators/blob/master/LICENSE.md)。
