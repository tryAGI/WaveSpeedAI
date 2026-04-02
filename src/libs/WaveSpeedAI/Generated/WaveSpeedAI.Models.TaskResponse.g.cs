#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TaskResponse : global::System.IEquatable<TaskResponse>
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
        public global::WaveSpeedAI.TaskResponseVariant2? TaskResponseVariant2 { get; init; }
#else
        public global::WaveSpeedAI.TaskResponseVariant2? TaskResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TaskResponseVariant2))]
#endif
        public bool IsTaskResponseVariant2 => TaskResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TaskResponse(global::WaveSpeedAI.ApiResponse value) => new TaskResponse((global::WaveSpeedAI.ApiResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WaveSpeedAI.ApiResponse?(TaskResponse @this) => @this.Api;

        /// <summary>
        /// 
        /// </summary>
        public TaskResponse(global::WaveSpeedAI.ApiResponse? value)
        {
            Api = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TaskResponse(global::WaveSpeedAI.TaskResponseVariant2 value) => new TaskResponse((global::WaveSpeedAI.TaskResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WaveSpeedAI.TaskResponseVariant2?(TaskResponse @this) => @this.TaskResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TaskResponse(global::WaveSpeedAI.TaskResponseVariant2? value)
        {
            TaskResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TaskResponse(
            global::WaveSpeedAI.ApiResponse? api,
            global::WaveSpeedAI.TaskResponseVariant2? taskResponseVariant2
            )
        {
            Api = api;
            TaskResponseVariant2 = taskResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TaskResponseVariant2 as object ??
            Api as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Api?.ToString() ??
            TaskResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApi && IsTaskResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::WaveSpeedAI.ApiResponse?, TResult>? api = null,
            global::System.Func<global::WaveSpeedAI.TaskResponseVariant2?, TResult>? taskResponseVariant2 = null,
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
            else if (IsTaskResponseVariant2 && taskResponseVariant2 != null)
            {
                return taskResponseVariant2(TaskResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::WaveSpeedAI.ApiResponse?>? api = null,
            global::System.Action<global::WaveSpeedAI.TaskResponseVariant2?>? taskResponseVariant2 = null,
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
            else if (IsTaskResponseVariant2)
            {
                taskResponseVariant2?.Invoke(TaskResponseVariant2!);
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
                TaskResponseVariant2,
                typeof(global::WaveSpeedAI.TaskResponseVariant2),
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
        public bool Equals(TaskResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::WaveSpeedAI.ApiResponse?>.Default.Equals(Api, other.Api) &&
                global::System.Collections.Generic.EqualityComparer<global::WaveSpeedAI.TaskResponseVariant2?>.Default.Equals(TaskResponseVariant2, other.TaskResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TaskResponse obj1, TaskResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TaskResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TaskResponse obj1, TaskResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TaskResponse o && Equals(o);
        }
    }
}
