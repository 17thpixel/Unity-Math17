using System.Collections.Generic;
using UnityEngine;


namespace Math17
{
    public class Rand17
    {
        /// <summary>
        /// Returns random sign with 50% chance each. 
        /// </summary>
        /// <returns>
        /// -1 or 1
        /// </returns>
        public static int RandomSign()
        {
            if (Random.value < 0.5f)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Random direction on xy plane.
        /// </summary>
        /// <returns>
        /// Normalized Vector2 of the diraction.
        /// </returns>
        public static Vector2 Direction()
        {
            float angle = Random.Range(0, 2 * Mathf.PI);
            return new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        }

        /// <summary>
        /// Random direction in given cone. Where baseDirection is cone center and maxAngle 
        /// is allowed deviation.
        /// </summary>
        /// <param name="baseDirection">
        /// Center of the cone.
        /// </param>
        /// <param name="maxAngle">
        /// Max deviation from center.
        /// </param>
        /// <returns></returns>
        public static Vector2 Direction(Vector2 baseDirection, float maxAngle)
        {
            float baseAngle = baseDirection.Angle();
            float angle = Random.Range(baseAngle - maxAngle, baseAngle + maxAngle);
            return new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        }

        /// <summary>
        /// Random item from array. Function doesn't remove picked item from array.
        /// </summary>        
        public static T Item<T>(T[] items)
        {
            int index = Random.Range(0, items.Length);
            return items[index];
        }

        /// <summary>
        /// Random item from a list. Function removes picked item form list.
        /// </summary>        
        public static T PickAndRemove<T>(List<T> items)
        {
            int index = Random.Range(0, items.Count - 1);
            T item = items[index];
            items.Remove(item);
            return item;
        }
    }
}
