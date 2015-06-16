using UnityEngine;
using System.Collections;

public class butt : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {

		GUI.Button(new Rect(50, 50, 150, 40), "A button");

		GUI.Button(new Rect(250, 50, 150, 40), "Another button");
	}

}