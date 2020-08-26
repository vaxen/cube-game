using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidBody;
    private Vector3 change;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        //Debug.Log(change);s
        if (change != Vector3.zero) { MoveCharacter(); }

    }

    void MoveCharacter()
    {
        // position of the player + change * speed in secondss
        myRigidBody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
}
