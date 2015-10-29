using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void Controls(){
		Application.LoadLevel ("Controls"); 
	}

	public void Play(){
		Application.LoadLevel (1); 
	}

	public void Tutorial(){
		Application.LoadLevel ("TutorialScene"); 
	}
}
