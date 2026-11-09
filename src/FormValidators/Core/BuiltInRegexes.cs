using System;
using System.Text.RegularExpressions;

namespace CloudyWing.FormValidators.Core;

/// <summary>
/// Provides the cached regular expressions used by the built-in validators.
/// </summary>
internal static partial class BuiltInRegexes {
    // 內建 pattern 皆不含巢狀量詞歧義，timeout 只作為超長輸入的防線
    public const int MatchTimeoutMilliseconds = 1000;

    // 以 atomic group 與 \z 避免回溯與結尾換行；網域至少要有一個「.」
    public const string EmailPattern = @"^(?>\w+)(?:[-+.'](?>\w+))*@(?>\w+)(?:-(?>\w+))*(?:\.(?>\w+)(?:-(?>\w+))*)+\z";

    public const string MobilePhonePattern = @"^09[0-9]{2}-?[0-9]{3}-?[0-9]{3}\z";

    public const string MobilePhoneWithDashesPattern = @"^09[0-9]{2}-[0-9]{3}-[0-9]{3}\z";

    public const string MobilePhoneWithoutDashesPattern = @"^09[0-9]{2}[0-9]{3}[0-9]{3}\z";

#if NET7_0_OR_GREATER
    public static Regex Email => CreateEmail();

    public static Regex MobilePhone => CreateMobilePhone();

    public static Regex MobilePhoneWithDashes => CreateMobilePhoneWithDashes();

    public static Regex MobilePhoneWithoutDashes => CreateMobilePhoneWithoutDashes();

    [GeneratedRegex(EmailPattern, RegexOptions.None, MatchTimeoutMilliseconds)]
    private static partial Regex CreateEmail();

    [GeneratedRegex(MobilePhonePattern, RegexOptions.None, MatchTimeoutMilliseconds)]
    private static partial Regex CreateMobilePhone();

    [GeneratedRegex(MobilePhoneWithDashesPattern, RegexOptions.None, MatchTimeoutMilliseconds)]
    private static partial Regex CreateMobilePhoneWithDashes();

    [GeneratedRegex(MobilePhoneWithoutDashesPattern, RegexOptions.None, MatchTimeoutMilliseconds)]
    private static partial Regex CreateMobilePhoneWithoutDashes();
#else
    private static readonly TimeSpan MatchTimeout = TimeSpan.FromMilliseconds(MatchTimeoutMilliseconds);

    public static Regex Email { get; } = new(EmailPattern, RegexOptions.None, MatchTimeout);

    public static Regex MobilePhone { get; } = new(MobilePhonePattern, RegexOptions.None, MatchTimeout);

    public static Regex MobilePhoneWithDashes { get; } = new(MobilePhoneWithDashesPattern, RegexOptions.None, MatchTimeout);

    public static Regex MobilePhoneWithoutDashes { get; } = new(MobilePhoneWithoutDashesPattern, RegexOptions.None, MatchTimeout);
#endif
}
