using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//print(PlayerPrefs.GetFloat("musiclevel")); - init the first time! 
	}
	
	public Texture2D icon;
	
	void OnGUI () {
		
		if(GUI.Button(new Rect(200,40,80,20), "New Game")) {
			Application.LoadLevel("Game"); 
		}
		else if(GUI.Button(new Rect(200,80,80,20), new GUIContent ("Load Game", "doesn't work yet"))) {
			Application.LoadLevel("Game"); 			
		}		
		else if(GUI.Button(new Rect(200,120,80,20), "Credits")) {
			Application.LoadLevel("Credits"); 
		}
		else if(GUI.Button(new Rect(200,160,80,20), "Options")) {
			Application.LoadLevel("Options"); 
		}
		else if(GUI.Button(new Rect(200,200,80,20), "HowTo")) {
			Application.LoadLevel("HowTo"); 
		}
		else if(GUI.Button(new Rect(200,240,80,20), "Exit")) {
			Application.Quit();
		}
	}
}
