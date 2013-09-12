using UnityEngine;
using System.Collections;

public class UserInterface : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void CheckKeyInput() { 
		if (Input.GetKeyDown(KeyCode.P)) 
			Time.timeScale = 0; //do we need a pause function?
			//Application.LoadLevel("Pause");
		else 
			Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () { 
		CheckKeyInput();
	}
	
	void OnGUI () {
		//if (GUI.Button (new Rect (25, 25, 100, 30), "Button")) {
			// This code is executed when the Button is clicked}
	}
}
