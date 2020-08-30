using Demo.Scripts.Utils;
using UnityEngine;

namespace Demo.Scripts.Base
{
    public class CubeMovement : IMovement
    {
        public float Speed { get; set; }
        public Vector2 Vector { get; set; }
        public void SetDirection(float x, float y)
        {
            this.Vector = new Vector2(x, y);
        }
        public void Move(Rigidbody2D rigidBody)
        {
            rigidBody.MovePosition(rigidBody.position + this.Vector * (this.Speed * Time.fixedDeltaTime));
        }

        public CubeMovement(float speed = Constants.BASE_SPEED)
        {
            this.Speed = speed;
        }
    }
}