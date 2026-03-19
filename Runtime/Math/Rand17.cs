using System.Collections.Generic;
using UnityEngine;


namespace Math17
{
    public class Rand17
    {
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

        public static Vector2 Direction()
        {
            float angle = Random.Range(0, 2 * Mathf.PI);
            return new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        }

        public static Vector2 Direction(Vector2 baseDirection, float maxAngle)
        {
            float baseAngle = baseDirection.Angle();
            float angle = Random.Range(baseAngle - maxAngle, baseAngle + maxAngle);
            return new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        }

        public static T Item<T>(T[] items)
        {
            int index = Random.Range(0, items.Length);
            return items[index];
        }

        public static T PickAndRemove<T>(List<T> items)
        {
            int index = Random.Range(0, items.Count - 1);
            T item = items[index];
            items.Remove(item);
            return item;
        }
    }
}
