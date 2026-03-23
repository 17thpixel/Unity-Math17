using UnityEngine;

namespace Math17
{
    public static class ColorExtension
    {
        /// <summary>
        /// Creates new color with alpha changed to new value.
        /// </summary>        
        public static Color NewAlpha(this Color color, float newAlpha)
        {
            return new Color(color.r, color.g, color.b, newAlpha);
        }
    }
}