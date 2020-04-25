using System;
using UnityEngine;
using Unity.Mathematics;
using UniRx;

namespace EaseRx.Runtime
{
    public static class EaseRxExtension
    {
        public static IObservable<float> Linear(this IObservable<float> input) => input.Select(t => t);

        public static IObservable<float> EaseInQuad(this IObservable<float> input) => input.Select(t => t * t);
        public static IObservable<float> EaseOutQuad(this IObservable<float> input) => input.Select(t => t * (2 - t));

        public static IObservable<float> EaseInOutQuad(this IObservable<float> input) =>
            input.Select(t => t < 0.5 ? 2 * t * t : -1 + (4 - 2 * t) * t);

        public static IObservable<float> EaseInCubic(this IObservable<float> input) => input.Select(t => t * t * t);

        public static IObservable<float> EaseOutCubic(this IObservable<float> input) =>
            input.Select(t => (--t) * t * t + 1);

        public static IObservable<float> EaseInOutCubic(this IObservable<float> input) =>
            input.Select(t => t < .5 ? 4 * t * t * t : (t - 1) * (2 * t - 2) * (2 * t - 2) + 1);

        public static IObservable<float> EaseInQuart(this IObservable<float> input) => input.Select(t => t * t * t * t);

        public static IObservable<float> EaseOutQuart(this IObservable<float> input) =>
            input.Select(t => 1 - (--t) * t * t * t);

        public static IObservable<float> EaseInOutQuart(this IObservable<float> input) =>
            input.Select(t => t < .5 ? 8 * t * t * t * t : 1 - 8 * (--t) * t * t * t);

        public static IObservable<float> EaseInQuint(this IObservable<float> input) =>
            input.Select(t => t * t * t * t * t);

        public static IObservable<float> EaseOutQuint(this IObservable<float> input) =>
            input.Select(t => 1 + (--t) * t * t * t * t);

        public static IObservable<float> EaseInOutQuint(this IObservable<float> input) =>
            input.Select(t => t < .5 ? 16 * t * t * t * t * t : 1 + 16 * (--t) * t * t * t * t);
        
        public static IObservable<float> FromTo(this IObservable<float> input, float from, float to) =>
            input.Select(t => Mathf.Lerp(from, to, t));
        
        public static IObservable<Vector2> FromTo(this IObservable<float> input, Vector2 from, Vector2 to) =>
            input.Select(t => Vector2.Lerp(from, to, t));
        
        public static IObservable<Vector3> FromTo(this IObservable<float> input, Vector3 from, Vector3 to) =>
            input.Select(t => Vector3.Lerp(from, to, t));
        
        public static IObservable<Vector4> FromTo(this IObservable<float> input, Vector4 from, Vector4 to) =>
            input.Select(t => Vector4.Lerp(from, to, t));
        
        public static IObservable<float2> FromTo(this IObservable<float> input, float2 from, float2 to) =>
            input.Select(t => math.lerp(from, to, t));
        
        public static IObservable<float3> FromTo(this IObservable<float> input, float3 from, float3 to) =>
            input.Select(t => math.lerp(from, to, t));
        
        public static IObservable<float4> FromTo(this IObservable<float> input, float4 from, float4 to) =>
            input.Select(t => math.lerp(from, to, t));
        
        public static IObservable<quaternion> FromTo(this IObservable<float> input, quaternion from, quaternion to) =>
            input.Select(t => math.slerp(from, to, t));
        
        public static IObservable<Quaternion> FromTo(this IObservable<float> input, Quaternion from, Quaternion to) =>
            input.Select(t => Quaternion.Lerp(from, to, t));
    }
}