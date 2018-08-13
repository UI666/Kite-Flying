using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	public bool lodLock;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && !lodLock) {
			Application.Quit();
		}

		//if (Input.GetKey (KeyCode.Escape))
			//Application.Quit ();
	}
}
