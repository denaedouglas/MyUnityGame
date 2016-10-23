using UnityEngine;
using System.Collections;

public class Pixel : MonoBehaviour {
    public Rigidbody2D rb;
    public float speed;
    public bool grounded;
    public float jumpHeight;
    public float moveVelocity;
    public string message = "You died.";
    public float displayTime;
    public bool displayMessage = false;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
      }

    //check for collision between enemy and player
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("inside the func2");
        if (collision.gameObject.tag == "Enemy")
        {
            displayMessage = true;
            displayTime = 3;
            Destroy(collision.gameObject);
        }
    }

    void OnGUI()
    {
        if (displayMessage)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200f, 200f), message);
        }
    }

        // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        //if you press the space bar, pixel object jumps
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

        //count down for how long message is on the screen
        displayTime -= Time.deltaTime;
        if (displayTime <= 0.0)
        {
            displayMessage = false;
        }
    }

}
