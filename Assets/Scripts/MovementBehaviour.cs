using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{

    [SerializeField]
    private float jumpForce;
    [SerializeField]
    float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    public void Move2D(Vector3 dir)
    {
        dir.Normalize();
        transform.position += dir * speed* Time.deltaTime;
    }

    public void MoveRB2D(Vector2 dir)
    {
        rb.velocity = new Vector2(dir.x * speed, dir.y);
    }

    public void MoveRB2D(Vector2 dir, Boolean sprint)
    {
        rb.velocity = new Vector2(dir.x * speed, dir.y);
    }

    public void Jump()
    {
        rb.velocity = new Vector2(0,0);
        rb.gravityScale *= -1;
    }
}
