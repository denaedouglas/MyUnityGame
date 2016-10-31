using UnityEngine;
using System.Collections;

public class charEight : MonoBehaviour {
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public float speed;
    public bool grounded;
    public float jumpHeight;
    public float moveVelocity;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            sr.flipX = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            sr.flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {

            rb.velocity = new Vector2(moveVelocity, jumpHeight);
            //After your character jumps grounded has to change to false since the 
            //character is not on the ground anymore
            grounded = false;

        }

        // If your character is not falling nor jumping then change grounded true
        //Since he has landed.
        if (rb.velocity.y == 0)
        {
            grounded = true;
        }
    }
}
