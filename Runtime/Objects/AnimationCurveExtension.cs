using UnityEngine;

namespace Math17
{
    public static class AnimationCurveExtension
    {
        /// <summary>
        /// Computes time of the last key it represents animation time.
        /// </summary>        
        public static float LastKeyTime(this AnimationCurve curve)
        {
            return curve[curve.length - 1].time;
        }
    }
}