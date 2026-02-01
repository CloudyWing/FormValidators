---
title: 客製化驗證
description: 學習如何建立自訂的驗證器
---

當內建的驗證器無法滿足您的需求時，您可以建立自訂的驗證器。

## 方法 1：撰寫新的 FormValidator

實作 @CloudyWing.FormValidators.IFormValidator 介面來建立自訂驗證器。

### 實作介面

```csharp
using CloudyWing.FormValidators;

public class CustomFormValidator : IFormValidator {
    public CustomFormValidator(string column, string value) {
        Column = column;
        Value = value;
    }

    public string Column { get; }

    public string Value { get; }

    public string ErrorMessage { get; private set; }

    public bool IsValid { get; private set; }

    public bool Validate() {
        // 實作您的驗證邏輯
        if (string.IsNullOrWhiteSpace(Value)) {
            IsValid = true; // 空值視為通過（遵循一般驗證器慣例）
            return true;
        }

        // 您的驗證邏輯
        bool isValid = YourValidationLogic(Value);

        if (!isValid) {
            ErrorMessage = $"{Column} 驗證失敗。";
        }

        IsValid = isValid;
        return isValid;
    }

    private bool YourValidationLogic(string value) {
        // 在此撰寫您的驗證邏輯
        return true;
    }
}
```

### 使用自訂驗證器

```csharp
BulkValidator validators = new BulkValidator();
validators.Add(new CustomFormValidator("欄位名稱", "欄位值"));

if (!validators.Validate()) {
    Console.WriteLine(validators.ErrorMessage);
}
```

## 方法 2：撰寫 ValidationProvider 的擴充方法

為了讓自訂驗證器也能使用 Fluent API 語法，您可以建立擴充方法。

### 建立擴充方法

```csharp
using CloudyWing.FormValidators.Core;

public static class ValidationProviderExtensions {
    public static Func<string, string, CustomFormValidator> Custom(this ValidationProvider provider)
        => (column, value) => new CustomFormValidator(column, value);
}
```

### 使用擴充方法

```csharp
BulkValidator validators = new BulkValidator(cfg => {
    cfg.Add("欄位名稱", "欄位值", 
        opt => opt.Required(),
        opt => opt.Custom()); // 使用自訂驗證器
});

if (!validators.Validate()) {
    Console.WriteLine(validators.ErrorMessage);
}
```

## 實際範例：URL Slug 驗證器

以下是一個實際的範例，驗證字串是否為有效的 URL slug（如 `my-blog-post`）。

### 驗證器實作

```csharp
using System.Text.RegularExpressions;
using CloudyWing.FormValidators;

public class UrlSlugValidator : IFormValidator {
    private static readonly Regex SlugRegex = new Regex(
        @"^[a-z0-9]+(?:-[a-z0-9]+)*$",
        RegexOptions.Compiled
    );

    public UrlSlugValidator(string column, string value) {
        Column = column;
        Value = value;
    }

    public string Column { get; }

    public string Value { get; }

    public string ErrorMessage { get; private set; }

    public bool IsValid { get; private set; }

    public bool Validate() {
        if (string.IsNullOrWhiteSpace(Value)) {
            IsValid = true;
            return true;
        }

        bool isValid = SlugRegex.IsMatch(Value);

        if (!isValid) {
            ErrorMessage = $"{Column} 必須為小寫字母、數字和連字號組成，且不能以連字號開頭或結尾。";
        }

        IsValid = isValid;
        return isValid;
    }
}
```

### 擴充方法

```csharp
using CloudyWing.FormValidators.Core;

public static class CustomValidationProviderExtensions {
    public static Func<string, string, UrlSlugValidator> UrlSlug(this ValidationProvider provider)
        => (column, value) => new UrlSlugValidator(column, value);
}
```

### 使用範例

```csharp
BulkValidator validators = new BulkValidator(cfg => {
    cfg.Add("文章網址", articleSlug,
        opt => opt.Required(),
        opt => opt.UrlSlug());
});

if (!validators.Validate()) {
    // 輸出：「文章網址 必須為小寫字母、數字和連字號組成，且不能以連字號開頭或結尾。」
    Console.WriteLine(validators.ErrorMessage);
}
```

## 最佳實踐

### 1. 遵循空值慣例

大多數內建驗證器在遇到空值時會回傳 `true`（除了 `RequiredValidator`）。建議您的自訂驗證器也遵循這個慣例：

```csharp
public bool Validate() {
    if (string.IsNullOrWhiteSpace(Value)) {
        IsValid = true;
        return true; // 空值視為通過
    }
    
    // 您的驗證邏輯...
}
```

### 2. 提供有意義的錯誤訊息

錯誤訊息應明確告知使用者問題所在：

```csharp
// ✗ 不良範例
ErrorMessage = $"{Column} 無效。";

// ✓ 良好範例
ErrorMessage = $"{Column} 必須為 8-20 位英數字元，且至少包含一個大寫字母。";
```

### 3. 考慮效能

如果驗證邏輯複雜，考慮使用快取或預編譯：

```csharp
// 使用 static readonly 預編譯正規表示式
private static readonly Regex Pattern = new Regex(
    @"^pattern$",
    RegexOptions.Compiled
);
```

### 4. 支援參數化

讓驗證器更靈活：

```csharp
public class RangeValidator : IFormValidator {
    private readonly int min;
    private readonly int max;

    public RangeValidator(string column, string value, int min, int max) {
        Column = column;
        Value = value;
        this.min = min;
        this.max = max;
    }

    // ... 實作驗證邏輯
}
```

## 相關資源

- [驗證器介紹](validators.md) - 了解內建驗證器的設計
- [使用範例](usage-examples.md) - 查看驗證器的實際應用
- [錯誤訊息設定](error-messages.md) - 自訂錯誤訊息
- @CloudyWing.FormValidators.IFormValidator - 介面文檔
- @CloudyWing.FormValidators.Core.ValidationProvider - ValidationProvider API
