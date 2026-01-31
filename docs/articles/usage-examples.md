---
title: 使用範例
description: FormValidators 的實際應用範例
---

本文提供 FormValidators 的各種使用情境範例。

## 範例 1：驗證全部項目，並取得全部驗證的錯誤訊息

**情境**：您需要驗證表單中的所有欄位，並在驗證失敗時顯示所有錯誤訊息。

```csharp
// 建立容器，並將 Validator 加入 Bulk 裡
BulkValidator validators = new();

// 驗證是否有值
validators.Add(new RequiredValidator("欄位一", "值一"));

// 驗證基本原則，當值為 Null、空格和空字串由 RequiredValidator 驗證
// 其他驗證遇到上述情況都回傳 true
validators.Add(new IntegerValidator("欄位一", "值一"));

// 一些特別情況可以使用 TrueAssertValidator 判斷第一個參數為 true 來表示驗證通過
// 也可用 FalseAssertValidator 判斷 false 為通過
validators.Add(new TrueAssertValidator(condition, "錯誤訊息"));

// 進行資料驗證
if (!validators.Validate()) {
    // 驗證失敗使用 validators.ErrorMessage 取得錯誤訊息
    // 多個錯誤訊息使用 <br /> 隔開
    // ErrorMessageWithBR 等同於 ErrorMessage
    
    // 您也可以使用其他格式：
    // ErrorMessageWithLF：使用 \n 隔開
    // ErrorMessageWithNewLine：使用 Environment.NewLine 隔開
    
    string errorMessage = validators.ErrorMessage;
}
```

**輸出範例**：

```text
欄位一為必填。<br />欄位一必須為整數。<br />錯誤訊息
```

## 範例 2：驗證失敗後，停止驗證後續項目，只取得第一個錯誤訊息

**情境**：您希望在遇到第一個錯誤時立即停止驗證，提升效能並簡化錯誤訊息。

```csharp
// 建立容器，並將 Validator 加入批量裡
// 第一個參數設為 true，表示遇到錯誤即停止
BulkValidator validators = new(true);

// TrueAssert 遇到 true，驗證成功
validators.Add(new TrueAssertValidator(true, "錯誤訊息一"));

// TrueAssert 遇到 false，驗證失敗（會在這裡停止）
validators.Add(new TrueAssertValidator(false, "錯誤訊息二"));

// 這個驗證不會執行
validators.Add(new TrueAssertValidator(false, "錯誤訊息三"));

if (!validators.Validate()) {
    // 驗證失敗使用 validators.ErrorMessage 取得錯誤訊息
    // 錯誤訊息為「錯誤訊息二」
    string errorMessage = validators.ErrorMessage;
}
```

**輸出範例**：

```text
錯誤訊息二
```

## 範例 3：混合使用批量驗證

**情境**：您需要對某些欄位群組進行「遇錯即停」驗證，但整體表單仍要收集所有錯誤。

```csharp
BulkValidator validators = new() {
    // 這個內層 Bulk 設定為 true（遇錯即停）
    new BulkValidator(true) {
        new TrueAssertValidator(true, "錯誤訊息一"),
        new TrueAssertValidator(false, "錯誤訊息二"),  // 在這裡停止
        new TrueAssertValidator(false, "錯誤訊息三")   // 不會執行
    },
    // 外層繼續執行其他驗證
    new TrueAssertValidator(true, "錯誤訊息四"),
    new TrueAssertValidator(false, "錯誤訊息五"),
    new TrueAssertValidator(false, "錯誤訊息六")
};

if (!validators.Validate()) {
    // validators.ErrorMessage 為 "錯誤訊息二<br />錯誤訊息五<br />錯誤訊息六"
    string errorMessage = validators.ErrorMessage;
}
```

**輸出範例**：

```text
錯誤訊息二<br />錯誤訊息五<br />錯誤訊息六
```

## 範例 4：使用 ValidationProvider 簡化建立程式碼

**情境**：使用 Fluent API 語法，讓程式碼更簡潔易讀。

```csharp
BulkValidator validators = new(cfg => {
    // 增加一個驗證
    cfg.Add("欄位一", "值一",
        opt => opt.Required()
    );
    
    // 增加多個驗證
    cfg.Add("欄位二", "值二", 
        opt => opt.Required(), 
        opt => opt.DateTime()
    );
    
    // 條件式驗證：只有當 condition 為 true 時，才會驗證
    cfg.AddIf(
        condition, "欄位三", "值三", 
        opt => opt.Required(), 
        opt => opt.DateTime()
    );
    
    // 直接加入斷言驗證
    cfg.AddTrueAssert(true, "錯誤訊息");
    
    // 巢狀 Bulk 驗證
    cfg.AddBulk(_cfg => {
        _cfg.Add("欄位四", "值四",
            opt => opt.Required()
        );
    });
});

if (!validators.Validate()) {
    Console.WriteLine(validators.ErrorMessage);
}
```

## 範例 5：實際表單驗證範例

**情境**：驗證使用者註冊表單。

```csharp
public class RegisterForm {
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public string Age { get; set; }
    public string PhoneNumber { get; set; }

    public bool Validate(out string errorMessage) {
        BulkValidator validators = new(cfg => {
            // 使用者名稱：必填，長度 3-20
            cfg.Add("使用者名稱", UserName,
                opt => opt.Required(),
                opt => opt.ValueLength(3, 20)
            );

            // Email：必填，格式驗證
            cfg.Add("Email", Email,
                opt => opt.Required(),
                opt => opt.Email()
            );

            // 密碼：必填，長度至少 8
            cfg.Add("密碼", Password,
                opt => opt.Required(),
                opt => opt.ValueLength(8)
            );

            // 確認密碼：必填，與密碼相同
            cfg.Add("確認密碼", ConfirmPassword,
                opt => opt.Required(),
                opt => opt.Compare(Password, "密碼")
            );

            // 年齡：必填，整數，範圍 18-100
            cfg.Add("年齡", Age,
                opt => opt.Required(),
                opt => opt.Integer(18, 100)
            );

            // 手機號碼：非必填，但有值時需符合格式
            cfg.Add("手機號碼", PhoneNumber,
                opt => opt.MobilePhone()
            );
        });

        bool isValid = validators.Validate();
        errorMessage = validators.ErrorMessage;
        return isValid;
    }
}
```

**使用方式**：

```csharp
RegisterForm form = new() {
    UserName = "john_doe",
    Email = "john@example.com",
    Password = "password123",
    ConfirmPassword = "password123",
    Age = "25",
    PhoneNumber = "0912345678"
};

if (!form.Validate(out string errorMessage)) {
    Console.WriteLine("驗證失敗：");
    Console.WriteLine(errorMessage);
} else {
    Console.WriteLine("驗證通過！");
    // 繼續處理註冊邏輯...
}
```

## 進階技巧

### 動態條件驗證

使用 `AddIf` 根據條件決定是否進行驗證：

```csharp
bool isCorporateAccount = true;

BulkValidator validators = new(cfg => {
    cfg.Add("公司名稱", companyName,
        opt => opt.Required()
    );
    
    // 只有企業帳號需要驗證統一編號
    cfg.AddIf(
        isCorporateAccount, "統一編號", taxId,
        opt => opt.Required(),
        opt => opt.ValueLength(8, 8)
    );
});
```

### 延遲執行驗證

使用 `Func<bool>` 延遲條件判斷：

```csharp
cfg.AddTrueAssert(() => {
    // 這個條件會在 Validate() 時才執行
    return DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 17;
}, "服務時間為 09:00 - 17:00");
```

## 相關資源

- [驗證器介紹](validators.md) - 了解所有可用的驗證器
- [客製化驗證](customization.md) - 建立自訂驗證器
- [錯誤訊息設定](error-messages.md) - 自訂錯誤訊息
- [API 參考](../api/index.md) - 完整 API 文檔
