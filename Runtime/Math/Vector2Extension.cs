using UnityEngine;

namespace Math17
{   
    public static class Vector2Extension
    {
        /// <summary>
        /// Creates Vector3 from Vector2 with specified z value.
        /// </summary>
        /// <example>
        /// <code>
        /// camera.transform.position = (enemy + delta).ToVector3(-10);
        /// </code>
        /// </example>
        public static Vector3 ToVector3(this Vector2 vector, float z)
        {
            return new Vector3(vector.x, vector.y, z);
        }


        /// <summary>
        /// Extracts an angle from Vector2 XY space, and creates Quaternion reporesting this rotation.
        /// </summary>
        /// <param name="direction">
        /// Vector2 represting the rotation.
        /// </param>
        /// <returns>
        /// Quatarnion equvialent of the rotation.
        /// </returns>
        public static Quaternion ToRotation(this Vector2 direction)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            return Quaternion.AngleAxis(angle, Vector3.forward);
        }

        /// <summary>
        /// Extracts the angle in degres of Vector2 in XY space.
        /// </summary>
        /// <param name="vector">
        /// Non zero vector.
        /// </param>
        /// <returns>
        /// Float represting the angle in degres.
        /// </returns>
        public static float Angle(this Vector2 vector)
        {
            return Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
        }

        /// <summary>
        /// Rotates Vector2 around z-axis counter clock wise.
        /// </summary>
        /// <param name="v">
        /// Vector2 to be rotated.
        /// </param>
        /// <param name="degrees">
        /// Rotation in degrees. 
        /// </param>
        /// <returns></returns>
        public static Vector2 Rotated(this Vector2 v, float degrees)
        {
            return Quaternion.Euler(0, 0, degrees) * v;
        }

        /// <summary>
        /// Creates ortogonal Vector2 to current one.
        /// </summary>        
        /// <returns>
        /// Vector2 that is orotognal in XY space.
        /// </returns>
        public static Vector2 Orthogonal(this Vector2 vector)
        {
            return new Vector2(-vector.y, vector.x);
        }


        /// <summary>
        /// Calculates dot product between two 2d vectors.
        /// </summary>        
        /// <returns>
        /// Float represting dot product.
        /// </returns>
        public static float DotProduct(this Vector2 a, Vector2 b)
        {
            return a.x * b.x + a.y * b.y;            
        }


        /// <summary>
        /// Casts vector v on to target(current) vector2.
        /// </summary>
        /// <param name="target">
        /// Target vector.
        /// </param>
        /// <param name="v">
        /// Vector that will be casted.
        /// </param>
        /// <returns>
        /// Vector parallel to target that represents the cast. 
        /// </returns>
        public static Vector2 Cast(this Vector2 target, Vector2 v)
        {
            float distance = target.DotProduct(v);
            return distance * target.normalized;
        }
    }     
}
