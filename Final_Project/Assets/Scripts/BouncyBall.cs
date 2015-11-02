using UnityEngine;
using System.Collections;

public class BouncyBall : MonoBehaviour {
	GameObject ground; 
	Rigidbody rb; 
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> (); 
		ground = GameObject.FindGameObjectWithTag ("ground"); 
	}
	
	// Update is called once per frame
	void Update () {
		var dist = transform.position.y - ground.transform.position.y; 
		var radius = GetComponent<SphereCollider>().radius; 
		float randomForce = Random.Range (10, 175); 

		if (dist <= radius) {
			rb.AddForce (0, randomForce, 0); 
			} 

		if (rb.velocity.y == 0) {
			rb.AddForce(0, 20, 0); 
		}
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.CompareTag("ball")){

			rb.AddExplosionForce(Random.Range(0,5), transform.position, Random.Range (0,10)); 
		}
	}
}
