using UnityEngine;

namespace Demo.Scripts.Base
{
    public class CubeBoundary : IBoundary
    {
        public Vector2 ScreenBounds { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public void SetBounds(Camera camera, Bounds bounds)
        {
            this.ScreenBounds = camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, camera.transform.position.z));
            this.Width = bounds.extents.x;
            this.Height = bounds.extents.y;
        }
        public Vector3 CalculateBounds(Vector3 position)
        {
            var viewPos = position;
            viewPos.x = Mathf.Clamp(viewPos.x, this.ScreenBounds.x * -1 + this.Width, this.ScreenBounds.x - this.Width);
            viewPos.y = Mathf.Clamp(viewPos.y, this.ScreenBounds.y * -1 + this.Height, this.ScreenBounds.y - this.Height);
            return viewPos;
        }
    }
}