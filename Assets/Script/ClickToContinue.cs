using UnityEngine;
using System.Collections;

public class ClickToContinue : MonoBehaviour
{
	public int sceneNo;
	public bool lodLock;
	public AudioClip ClickSound;
	
	void Start () {
	
	}
	
	void Update ()
	{
		if (Input.GetMouseButtonDown (0) && !lodLock) {
			PlaySound(); 
			//LoadScene ();
		}
	}

	public void PlaySound() 
	{
		if (!ClickSound || GameObject.Find ("Sound"))
			return;
		
		GameObject go = new GameObject ("Sound");
		AudioSource aSrc = go.AddComponent<AudioSource> ();
		aSrc.clip = ClickSound;
		aSrc.volume = 0.7f;
		aSrc.Play ();
		
		Destroy (go, ClickSound.length);
	}

	public void LoadScene() 
	{
		lodLock = true;
		Application.LoadLevel (sceneNo);
	}
}
