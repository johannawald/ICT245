using UnityEngine;
using System.Collections;
using System.IO;

//go back to the main menu automatically

public class Credits : MonoBehaviour {
	protected FileInfo theSourceFile = null;
	protected StreamReader reader = null;
	
	int time = 0;
	string filename = "Assets/Input/credits.txt";
	string creds = "CREDITS - Read from file";
	
	void Start () {
	    time = 0;
		theSourceFile = new FileInfo(filename);
		reader = theSourceFile.OpenText();
		
		string line = "";
        do {
            line = reader.ReadLine();
            creds = creds + "\r\n" + line;
        } while (line != null);
	}

	// Update is called once per frame
	void Update () {
		time = time + 1;
	}
	
	void OnGUI () {
		const int width = 200;
		//height of the label
		const int height = 500;
		//GUISkin.settings = TextAlignment.center;
		
		GUI.Label(new Rect((Screen.width/2)-width, 400 - time, width, height), creds);
		if (time>700) //long enough?
 			Application.LoadLevel("MainMenu"); //Load previous level
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		int BtnWidth = 25;
		if(GUI.Button(new Rect(0, Screen.height - BtnWidth, 130, BtnWidth), "<< Main Menue")) { //we don't need that later
			Application.LoadLevel("MainMenu"); 
		}
	}
}
