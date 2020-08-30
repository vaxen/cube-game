using UnityEngine;

namespace Demo.Scripts.Base
{
    public interface IMovement
    {
        float Speed { get; set; }
        Vector2 Vector { get; set; }
        void SetDirection(float x, float y);
        void Move(Rigidbody2D rigidBody);
    }
}