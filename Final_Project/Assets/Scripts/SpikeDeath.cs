using UnityEngine;
using System.Collections;

public class SpikeDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerCollider (Collider other){
		if(other.gameObject.CompareTag("Death")){
			Application.LoadLevel(Application.loadedLevel); 
		}
	}
}
