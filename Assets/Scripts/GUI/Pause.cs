using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	void OnGUI () {
		if(GUI.Button(new Rect(200,40,80,20), "Continue")) {
			Application.LoadLevel("Game"); 
		}
		else if(GUI.Button(new Rect(200,80,80,20), "Options")) { //the same or other options?
			Application.LoadLevel("Options"); 
		}
	}
}
