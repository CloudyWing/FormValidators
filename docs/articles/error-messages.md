---
title: 錯誤訊息設定
description: 了解如何自訂驗證器的預設錯誤訊息
---

FormValidators 允許您自訂每個驗證器的預設錯誤訊息，讓錯誤提示更符合您的應用需求。

## 概述

使用 @CloudyWing.FormValidators.Core.ErrorMessageProvider 類別中的各個 `SetAccessor` 方法來設定驗證器的預設錯誤訊息。

## 基本用法

```csharp
using CloudyWing.FormValidators.Core;

// 設定必填欄位的預設錯誤訊息
ErrorMessageProvider.SetValueIsRequiredAccessor((column, value) => $"{column} is required.");

// 設定整數驗證的預設錯誤訊息
ErrorMessageProvider.SetValueIsIntegerAccessor((column, value) => $"{column} must be a valid integer.");
```

> [!TIP]
> 建議在應用程式啟動時（如 `Program.cs` 或 `Startup.cs`）統一設定錯誤訊息，確保全域一致性。

## Validator 與 Accessor 對應關係

### RequiredValidator

- **SetValueIsRequiredAccessor**：欄位為必填時的錯誤訊息

```csharp
ErrorMessageProvider.SetValueIsRequiredAccessor((column, value) => 
    $"{column}為必填。");
```

### IntegerValidator

- **SetValueIsIntegerAccessor**：值不是有效整數
- **SetValueGreaterOrEqualAccessor**：值小於最小值
- **SetValueLessOrEqualAccessor**：值大於最大值
- **SetValueInRangeAccessor**：值不在指定範圍內

```csharp
ErrorMessageProvider.SetValueIsIntegerAccessor((column, value)
    => $"{column}必須為整數。");

ErrorMessageProvider.SetValueGreaterOrEqualAccessor((column, value, min)
    => $"{column}不得小於 {min}。");

ErrorMessageProvider.SetValueLessOrEqualAccessor((column, value, max)
    => $"{column}不得大於 {max}。");

ErrorMessageProvider.SetValueInRangeAccessor((column, value, min, max)
    => $"{column}必須介於 {min} 與 {max} 之間。");
```

### NumberValidator

- **SetValueIsNumberAccessor**：值不是有效數值
- **SetValueGreaterOrEqualAccessor**：值小於最小值
- **SetValueLessOrEqualAccessor**：值大於最大值
- **SetValueInRangeAccessor**：值不在指定範圍內

```csharp
ErrorMessageProvider.SetValueIsNumberAccessor((column, value) => 
    $"{column}必須為數值。");
```

### DateTimeValidator

- **SetValueIsDateTimeAccessor**：值不是有效日期
- **SetValueGreaterOrEqualAccessor**：日期早於最小日期
- **SetValueLessOrEqualAccessor**：日期晚於最大日期
- **SetValueInRangeAccessor**：日期不在指定範圍內

```csharp
ErrorMessageProvider.SetValueIsDateTimeAccessor((column, value) => 
    $"{column}必須為有效日期。");
```

### ValueLengthValidator

- **SetValueLengthGreaterOrEqualAccessor**：長度小於最小長度
- **SetValueLengthLessOrEqualAccessor**：長度大於最大長度
- **SetValueLengthInRangeAccessor**：長度不在指定範圍內

```csharp
ErrorMessageProvider.SetValueLengthGreaterOrEqualAccessor((column, value, minLength)
    => $"{column}長度不得少於 {minLength} 個字元。");

ErrorMessageProvider.SetValueLengthLessOrEqualAccessor((column, value, maxLength)
    => $"{column}長度不得超過 {maxLength} 個字元。");

ErrorMessageProvider.SetValueLengthInRangeAccessor((column, value, minLength, maxLength)
    => $"{column}長度必須介於 {minLength} 與 {maxLength} 個字元之間。");
```

### RegexValidator

- **SetValueMatchRegexAccessor**：值不符合正規表示式

```csharp
ErrorMessageProvider.SetValueMatchRegexAccessor((column, value, pattern)
    => $"{column}格式不正確。");
```

### EmailValidator

- **SetValueIsEmailAccessor**：值不是有效的 Email 格式

```csharp
ErrorMessageProvider.SetValueIsEmailAccessor((column, value)
    => $"{column}必須為有效的 Email 地址。");
```

### MobilePhoneValidator

- **SetValueIsMobilePhoneAccessor**：值不是有效的手機號碼

```csharp
ErrorMessageProvider.SetValueIsMobilePhoneAccessor((column, value)
    => $"{column}必須為有效的手機號碼。");
```

### IdCardValidator

- **SetValueIsIdCardAccessor**：值不是有效的身分證字號

```csharp
ErrorMessageProvider.SetValueIsIdCardAccessor((column, value)
    => $"{column}必須為有效的身分證字號。");
```

### CompareValidator

- **SetValueCompareAnotherColumnValueAccessor**：兩個欄位的值不相等

```csharp
ErrorMessageProvider.SetValueCompareAnotherColumnValueAccessor(
    (column, value, compareColumn, compareValue)
    => $"{column}必須與{compareColumn}相同。");
```

### IntegerLessThanValidator

- **SetValueLessThanAnotherColumnValueAccessor**：整數值不小於比較值

```csharp
ErrorMessageProvider.SetValueLessThanAnotherColumnValueAccessor(
    (column, value, compareColumn, compareValue, allowedEqual)
    => allowedEqual 
        ? $"{column}必須小於或等於{compareColumn}。"
        : $"{column}必須小於{compareColumn}。");
```

### NumberLessThanValidator

- **SetValueLessThanAnotherColumnValueAccessor**：數值不小於比較值

> [!NOTE]
> 與 `IntegerLessThanValidator` 共用相同的 Accessor。

### DateTimeLessThanValidator

- **SetValueLessThanAnotherColumnValueAccessor**：日期不早於比較日期

> [!NOTE]
> 與 `IntegerLessThanValidator` 共用相同的 Accessor。

## 完整範例

以下範例展示如何在應用程式啟動時設定所有錯誤訊息：

```csharp
using CloudyWing.FormValidators.Core;

public class Program {
    public static void Main(string[] args) {
        // 設定錯誤訊息
        ConfigureErrorMessages();

        // 您的應用程式邏輯...
    }

    private static void ConfigureErrorMessages() {
        // 基本驗證
        ErrorMessageProvider.SetValueIsRequiredAccessor((column, value)
            => $"{column}為必填欄位。");

        // 型別驗證
        ErrorMessageProvider.SetValueIsIntegerAccessor((column, value)
            => $"{column}必須為整數。");
        
        ErrorMessageProvider.SetValueIsNumberAccessor((column, value)
            => $"{column}必須為數值。");
        
        ErrorMessageProvider.SetValueIsDateTimeAccessor((column, value)
            => $"{column}必須為有效日期。");

        // 範圍驗證
        ErrorMessageProvider.SetValueInRangeAccessor((column, value, min, max)
            => $"{column}必須介於 {min} 與 {max} 之間。");

        // 長度驗證
        ErrorMessageProvider.SetValueLengthInRangeAccessor((column, value, minLength, maxLength)
            => $"{column}長度必須介於 {minLength} 與 {maxLength} 個字元之間。");

        // 格式驗證
        ErrorMessageProvider.SetValueIsEmailAccessor((column, value)
            => $"請輸入有效的 Email 地址。");
        
        ErrorMessageProvider.SetValueIsMobilePhoneAccessor((column, value)
            => $"請輸入有效的手機號碼。");

        // 比較驗證
        ErrorMessageProvider.SetValueCompareAnotherColumnValueAccessor(
            (column, value, compareColumn, compareValue)
            => $"{column}必須與{compareColumn}相同。");
    }
}
```

## 多語言支援

您可以根據使用者的語言偏好動態設定錯誤訊息：

```csharp
public static void ConfigureErrorMessages(string language) {
    switch (language) {
        case "en-US":
            ErrorMessageProvider.SetValueIsRequiredAccessor((column, value)
                => $"{column} is required.");
            ErrorMessageProvider.SetValueIsEmailAccessor((column, value)
                => $"{column} must be a valid email address.");
            break;

        case "zh-TW":
            ErrorMessageProvider.SetValueIsRequiredAccessor((column, value)
                => $"{column}為必填欄位。");
            ErrorMessageProvider.SetValueIsEmailAccessor((column, value)
                => $"{column}必須為有效的 Email 地址。");
            break;
    }
}
```

## 最佳實踐

### 1. 統一管理

將所有錯誤訊息設定集中在一個方法中，便於維護：

```csharp
public static class ErrorMessageConfig {
    public static void Configure() {
        // 所有錯誤訊息設定...
    }
}
```

### 2. 提供詳細資訊

錯誤訊息應包含足夠的資訊，讓使用者了解如何修正：

```csharp
// ✗ 不夠明確
ErrorMessageProvider.SetValueLengthInRangeAccessor((column, value, min, max)
    => $"{column}長度錯誤。");

// ✓ 明確且有幫助
ErrorMessageProvider.SetValueLengthInRangeAccessor((column, value, min, max)
    => $"{column}長度必須介於 {min} 與 {max} 個字元之間（目前長度：{value?.Length ?? 0}）。");
```

### 3. 考慮使用者體驗

使用友善的語氣，避免過於技術性的用語：

```csharp
// ✗ 過於技術性
ErrorMessageProvider.SetValueIsIntegerAccessor((column, value)
    => $"{column}: Invalid integer format. Expected: [-]?[0-9]+);

// ✓ 使用者友善
ErrorMessageProvider.SetValueIsIntegerAccessor((column, value)
    => $"{column}必須為整數（例如：123、-456）。");
```

## 相關資源

- [驗證器介紹](validators.md) - 了解所有驗證器
- [使用範例](usage-examples.md) - 查看驗證器的實際應用
- @CloudyWing.FormValidators.Core.ErrorMessageProvider - ErrorMessageProvider API
