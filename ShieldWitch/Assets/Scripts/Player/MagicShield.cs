using UnityEngine;
using System.Collections;

public class MagicShield : MonoBehaviour {


    private Vector2 velocity;

    public float smoothTimeY;
    public float smoothTimeX;

    private Vector3 startPos;
    private Vector3 playerPos;

    private Transform shield;

    public GameObject player;


    // Use this for initialization
    void Awake ()
    {
        shield = GetComponent<Transform>();

        startPos = shield.position;

        //playerPos = new Vector3(player.transform.position.x + .75f, player.transform.position.y + .5f, 1);

        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update ()
    {

        playerPos = new Vector3(player.transform.position.x + .45f, player.transform.position.y + .45f, 1);
        //allows the Right Joystick to move around the "Shield"
        Vector3 inputDirection = Vector3.zero;
        inputDirection.x = Input.GetAxis("RightJoyHorizontal");
        inputDirection.y = Input.GetAxis("RightJoyVertical");

        //transform.position = new Vector3(player.transform.position.x + .5f, player.transform.position.y + .5f, transform.position.z);
        shield.position = playerPos + inputDirection;
        //shield.position = startPos + inputDirection;


        //float posX = Mathf.SmoothDamp(transform.position.x + .75f, player.transform.position.x + .5f, ref velocity.x, smoothTimeX);
        //float posY = Mathf.SmoothDamp(transform.position.y + .75f, player.transform.position.y + .5f, ref velocity.y, smoothTimeY);

        //transform.position = new Vector3(posX, posY, transform.position.z);

        /* if (Input.GetButtonDown("RightTrigger"))
         {
             //allows the Right Joystick to move around the "Shield"
             Vector3 inputDirection = Vector3.zero;
             inputDirection.x = Input.GetAxis("RightJoyHorizontal");
             inputDirection.y = Input.GetAxis("RightJoyVertical");

             shield.position = startPos + inputDirection;
         } else
         {
             float posX = Mathf.SmoothDamp(transform.position.x + 1, player.transform.position.x + 1, ref velocity.x, smoothTimeX);
             float posY = Mathf.SmoothDamp(transform.position.y + 1, player.transform.position.y + 1, ref velocity.y, smoothTimeY);

             transform.position = new Vector3(posX, posY, transform.position.z);
         } */

    }

    //attempt to get the shield to follow the player.
    /*void FixedUpdate()
    {
        //Using Axis to move Horizontal, should work on controller.
        float move = Input.GetAxis("Horizontal");

        //moves the player left or right based on button press.
        body2D.velocity = new Vector2(move * maxSpeed, body2D.velocity.y);
    } */
}
