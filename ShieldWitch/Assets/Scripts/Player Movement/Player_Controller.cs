using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour {

    public float maxSpeed = 10f;
    public float jumpForce = 300f;
    private bool facingRight = true;

    private Rigidbody2D body2D;

    private bool grounded = false;
    public Transform groundCheck;
    private float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    void Awake()
    {
        body2D = GetComponent<Rigidbody2D>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //uses the groundcheck transform to find whether we are ON THE GROUND. Returns true or false.
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        //Using Axis to move Horizontal, should work on controller.
        float move = Input.GetAxis("Horizontal");

        //moves the player left or right based on button press.
        body2D.velocity = new Vector2(move * maxSpeed, body2D.velocity.y);

        if(move > 0 && !facingRight)
        {
            Flip();
        }
        else if (move < 0 && facingRight)
        {
            Flip();
        }
	}

    void Update()
    {
        //Currently Jump is just the space button for testing purposes, we will change this!
        if(grounded && Input.GetKeyDown(KeyCode.Space))
        {
            body2D.AddForce(new Vector2(0, jumpForce));
        }
    }

    void Flip()
    {
        //acquires local scale and flipping it to make the character face properly.
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

   /* void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Killbox")
        {
            Debug.Log("You should be dead");
            Destroy(this.gameObject);
        }
    } */

}
