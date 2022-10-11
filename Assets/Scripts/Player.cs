using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpHeight;
    Rigidbody2D rb;
    public LayerMask groundLayerMask;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")&&IsGrounded())
        {
            rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
        }
    }

    //Checks to see if the player is on the ground by raycasting downwards from the player's position
    private bool IsGrounded()
    {
        RaycastHit2D onGround = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.down), 1f, groundLayerMask);

        if (onGround)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            Debug.Log("Ouchies");
        }
    }
}
