using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


public class EnemyMove : MonoBehaviour
{
    private static string VERTICAL = "Vertical";
    private static string HORIZONTAL = "Horizontal";
    
    public float speed;
    public string movementType;
    [FormerlySerializedAs("SwitchMovement")] public bool switchMovement;
    void Update()
    {
        if (HORIZONTAL.Equals((movementType)))
        {
            moveHorizontal();
        }
        else if (VERTICAL.Equals((movementType)))
        {
           moveVertical();
        }
       
    }

    void moveHorizontal()
    {
        if (!switchMovement)
        {
            //move right
            transform.Translate(2 * Time.deltaTime * speed, 0,0);
        }
        else
        {
            //move left
            transform.Translate(-2 * Time.deltaTime * speed, 0,0);
        }

    }

    void moveVertical()
    {
        if (!switchMovement)
        {
            //move down
            transform.Translate(0, -2 * Time.deltaTime * speed,0);
        }
        else
        {
            //move up
            transform.Translate(0, 2 * Time.deltaTime * speed,0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        switchMovement = !switchMovement;
    }
}
