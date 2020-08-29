﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCube : MonoBehaviour
{
    public float Speed = 5f;
    public Rigidbody2D Rb;
    private Vector2 movement;

    private void Update()
    {
        this.movement.x = Input.GetAxisRaw("Horizontal");
        this.movement.y = Input.GetAxisRaw("Vertical");
    }

    public void FixedUpdate()
    {
        this.Rb.MovePosition(this.Rb.position + this.movement * (this.Speed * Time.fixedDeltaTime));
    }
}
