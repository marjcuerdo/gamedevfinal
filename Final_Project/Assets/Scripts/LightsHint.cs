using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class LightsHint : MonoBehaviour {

	
	public Text instructions; 
	public float timePassed; 
	// Use this for initialization
	void Start () {
		instructions.text = "Uh oh. Who turned off the lights?"; 
		timePassed = 0; 
	}
	
	// Update is called once per frame
	void Update () {
		timePassed = Time.fixedTime; 
		//Debug.Log (timePassed); 
		if (timePassed > 5) {
			instructions.text = ""; 
			
		}
		
	}
}
