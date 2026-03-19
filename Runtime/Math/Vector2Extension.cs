using UnityEngine;

namespace Math17
{   
    public static class Vector2Extension
    {
        public static Vector3 ToVector3(this Vector2 vector, float z)
        {
            return new Vector3(vector.x, vector.y, z);
        }
       
        public static Quaternion ToRotation(this Vector2 direction)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            return Quaternion.AngleAxis(angle, Vector3.forward);
        }

        public static float Angle(this Vector2 vector)
        {
            return Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
        }
        public static Vector2 Rotated(this Vector2 v, float degrees)
        {
            return Quaternion.Euler(0, 0, degrees) * v;
        }

        public static Vector2 Orthogonal(this Vector2 vector)
        {
            return new Vector2(-vector.y, vector.x);
        }


        public static float DotProduct(this Vector2 a, Vector2 b)
        {
            return a.x * b.x + a.y * b.y;
        }

        public static Vector2 Cast(this Vector2 target, Vector2 v)
        {
            float distance = target.DotProduct(v);
            return distance * target.normalized;
        }
    }     
}
