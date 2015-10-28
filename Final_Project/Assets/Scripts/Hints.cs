using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Hints : MonoBehaviour {
	/*
	 * This is specifically for tutorial level, but the 
	 * general code can be used for other levels. 
	 * 
	 * */

	public Text instructions; 
	public float timePassed; 
	// Use this for initialization
	void Start () {
		instructions.text = "Can you get the ball to the door?"; 
		timePassed = 0; 
	}
	
	// Update is called once per frame
	void Update () {
		timePassed = Time.fixedTime; 
		//Debug.Log (timePassed); 
		if (timePassed > 5) {
			instructions.text = "Try running up to the ball"; 

		}

		if (timePassed > 30) {
			instructions.text = ("Remember, you can always press 'R' if you get stuck."); 
		}
	}
}
