using System;
using System.Collections;
using UnityEngine;
using UniRx;

namespace EaseRx.Runtime
{
    public static class EaseRx
    {
        public static IObservable<float> Ease(TimeSpan timeSpan) =>
            Observable.FromMicroCoroutine((IObserver<float> observer) => Ease(observer, timeSpan));

        private static IEnumerator Ease(IObserver<float> observer, TimeSpan timeSpan)
        {
            for (var time = 0.0f; time < 1.0f; time += Time.deltaTime / (float) timeSpan.TotalSeconds)
            {
                observer.OnNext(time);
                yield return null;
            }

            observer.OnNext(1);
            observer.OnCompleted();
        }
    }
}