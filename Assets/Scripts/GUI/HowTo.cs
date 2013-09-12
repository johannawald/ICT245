using UnityEngine;
using System.Collections;

public class HowTo : MonoBehaviour {
	
	Texture2D img;
	
	// Use this for initialization
	void Start () {
		//load texture
		img = Resources.Load("HowTo") as Texture2D;
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnGUI() {
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height), img);
		
		int BtnWidth = 25;
		if(GUI.Button(new Rect(0, Screen.height - BtnWidth, 130, BtnWidth), "<< Main Menue")) {
			Application.LoadLevel("MainMenu"); 
		}
		
	}
}
