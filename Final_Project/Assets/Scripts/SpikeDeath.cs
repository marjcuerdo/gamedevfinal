using UnityEngine;
using System.Collections;

public class SpikeDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag =="Death"){
			Application.LoadLevel(Application.loadedLevel); 
			Debug.Log("Restarted"); 
		}
	}
}
