using System;
using System.Threading.Tasks;
using CloudyWing.FormValidators.Core;
using NUnit.Framework;

namespace CloudyWing.FormValidators.Tests.Core;

[TestFixture]
public class ErrorMessageScopeTests {
    [TearDown]
    public void TearDown() {
        ErrorMessageProvider.ResetToDefaults();
    }

    [Test]
    public void BeginScope_WithOverride_UsesOverrideInsideScopeOnly() {
        RequiredValidator inside = new("姓名", "");
        RequiredValidator outside = new("姓名", "");

        using (ErrorMessageProvider.BeginScope(new ErrorMessageOverrides { ValueIsRequiredAccessor = (c, v) => $"{c} is required." })) {
            inside.Validate();
        }

        outside.Validate();

        using (Assert.EnterMultipleScope()) {
            Assert.That(inside.ErrorMessage, Is.EqualTo("姓名 is required."));
            Assert.That(outside.ErrorMessage, Is.EqualTo("「姓名」欄位為必填。"));
        }
    }

    [Test]
    public void BeginScope_WithoutOverrideForAccessor_FallsBackToGlobalAccessor() {
        ErrorMessageProvider.SetValueIsIntegerAccessor((c, v) => "global");
        IntegerValidator validator = new("年齡", "abc");

        using (ErrorMessageProvider.BeginScope(new ErrorMessageOverrides { ValueIsRequiredAccessor = (c, v) => "scope" })) {
            validator.Validate();
        }

        Assert.That(validator.ErrorMessage, Is.EqualTo("global"));
    }

    [Test]
    public void BeginScope_Nested_InheritsOuterAndRestoresOnDispose() {
        string? innerRequired;
        string? innerInteger;
        string? outerRequiredAfterInner;

        using (ErrorMessageProvider.BeginScope(new ErrorMessageOverrides {
            ValueIsRequiredAccessor = (c, v) => "outer required",
            ValueIsIntegerAccessor = (c, v) => "outer integer"
        })) {
            using (ErrorMessageProvider.BeginScope(new ErrorMessageOverrides { ValueIsRequiredAccessor = (c, v) => "inner required" })) {
                innerRequired = ErrorMessageProvider.ValueIsRequiredAccessor("", "");
                innerInteger = ErrorMessageProvider.ValueIsIntegerAccessor("", "");
            }

            outerRequiredAfterInner = ErrorMessageProvider.ValueIsRequiredAccessor("", "");
        }

        using (Assert.EnterMultipleScope()) {
            Assert.That(innerRequired, Is.EqualTo("inner required"));
            Assert.That(innerInteger, Is.EqualTo("outer integer"));
            Assert.That(outerRequiredAfterInner, Is.EqualTo("outer required"));
            Assert.That(ErrorMessageProvider.ValueIsRequiredAccessor("姓名", ""), Is.EqualTo("「姓名」欄位為必填。"));
        }
    }

    [Test]
    public void BeginScope_GlobalAccessorSetInsideScope_DoesNotOverrideScope() {
        string message;

        using (ErrorMessageProvider.BeginScope(new ErrorMessageOverrides { ValueIsRequiredAccessor = (c, v) => "scope" })) {
            ErrorMessageProvider.SetValueIsRequiredAccessor((c, v) => "global");
            message = ErrorMessageProvider.ValueIsRequiredAccessor("", "");
        }

        using (Assert.EnterMultipleScope()) {
            Assert.That(message, Is.EqualTo("scope"));
            Assert.That(ErrorMessageProvider.ValueIsRequiredAccessor("", ""), Is.EqualTo("global"));
        }
    }

    [Test]
    public void BeginScope_OverridesChangedAfterBegin_DoesNotAffectScope() {
        ErrorMessageOverrides overrides = new() { ValueIsRequiredAccessor = (c, v) => "before" };
        string message;

        using (ErrorMessageProvider.BeginScope(overrides)) {
            overrides.ValueIsRequiredAccessor = (c, v) => "after";
            message = ErrorMessageProvider.ValueIsRequiredAccessor("", "");
        }

        Assert.That(message, Is.EqualTo("before"));
    }

    [Test]
    public async Task BeginScope_AcrossAwait_FlowsToAsyncContinuationAsync() {
        string message;

        using (ErrorMessageProvider.BeginScope(new ErrorMessageOverrides { ValueIsRequiredAccessor = (c, v) => "scope" })) {
            await Task.Yield();
            message = await Task.Run(() => ErrorMessageProvider.ValueIsRequiredAccessor("", ""));
        }

        Assert.That(message, Is.EqualTo("scope"));
    }

    [Test]
    public async Task BeginScope_InParallelFlows_IsolatesEachFlowAsync() {
        static async Task<string> RunAsync(string text) {
            using (ErrorMessageProvider.BeginScope(new ErrorMessageOverrides { ValueIsRequiredAccessor = (c, v) => text })) {
                await Task.Delay(20);
                return ErrorMessageProvider.ValueIsRequiredAccessor("", "");
            }
        }

        string[] messages = await Task.WhenAll(RunAsync("A"), RunAsync("B"), RunAsync("C"));

        using (Assert.EnterMultipleScope()) {
            Assert.That(messages, Is.EqualTo(new[] { "A", "B", "C" }));
            Assert.That(ErrorMessageProvider.ValueIsRequiredAccessor("姓名", ""), Is.EqualTo("「姓名」欄位為必填。"));
        }
    }

    [Test]
    public void Dispose_CalledTwice_KeepsOuterScope() {
        string message;

        using (ErrorMessageProvider.BeginScope(new ErrorMessageOverrides { ValueIsRequiredAccessor = (c, v) => "outer" })) {
            IDisposable inner = ErrorMessageProvider.BeginScope(new ErrorMessageOverrides { ValueIsRequiredAccessor = (c, v) => "inner" });
            inner.Dispose();
            inner.Dispose();
            message = ErrorMessageProvider.ValueIsRequiredAccessor("", "");
        }

        Assert.That(message, Is.EqualTo("outer"));
    }

    [Test]
    public void BeginScope_NullOverrides_ThrowsArgumentNullException() {
        Assert.Throws<ArgumentNullException>(() => ErrorMessageProvider.BeginScope(null!));
    }
}
