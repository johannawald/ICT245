using UnityEngine;
using System.Collections;

public class SetSettings : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { 
		//All the backgroundaudio should be attached to the main camera - this script has to be attached to it (otherwise sound effects will be as loud as the music)
		gameObject.audio.volume = PlayerPrefs.GetFloat("musiclevel");
	}
}
