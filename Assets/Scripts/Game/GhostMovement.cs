using UnityEngine;
using System.Collections;

public class GhostMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 direction = new Vector3(0.06f, 0, 0);
		transform.Translate(direction);
	}
}
