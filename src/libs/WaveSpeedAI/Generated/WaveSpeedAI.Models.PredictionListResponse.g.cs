#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PredictionListResponse : global::System.IEquatable<PredictionListResponse>
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
        public global::WaveSpeedAI.PredictionListResponseVariant2? PredictionListResponseVariant2 { get; init; }
#else
        public global::WaveSpeedAI.PredictionListResponseVariant2? PredictionListResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PredictionListResponseVariant2))]
#endif
        public bool IsPredictionListResponseVariant2 => PredictionListResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PredictionListResponse(global::WaveSpeedAI.ApiResponse value) => new PredictionListResponse((global::WaveSpeedAI.ApiResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WaveSpeedAI.ApiResponse?(PredictionListResponse @this) => @this.Api;

        /// <summary>
        /// 
        /// </summary>
        public PredictionListResponse(global::WaveSpeedAI.ApiResponse? value)
        {
            Api = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PredictionListResponse(global::WaveSpeedAI.PredictionListResponseVariant2 value) => new PredictionListResponse((global::WaveSpeedAI.PredictionListResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WaveSpeedAI.PredictionListResponseVariant2?(PredictionListResponse @this) => @this.PredictionListResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PredictionListResponse(global::WaveSpeedAI.PredictionListResponseVariant2? value)
        {
            PredictionListResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PredictionListResponse(
            global::WaveSpeedAI.ApiResponse? api,
            global::WaveSpeedAI.PredictionListResponseVariant2? predictionListResponseVariant2
            )
        {
            Api = api;
            PredictionListResponseVariant2 = predictionListResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PredictionListResponseVariant2 as object ??
            Api as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Api?.ToString() ??
            PredictionListResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApi && IsPredictionListResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::WaveSpeedAI.ApiResponse?, TResult>? api = null,
            global::System.Func<global::WaveSpeedAI.PredictionListResponseVariant2?, TResult>? predictionListResponseVariant2 = null,
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
            else if (IsPredictionListResponseVariant2 && predictionListResponseVariant2 != null)
            {
                return predictionListResponseVariant2(PredictionListResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::WaveSpeedAI.ApiResponse?>? api = null,
            global::System.Action<global::WaveSpeedAI.PredictionListResponseVariant2?>? predictionListResponseVariant2 = null,
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
            else if (IsPredictionListResponseVariant2)
            {
                predictionListResponseVariant2?.Invoke(PredictionListResponseVariant2!);
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
                PredictionListResponseVariant2,
                typeof(global::WaveSpeedAI.PredictionListResponseVariant2),
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
        public bool Equals(PredictionListResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::WaveSpeedAI.ApiResponse?>.Default.Equals(Api, other.Api) &&
                global::System.Collections.Generic.EqualityComparer<global::WaveSpeedAI.PredictionListResponseVariant2?>.Default.Equals(PredictionListResponseVariant2, other.PredictionListResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PredictionListResponse obj1, PredictionListResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PredictionListResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PredictionListResponse obj1, PredictionListResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PredictionListResponse o && Equals(o);
        }
    }
}
