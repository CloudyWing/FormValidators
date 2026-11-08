---
title: 快速開始
description: 了解如何安裝並開始使用 FormValidators
---

本指南將協助您快速開始使用 FormValidators。

## 安裝

### 透過 NuGet 安裝

使用 NuGet Package Manager 安裝 FormValidators：

```powershell
Install-Package CloudyWing.FormValidators
```

或使用 .NET CLI：

```bash
dotnet add package CloudyWing.FormValidators
```

## 支援的框架

- .NET 10
- .NET Standard 2.0
- .NET Framework 4.5

## 第一個驗證範例

以下是一個簡單的範例，展示如何使用 FormValidators 進行基本驗證：

```csharp
using CloudyWing.FormValidators;

// 建立批量驗證容器
BulkValidator validators = new();

// 新增必填驗證
validators.Add(new RequiredValidator("使用者名稱", userName));

// 新增整數驗證
validators.Add(new IntegerValidator("年齡", age));

// 執行驗證
if (!validators.Validate()) {
    // 取得錯誤訊息
    string errorMessage = validators.ErrorMessage;
    Console.WriteLine(errorMessage);
}
```

## 使用 ValidationProvider 簡化程式碼

FormValidators 提供了更簡潔的語法來建立驗證：

```csharp
BulkValidator validators = new(cfg => {
    cfg.Add("使用者名稱", userName,
        opt => opt.Required()
    );
    cfg.Add("年齡", age,
        opt => opt.Required(),
        opt => opt.Integer()
    );
    cfg.Add("Email", email,
        opt => opt.Email()
    );
});

if (!validators.Validate()) {
    Console.WriteLine(validators.ErrorMessage);
}
```

## 升級注意事項

- 公開 API 已啟用 Nullable Reference Types，驗證器的輸入值與錯誤訊息 accessor 的 `value` 參數為 `string?`。啟用 Nullable 的專案升級後，自訂驗證器、擴充方法或傳入的 accessor 若仍使用不可為 `null` 的型別，可能出現新的編譯警告，調整方式見 [客製化驗證](customization.md)。
- `UrlValidator` 預設仍接受任何 scheme，包含 `javascript:`。驗證使用者輸入的連結時，請傳入 `allowedSchemes` 限定為 `http` 與 `https`，見 [驗證器介紹](validators.md#urlvalidator)。

## 下一步

- [驗證器介紹](validators.md) - 了解所有可用的驗證器
- [使用範例](usage-examples.md) - 查看更多實際應用範例
- [客製化驗證](customization.md) - 學習如何建立自訂驗證器
- [API 參考](../api/index.md) - 查看完整的 API 文檔
