using UnityEngine;

namespace Math17
{
    public static class QuaternionExtension
    {
        public static Quaternion ToRotation(float x, float y)
        {
            float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
            return Quaternion.AngleAxis(angle, Vector3.forward);
        }

        public static Quaternion ToRotation(Vector2 direction)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            return Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
