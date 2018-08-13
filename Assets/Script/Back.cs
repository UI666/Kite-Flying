using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {

	public bool lodLock;
	public string scene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && !lodLock) {
			LoadScene();
		}
	}

	public void LoadScene() 
	{
		lodLock = true;
		Application.LoadLevel (scene);
	}
}
