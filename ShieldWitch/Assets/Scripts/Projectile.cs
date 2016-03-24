using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	private Rigidbody2D body2D;
	public int paceDirection = 1;
	// Use this for initialization
	void Start () {
	
	}

	void Awake(){
		body2D = GetComponent<Rigidbody2D> ();
	}
	// Update is called once per frame
	void Update () {
		body2D.AddForce (transform.right * -10 * paceDirection);
		//this.GetComponent<Rigidbody>().AddForce (this.transform.forward * 1000);
	}

	void OnCollisionEnter2D(Collision2D target){
		Destroy (gameObject);
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(gameObject);
    }
}
