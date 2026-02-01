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

驗證 `Value` 的長度是否符合指定範圍。

**相關 API**：@CloudyWing.FormValidators.ValueLengthValidator

### BulkValidator

批量驗證容器，可包含多個驗證器。參數 `isStoppedIfFail` 可控制驗證不通過時，是否繼續後續驗證。

**相關 API**：@CloudyWing.FormValidators.BulkValidator

## 型別驗證

提供驗證值是否可轉型成特定型別，及最大值和最小值驗證。

### IntegerValidator

整數和極限值驗證，資料型別為 `long`。

**參數**：

- `allowedThousands`：是否允許千分位符號

**相關 API**：@CloudyWing.FormValidators.IntegerValidator

### NumberValidator

數值和極限值驗證，資料型別為 `decimal`。

**參數**：

- `allowedThousands`：是否允許千分位符號

**相關 API**：@CloudyWing.FormValidators.NumberValidator

### DateTimeValidator

日期和極限值驗證，資料型別為 `DateTime`。

**相關 API**：@CloudyWing.FormValidators.DateTimeValidator

## 比較驗證

### CompareValidator

比較兩欄位的值是否相等。

**相關 API**：@CloudyWing.FormValidators.CompareValidator

### IntegerLessThanValidator

整數欄位比較，`Value` 必須小於比較的值。

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

**相關 API**：@CloudyWing.FormValidators.RegexValidator

### EmailValidator

Email 格式驗證。

**相關 API**：@CloudyWing.FormValidators.EmailValidator

### MobilePhoneValidator

手機格式驗證。

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

信用卡號碼驗證。

**相關 API**：@CloudyWing.FormValidators.CreditCardValidator

### UrlValidator

URL 格式驗證。

**相關 API**：@CloudyWing.FormValidators.UrlValidator

### IPAddressValidator

IP 位址驗證。

**參數**：

- `IPAddressTypes`：可指定允許的 IP 類型（IPv4、IPv6 或兩者）

**相關 API**：@CloudyWing.FormValidators.IPAddressValidator

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

## 範例

查看 [使用範例](usage-examples.md) 了解如何在實際應用中使用這些驗證器。
