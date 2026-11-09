using System.Diagnostics.CodeAnalysis;

namespace CloudyWing.FormValidators.Core;

/// <summary>
/// Provides string helpers with nullable flow annotations for every target framework.
/// </summary>
internal static class StringUtils {
    // netstandard2.0 與 net45 的 string.IsNullOrWhiteSpace 沒有 NotNullWhen 標註，編譯器無法推斷後續為非 null
    public static bool IsNullOrWhiteSpace([NotNullWhen(false)] string? value) {
        return string.IsNullOrWhiteSpace(value);
    }
}
