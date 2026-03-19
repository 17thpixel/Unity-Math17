using UnityEngine;

namespace Math17
{
    public static class ColorExtension
    {
        public static Color NewAlpha(this Color color, float a)
        {
            return new Color(color.r, color.g, color.b, a);
        }
    }
}