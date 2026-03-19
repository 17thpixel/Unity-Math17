using UnityEngine;

namespace Math17
{
    public static class GameObjectExtension
    {
        public static float Distance2D(this GameObject a, GameObject b)
        {
            return a.transform.position.Distance2D(b.transform.position);
        }

        public static float Distance2D(this GameObject o, Vector2 v)
        {
            return o.transform.position.Distance2D(v);
        }
    }
}
