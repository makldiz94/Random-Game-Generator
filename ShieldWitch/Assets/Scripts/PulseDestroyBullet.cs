
using UnityEngine;
using System.Collections;

public class PulseDestroyBullet : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		//if an enemy bullet touches shield bullet destroys
		if(col.gameObject.tag == "Deadly")
		{
			Debug.Log ("Collided with shield pulse");
			Destroy(col.gameObject);
		}
	}
}
