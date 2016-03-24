using UnityEngine;
using System.Collections;

public class PulseGenerator : MonoBehaviour {
	private Rigidbody2D body2D;
	public int paceDirection = 1;
	public float attackDelay = 3f;
	public GameObject pulse;
	public GameObject player;
	//public int delay = 2.0;
	// Use this for initialization
	void Start () {

	}

	void Awake(){
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire2"))
		{
			Debug.Log ("Fire2 pressed, instantiate pulse");
			GameObject pulseClone = Instantiate (pulse, transform.position, transform.rotation) as GameObject;
			Object.Destroy(pulseClone, .5f);

		}
	}
}
