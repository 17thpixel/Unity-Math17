using UnityEngine;

namespace Math17
{
    public static class Vector3Extension
    {
        public static Vector2 xy(this Vector3 vector3)
        {
            return new Vector2(vector3.x, vector3.y);
        }

        public static Vector3 z(this Vector3 vector3, float value)
        {
            return new Vector3(vector3.x, vector3.y, value);
        }

        public static float Distance2D(this Vector3 a, Vector3 b)
        {
            float dx = a.x - b.x;
            float dy = a.y - b.y;
            return Mathf.Sqrt(dx * dx + dy * dy);
        }
    }
}
