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
	public bool isWon; 
	// Use this for initialization
	void Start () {
		instructions.text = "Can you get the ball to the door?"; 
		timePassed = 0; 
		isWon = false; 
	}
	
	// Update is called once per frame
	void Update () {
		timePassed = Time.fixedTime; 
		//Debug.Log (timePassed); 
		if (timePassed > 5 & isWon == false) {
			instructions.text = "Try running up to the ball"; 

		}

		if (timePassed > 30 & isWon == false) {
			instructions.text = ("Remember, you can always press 'R' if you get stuck."); 
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("door")) {
			instructions.text = ("You won! Press 'R' to try again or return to the Main Menu"); 
			isWon = true; 
		}
	}
}
