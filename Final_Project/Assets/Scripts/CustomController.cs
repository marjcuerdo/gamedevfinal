using UnityEngine;
using System.Collections;

public class CustomController : MonoBehaviour {
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb =   GetComponent<Rigidbody> (); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		/*
		 * Not sure if this is really working. If you get something to work well, 
		 * please tell! 
		 */
		if(other.gameObject.CompareTag("wall")){
			rb.AddForce(transform.position); 
		}
	}
}
