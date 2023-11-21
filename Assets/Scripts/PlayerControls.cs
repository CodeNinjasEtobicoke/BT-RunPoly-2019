using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("DJP")]
    public float jumpPower = 6f;
    [Header("BiG")]
    public bool isGrounded = false;
    float posX = 0.0f;
    Rigidbody2D rb;
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        posX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * (jumpPower * rb.mass * rb.gravityScale * 20.0f));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
