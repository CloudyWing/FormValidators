# Changelog

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
