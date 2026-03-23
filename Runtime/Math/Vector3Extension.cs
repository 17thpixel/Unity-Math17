using UnityEngine;

namespace Math17
{
    public static class Vector3Extension
    {
        /// <summary>
        /// Creates new Vector2(x, y).
        /// </summary>                
        public static Vector2 xy(this Vector3 vector3)
        {
            return new Vector2(vector3.x, vector3.y);
        }


        /// <summary>
        /// Creates new Vector3 with new z value.
        /// </summary>
        /// <param name="zValue">
        /// New value of z.
        /// </param>
        public static Vector3 z(this Vector3 vector3, float zValue)
        {
            return new Vector3(vector3.x, vector3.y, zValue);
        }


        /// <summary>
        /// Computes 2d distance in xy plane, omites z. Usefull when computing distance in 2d from Camera.
        /// Camera often have z value set to -10, which is not important for 2d distance computation.        
        /// </summary>        
        /// <returns>
        /// Distance as float.
        /// </returns>
        public static float Distance2D(this Vector3 a, Vector3 b)
        {
            float dx = a.x - b.x;
            float dy = a.y - b.y;
            return Mathf.Sqrt(dx * dx + dy * dy);
        }
    }
}
