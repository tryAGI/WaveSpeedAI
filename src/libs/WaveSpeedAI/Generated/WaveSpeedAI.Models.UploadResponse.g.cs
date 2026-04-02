#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UploadResponse : global::System.IEquatable<UploadResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WaveSpeedAI.ApiResponse? Api { get; init; }
#else
        public global::WaveSpeedAI.ApiResponse? Api { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Api))]
#endif
        public bool IsApi => Api != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WaveSpeedAI.UploadResponseVariant2? UploadResponseVariant2 { get; init; }
#else
        public global::WaveSpeedAI.UploadResponseVariant2? UploadResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UploadResponseVariant2))]
#endif
        public bool IsUploadResponseVariant2 => UploadResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UploadResponse(global::WaveSpeedAI.ApiResponse value) => new UploadResponse((global::WaveSpeedAI.ApiResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WaveSpeedAI.ApiResponse?(UploadResponse @this) => @this.Api;

        /// <summary>
        /// 
        /// </summary>
        public UploadResponse(global::WaveSpeedAI.ApiResponse? value)
        {
            Api = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UploadResponse(global::WaveSpeedAI.UploadResponseVariant2 value) => new UploadResponse((global::WaveSpeedAI.UploadResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WaveSpeedAI.UploadResponseVariant2?(UploadResponse @this) => @this.UploadResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UploadResponse(global::WaveSpeedAI.UploadResponseVariant2? value)
        {
            UploadResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UploadResponse(
            global::WaveSpeedAI.ApiResponse? api,
            global::WaveSpeedAI.UploadResponseVariant2? uploadResponseVariant2
            )
        {
            Api = api;
            UploadResponseVariant2 = uploadResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UploadResponseVariant2 as object ??
            Api as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Api?.ToString() ??
            UploadResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApi && IsUploadResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::WaveSpeedAI.ApiResponse?, TResult>? api = null,
            global::System.Func<global::WaveSpeedAI.UploadResponseVariant2?, TResult>? uploadResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApi && api != null)
            {
                return api(Api!);
            }
            else if (IsUploadResponseVariant2 && uploadResponseVariant2 != null)
            {
                return uploadResponseVariant2(UploadResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::WaveSpeedAI.ApiResponse?>? api = null,
            global::System.Action<global::WaveSpeedAI.UploadResponseVariant2?>? uploadResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApi)
            {
                api?.Invoke(Api!);
            }
            else if (IsUploadResponseVariant2)
            {
                uploadResponseVariant2?.Invoke(UploadResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Api,
                typeof(global::WaveSpeedAI.ApiResponse),
                UploadResponseVariant2,
                typeof(global::WaveSpeedAI.UploadResponseVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(UploadResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::WaveSpeedAI.ApiResponse?>.Default.Equals(Api, other.Api) &&
                global::System.Collections.Generic.EqualityComparer<global::WaveSpeedAI.UploadResponseVariant2?>.Default.Equals(UploadResponseVariant2, other.UploadResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UploadResponse obj1, UploadResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UploadResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UploadResponse obj1, UploadResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UploadResponse o && Equals(o);
        }
    }
}
