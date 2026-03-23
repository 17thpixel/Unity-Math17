using UnityEngine;

namespace Math17
{
    public static class GameObjectExtension
    {
        /// <summary>
        /// Computes distance 2D on XY plane between two game objects based in its transforms.
        /// </summary>        
        /// <returns>Distance as float</returns>
        public static float Distance2D(this GameObject a, GameObject b)
        {
            return a.transform.position.Distance2D(b.transform.position);
        }

        /// <summary>
        /// Computes distance 2D on XY plane between game object and custom position.
        /// </summary>        
        /// <returns>Distance as float</returns>
        public static float Distance2D(this GameObject o, Vector2 v)
        {
            return o.transform.position.Distance2D(v);
        }
    }
}
