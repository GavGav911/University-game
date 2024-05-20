using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private Vector2 moveVector;
    private bool facingRight = true;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + moveVector * (speed * Time.deltaTime));
        if (Input.GetAxis("Horizontal") > 0 && !facingRight)
        {
            Flip();
        }
        if (Input.GetAxis("Horizontal") < 0 && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }

}
