using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests;

[TestFixture]
public class BulkValidatorExtensionsTests {
    [Test]
    public async Task ValidateAsync_WithSyncAndAsyncValidators_CollectsErrorsInOrderAsync() {
        BulkValidator validators = [
            new RequiredValidator("姓名", ""),
            new AsyncCustomValidator("帳號", "wing", async (value, token) => {
                await Task.Yield();
                return value != "wing";
            }),
            new TrueAssertValidator(false, "條件不成立")
        ];

        bool isValid = await validators.ValidateAsync();

        using (Assert.EnterMultipleScope()) {
            Assert.That(isValid, Is.False);
            Assert.That(validators.IsValid, Is.False);
            Assert.That(validators.ErrorMessages, Is.EqualTo(new[] { "「姓名」欄位為必填。", "「帳號」不符合規則。", "條件不成立" }));
            Assert.That(validators.Errors.Select(x => x.Column), Is.EqualTo(new[] { "姓名", "帳號", null }));
        }
    }

    [Test]
    public async Task ValidateAsync_WhenStoppedIfFail_DoesNotRunLaterValidatorsAsync() {
        List<string> calls = [];
        BulkValidator validators = new(true) {
            new AsyncCustomValidator("一", "x", (value, token) => {
                calls.Add("一");
                return Task.FromResult(false);
            }),
            new AsyncCustomValidator("二", "x", (value, token) => {
                calls.Add("二");
                return Task.FromResult(false);
            })
        };

        bool isValid = await validators.ValidateAsync();

        using (Assert.EnterMultipleScope()) {
            Assert.That(isValid, Is.False);
            Assert.That(calls, Is.EqualTo(new[] { "一" }));
            Assert.That(validators.ErrorMessages, Has.Count.EqualTo(1));
        }
    }

    [Test]
    public async Task ValidateAsync_WithNestedBulkAndStoppedIfFail_MatchesSyncSemanticsAsync() {
        BulkValidator validators = [
            new BulkValidator(true) {
                new TrueAssertValidator(true, "1"),
                new AsyncCustomValidator("二", "x", (value, token) => Task.FromResult(false), (c, v) => "2"),
                new TrueAssertValidator(false, "3")
            },
            new TrueAssertValidator(false, "4")
        ];

        bool isValid = await validators.ValidateAsync();

        using (Assert.EnterMultipleScope()) {
            Assert.That(isValid, Is.False);
            Assert.That(validators.ErrorMessages, Is.EqualTo(new[] { "2", "4" }));
        }
    }

    [Test]
    public async Task ValidateAsync_AllValid_ReturnsTrueAsync() {
        BulkValidator validators = [
            new RequiredValidator("姓名", "Wing"),
            new AsyncCustomValidator("帳號", "new", (value, token) => Task.FromResult(true)),
            new AsyncCustomValidator("暱稱", "", (value, token) => throw new InvalidOperationException("不應被呼叫"))
        ];

        bool isValid = await validators.ValidateAsync();

        Assert.That(isValid, Is.True);
    }

    [Test]
    public void ValidateAsync_CanceledToken_ThrowsOperationCanceledException() {
        BulkValidator validators = [
            new RequiredValidator("姓名", "Wing")
        ];
        using CancellationTokenSource source = new();
        source.Cancel();

        Assert.That(async () => await validators.ValidateAsync(source.Token), Throws.InstanceOf<OperationCanceledException>());
    }

    [Test]
    public async Task ValidateAsync_PassesCancellationTokenToAsyncValidatorAsync() {
        using CancellationTokenSource source = new();
        CancellationToken received = CancellationToken.None;
        BulkValidator validators = [
            new AsyncCustomValidator("帳號", "x", (value, token) => {
                received = token;
                return Task.FromResult(true);
            })
        ];

        await validators.ValidateAsync(source.Token);

        Assert.That(received, Is.EqualTo(source.Token));
    }

    [Test]
    public void ValidateAsync_NullValidators_ThrowsArgumentNullException() {
        Assert.ThrowsAsync<ArgumentNullException>(async () => await BulkValidatorExtensions.ValidateAsync(null!));
    }

    [Test]
    public void Validate_WithAsyncCustomValidator_ThrowsNotSupportedException() {
        AsyncCustomValidator validator = new("帳號", "x", (value, token) => Task.FromResult(true));

        Assert.Throws<NotSupportedException>(() => validator.Validate());
    }

    [Test]
    public async Task ValidationProviderCustomAsync_WithMessageFormat_ReturnsFormattedMessageAsync() {
        BulkValidator validators = new(cfg => {
            cfg.Add("帳號", "wing", opt => opt.CustomAsync((value, token) => Task.FromResult(false), "{0}「{1}」已被使用"));
        });

        await validators.ValidateAsync();

        Assert.That(validators.ErrorMessage, Is.EqualTo("帳號「wing」已被使用"));
    }

    [Test]
    public void ValidationProviderCustomAsync_NullPredicate_ThrowsArgumentNullException() {
        ValidationProvider provider = new();

        Assert.Throws<ArgumentNullException>(() => provider.CustomAsync(null!));
    }
}
