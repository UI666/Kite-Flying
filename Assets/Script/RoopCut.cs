using UnityEngine;
using System.Collections;

public class RoopCut : MonoBehaviour {
	bool coled;
	GameObject enemy;
	Transform kite_enemy;
	public AudioClip CrashSound;

	bool dead;
	void Start () 
	{
	
	}

	void Update () 
	{
		if (coled == true) 
		{
			if(Input.GetKey(KeyCode.C) && Input.GetKey(KeyCode.DownArrow))
			{
				//enemy.SetActive(false);
				kite_enemy= enemy.transform.parent;
				kite_enemy.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1f; 
				kite_enemy.gameObject.GetComponent<Rigidbody2D>().isKinematic=false;
				kite_enemy.gameObject.GetComponent<Enemy_Kite>().enabled=false;
				PlaySound();
				//("Dead");
			}

		}
	}

	void PlaySound() 
	{
		GameObject go = new GameObject ("Sound");
		AudioSource aSrc = go.AddComponent<AudioSource> ();
		aSrc.clip = CrashSound;
		aSrc.volume = 0.3f;
		aSrc.Play ();
		
		Destroy (go, CrashSound.length);
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		//print(col.gameObject.tag);
		if (col.gameObject.tag=="Eroop") 
		{

			//if (Input.GetKey (KeyCode.LeftControl) || Input.GetKey (KeyCode.C)) 
			coled=true;
			enemy = col.gameObject;
		}
	}

}
