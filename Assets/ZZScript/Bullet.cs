using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter(Collision c)
	{
		Health health = c.gameObject.GetComponent<Health> ();

		if (health != null) {
			health.TakeDamage(10);
		}

		Destroy (gameObject);
	} 
}
