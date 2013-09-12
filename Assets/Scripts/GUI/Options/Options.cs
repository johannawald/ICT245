using UnityEngine;
using System.Collections;
using System.Xml;

/* -------------------------

 - Unlock all items.
 - Disable enemies.
 - Disable GUI.
 - Make player invincible.
 - Disable all gameplay.
 
 Settings the user can change:
 - Sound-Level
 - Music-Level
 
------------------------- */

public class Options : MonoBehaviour {	
	private bool OptionsChanged = false;
	private OptionManager optionmanager;	
	private string BackBtnCaption = "";
	
	void Start () {
		optionmanager = GetComponent<OptionManager>();
		OptionsChanged = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void setSoundControl() {
		gameObject.audio.volume = optionmanager.MusicLevel;
	}
	
	void OnGUI () {
		setSoundControl();
		
		BackBtnCaption = "<< Main Menue";
		int BtnWidth = 130;
		int BtnHeight = 25;
		
		GUI.Label(new Rect (25, 25, 100, 30), "Options");
		GUI.Label(new Rect (25, 95, 100, 30), "Sound");
		optionmanager.SoundLevel = GUI.HorizontalScrollbar (new Rect (100, 100, 100, 30), optionmanager.SoundLevel, 0.01f, 0.0f, 1.0f);
		GUI.Label(new Rect (25, 125, 100, 30), "Music");
		optionmanager.MusicLevel = GUI.HorizontalScrollbar (new Rect (100, 130, 100, 30), optionmanager.MusicLevel, 0.01f, 0.0f, 1.0f);
		
		if (GUI.changed) 
			OptionsChanged = true;
		
		if (OptionsChanged) {
			BackBtnCaption = "<< Discard";
			if (GUI.Button(new Rect(BtnWidth+5, Screen.height - 25, 70, 25), "Apply")) {
				optionmanager.SaveOptions();
				OptionsChanged = false;
			}
		}
				
		if (GUI.Button(new Rect(0, Screen.height - BtnHeight, BtnWidth, BtnHeight), BackBtnCaption)) {			
			Application.LoadLevel("MainMenu"); 
		}
	}
}

//toggleBool = GUI.Toggle (new Rect (100, 65, 130, 30), toggleBool, "Toggle");	
