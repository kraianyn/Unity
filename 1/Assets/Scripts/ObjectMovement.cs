using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * 4;
        float y = Input.GetButtonDown("Jump") ? 6 : rigidBody.velocity.y;
        rigidBody.velocity = new Vector2(x, y);
    }
}
