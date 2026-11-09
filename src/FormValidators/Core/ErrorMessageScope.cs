using System;
#if NETFRAMEWORK
using System.Runtime.Remoting.Messaging;
#else
using System.Threading;
#endif

namespace CloudyWing.FormValidators.Core;

/// <summary>
/// Stores the error message overrides of the current execution context.
/// </summary>
internal sealed class ErrorMessageScope : IDisposable {
#if NETFRAMEWORK
    // net45 沒有 AsyncLocal，改用 logical call context；存放的物件不可變，避免子流程修改影響父流程
    private static readonly string CallContextKey = typeof(ErrorMessageScope).FullName!;
#else
    private static readonly AsyncLocal<ErrorMessageOverrides?> CurrentOverrides = new();
#endif
    private readonly ErrorMessageOverrides? previous;
    private bool isDisposed;

    private ErrorMessageScope(ErrorMessageOverrides? previous) {
        this.previous = previous;
    }

    public static ErrorMessageOverrides? Current {
#if NETFRAMEWORK
        get => CallContext.LogicalGetData(CallContextKey) as ErrorMessageOverrides;
        private set => CallContext.LogicalSetData(CallContextKey, value);
#else
        get => CurrentOverrides.Value;
        private set => CurrentOverrides.Value = value;
#endif
    }

    public static ErrorMessageScope Begin(ErrorMessageOverrides overrides) {
        ErrorMessageOverrides? previous = Current;
        Current = overrides.MergeOver(previous);

        return new ErrorMessageScope(previous);
    }

    public void Dispose() {
        if (isDisposed) {
            return;
        }

        isDisposed = true;
        Current = previous;
    }
}
