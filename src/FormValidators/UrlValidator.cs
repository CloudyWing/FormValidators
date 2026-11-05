using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CloudyWing.FormValidators.Core;

namespace CloudyWing.FormValidators;

/// <summary>
/// The URL validator.
/// </summary>
/// <remarks>
/// By default any URI scheme is accepted, including schemes such as <c>javascript:</c> or <c>file:</c>.
/// Use the constructor that accepts allowed schemes, for example <c>http</c> and <c>https</c>,
/// when the value is rendered as a link or requested by the server.
/// Implicit file paths such as <c>/path</c> or <c>C:\path</c> are not treated as absolute URLs on any platform.
/// </remarks>
public sealed class UrlValidator : BasicFormValidator {
    private readonly string[] allowedSchemes;

    /// <summary>
    /// Initializes a new instance of the <see cref="UrlValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    public UrlValidator(string column, string? value, Func<string, string?, string>? customErrorMessageAccessor = null)
        : this(column, value, UriKind.Absolute, customErrorMessageAccessor) {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UrlValidator" /> class.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="kind">The kind.</param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    public UrlValidator(string column, string? value, UriKind kind, Func<string, string?, string>? customErrorMessageAccessor = null)
        : this(column, value, kind, [], customErrorMessageAccessor) {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UrlValidator" /> class with the allowed URI schemes.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="kind">The kind.</param>
    /// <param name="allowedSchemes">
    /// The allowed schemes of an absolute URL, such as <c>http</c> and <c>https</c>, compared case-insensitively.
    /// An empty collection allows any scheme. Relative URLs are not affected.
    /// </param>
    /// <exception cref="ArgumentNullException"><paramref name="allowedSchemes" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException"><paramref name="allowedSchemes" /> contains a <see langword="null" /> or empty scheme.</exception>
    public UrlValidator(string column, string? value, UriKind kind, IEnumerable<string> allowedSchemes)
        : this(column, value, kind, allowedSchemes, null) {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UrlValidator" /> class with the allowed URI schemes.
    /// </summary>
    /// <param name="column">The column.</param>
    /// <param name="value">The value.</param>
    /// <param name="kind">The kind.</param>
    /// <param name="allowedSchemes">
    /// The allowed schemes of an absolute URL, such as <c>http</c> and <c>https</c>, compared case-insensitively.
    /// An empty collection allows any scheme. Relative URLs are not affected.
    /// </param>
    /// <param name="customErrorMessageAccessor">The custom error message accessor. The arguments are column, value.</param>
    /// <exception cref="ArgumentNullException"><paramref name="allowedSchemes" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException"><paramref name="allowedSchemes" /> contains a <see langword="null" /> or empty scheme.</exception>
    public UrlValidator(
        string column, string? value, UriKind kind, IEnumerable<string> allowedSchemes,
        Func<string, string?, string>? customErrorMessageAccessor
    ) : base(column, value, customErrorMessageAccessor) {
        if (allowedSchemes is null) {
            throw new ArgumentNullException(nameof(allowedSchemes));
        }

        List<string> schemes = [];

        foreach (string scheme in allowedSchemes) {
            if (string.IsNullOrWhiteSpace(scheme)) {
                throw new ArgumentException("Scheme cannot be null or empty.", nameof(allowedSchemes));
            }

            schemes.Add(scheme.Trim().TrimEnd(':'));
        }

        Kind = kind;
        this.allowedSchemes = [.. schemes];
        AllowedSchemes = new ReadOnlyCollection<string>(this.allowedSchemes);
    }

    /// <summary>
    /// Gets the kind.
    /// </summary>
    /// <value>The kind.</value>
    public UriKind Kind { get; }

    /// <summary>
    /// Gets the allowed schemes of an absolute URL.
    /// </summary>
    /// <value>The allowed schemes. An empty collection allows any scheme.</value>
    public IReadOnlyCollection<string> AllowedSchemes { get; }

    /// <inheritdoc/>
    protected override Func<string, string?, string> DefaultErrorMessageAccessor => ErrorMessageProvider.ValueIsUrlAccessor;

    /// <inheritdoc/>
    protected override bool ValidateValue() {
        if (StringUtils.IsNullOrWhiteSpace(Value)) {
            return true;
        }

        if (!Uri.TryCreate(Value, Kind, out Uri? uri)) {
            return false;
        }

        if (!uri.IsAbsoluteUri) {
            return true;
        }

        // Unix 的「/path」與 Windows 的「C:\path」會被 Uri 視為隱含的 file URI，不屬於使用者輸入的網址
        if (!Value.TrimStart().StartsWith(uri.Scheme + ":", StringComparison.OrdinalIgnoreCase)) {
            return Kind == UriKind.RelativeOrAbsolute && Uri.TryCreate(Value, UriKind.Relative, out _);
        }

        return IsAllowedScheme(uri.Scheme);
    }

    private bool IsAllowedScheme(string scheme) {
        if (allowedSchemes.Length == 0) {
            return true;
        }

        foreach (string allowedScheme in allowedSchemes) {
            if (string.Equals(allowedScheme, scheme, StringComparison.OrdinalIgnoreCase)) {
                return true;
            }
        }

        return false;
    }
}
