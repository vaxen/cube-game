using System;
using Demo.Scripts.Base;
using Demo.Scripts.Utils;
using UnityEngine;
using Random = System.Random;

public class EnemyCube : MonoBehaviour
{
    private IMovement movement;
    private IBoundary boundary;
    private Rigidbody2D _rigidbody;
    private float timer;
    
    //TODO GR: Refactor with Zenject lib in order to manage dependency
    private void Awake()
    {
        this.movement = new CubeMovement(Constants.ENEMY_SPEED);
        this.boundary = new CubeBoundary();
    }
    private void Start()
    {
        this._rigidbody = gameObject.GetComponent<Rigidbody2D>();
        this.boundary.SetBounds(Camera.main, transform.GetComponent<SpriteRenderer>().bounds);
    }
    private void Update()
    {
        this.timer -= Time.deltaTime;
        if (this.timer > 0f)
            return;

        this.timer = 1f;
        this.movement.SetDirection(Util.NextFloat() > 0.5f ? 1f : -1f, Util.NextFloat() > 0.5f ? 1f : -1f);
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
