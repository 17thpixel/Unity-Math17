using UnityEngine;

namespace Math17
{
    public static class AnimationCurveExtension
    {
        public static float LastKeyTime(this AnimationCurve curve)
        {
            return curve[curve.length - 1].time;
        }
    }
}