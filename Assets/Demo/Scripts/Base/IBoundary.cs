using UnityEngine;

namespace Demo.Scripts.Base
{
    public interface IBoundary
    {
        Vector2 ScreenBounds { get; set; }
        float Width { get; set; }
        float Height { get; set; }

        void SetBounds(Camera camera, Bounds bounds);
        Vector3 CalculateBounds(Vector3 position);
    }
}