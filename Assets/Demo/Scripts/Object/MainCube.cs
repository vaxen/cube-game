﻿using System;
using Demo.Scripts.Base;
using Demo.Scripts.Utils;
using UnityEngine;

public class MainCube : MonoBehaviour
{
    private IMovement movement;
    private IBoundary boundary;
    private Rigidbody2D _rigidbody;
    
    //TODO GR: Refactor with Zenject lib in order to manage dependency
    private void Awake()
    {
        this.movement = new CubeMovement();
        this.boundary = new CubeBoundary();
    }
    private void Start()
    {
        this._rigidbody = gameObject.GetComponent<Rigidbody2D>();
        this.boundary.SetBounds(Camera.main, transform.GetComponent<SpriteRenderer>().bounds);
    }
    private void Update()
    {
        this.movement.SetDirection(Input.GetAxisRaw(Constants.Directions.Horizontal.ToString()), 
            Input.GetAxisRaw(Constants.Directions.Vertical.ToString()));
    }
    public void FixedUpdate()
    {
        this.movement.Move(this._rigidbody);
    }
    public void LateUpdate()
    {
        this.transform.position = this.boundary.CalculateBounds(this.transform.position);
    }
}
