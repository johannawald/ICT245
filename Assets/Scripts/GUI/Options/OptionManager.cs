using UnityEngine;
using System.Collections;
using System.Xml;

public class OptionManager : MonoBehaviour { //System.IComparable<OptionManager> {  //MonoBehaviour 
	public float SoundLevel = 1.0f;
	public float MusicLevel = 1.0f;
	private string filename = "";
	
	// Use this for initialization
	private void LoadFromXml() {
		XmlDocument xml = new XmlDocument();
		xml.Load(filename);
		XmlNode root = xml.FirstChild;
		XmlNode FirstNode = root.NextSibling;
        foreach(XmlNode node in FirstNode.ChildNodes)
        {
            if (node.Name=="soundlevel") SoundLevel = float.Parse(node.InnerText);
			if (node.Name=="musiclevel") MusicLevel = float.Parse(node.InnerText);
        }
	}
	
	private void SaveToXml() {
    	XmlDocument xml = new XmlDocument();
		xml.Load(filename);
		XmlNode root = xml.FirstChild;
		XmlNode FirstNode = root.NextSibling;
        foreach(XmlNode node in FirstNode.ChildNodes)
        {
            if (node.Name=="soundlevel") node.InnerText = SoundLevel.ToString();		
			if (node.Name=="musiclevel") node.InnerText = MusicLevel.ToString();
        }
        xml.Save(filename);
	}
	
	public void LoadOptions() {
		LoadFromXml();
		SetPlayerPrefs();
	}
	
	public void SaveOptions() {
		SaveToXml();
		SetPlayerPrefs();
	}
	
	void Start () {
		filename = "/Users/nana/RoguePharaoh/Assets/Input/settings.xml";
		LoadOptions();
	}
	
	// Update is called once per frame
	void Update () {
		//Options
	}
	
	void SetPlayerPrefs() {
		PlayerPrefs.SetFloat("soundlevel", SoundLevel);
		PlayerPrefs.SetFloat("musiclevel", MusicLevel);
	}
	
}
