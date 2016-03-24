using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	private Rigidbody2D body2D;
	public int paceDirection = 1;
    public float speed = -10f;
	// Use this for initialization
	void Start () {
	
	}

	void Awake(){
		body2D = GetComponent<Rigidbody2D> ();
	}
	// Update is called once per frame
	void Update () {
        body2D.velocity = new Vector2(speed, 0);
		//body2D.AddForce (transform.right * speed * paceDirection);
		//this.GetComponent<Rigidbody>().AddForce (this.transform.forward * 1000);
	}

	void OnCollisionEnter2D(Collision2D target){
		Destroy (gameObject);
	
	}

    void OnTriggerStay2D(Collider2D col)
    {
        //Destroy(gameObject);
        if(col.gameObject.tag == "MagicShield")
        {
            //Destroy(gameObject);
            //body2D.AddForce(transform.right * -.00005f * paceDirection);
            speed = -.1f;
        }
    }

    void OnTriggerExit2D (Collider2D col)
    {
        if(col.gameObject.tag == "MagicShield")
        {
            speed = -10f;
        }
    }
}
