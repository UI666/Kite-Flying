using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Kite_Move : MonoBehaviour {

	GameObject kite;
	GameObject Eroop;
	GameObject plane;
	public string secne;
	public AudioClip CrashSound;
	public AudioClip HealSound;

	public Vector2 force;
	
	public Vector3 scale;
	public Vector3 MaxScale;
	public Vector3 MinScale;

	public bool dead;
	bool pause;

	void Start () {
		kite = GameObject.Find ("kite"); 
		Eroop = GameObject.Find ("Eroop");
		plane = GameObject.Find ("Plane");
	}

	void Update () 
	{ 
		if (!pause && !dead) {
			if (Input.GetKey (KeyCode.UpArrow) && Input.GetKey (KeyCode.RightShift)) 				//to decrise the size of kite 
			{
				if(transform.localScale.x>MinScale.x)
				{
					kite.gameObject.transform.localScale -= scale;
				}
			}

			else if (Input.GetKey (KeyCode.UpArrow)) 				
			{
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, force.y));
			}
				
			else if (Input.GetKey (KeyCode.DownArrow) && Input.GetKey (KeyCode.RightShift))
			{
				if(transform.localScale.x<MaxScale.x)
				{
					kite.gameObject.transform.localScale += scale;
					GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, -force.y));
				}
			}

			else if (Input.GetKey (KeyCode.DownArrow))
			{
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, -force.y)); 
			}
					
			else if(Input.GetKey (KeyCode.RightArrow))
			{
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (force.x, 0));
			}
			else if (Input.GetKey (KeyCode.LeftArrow))
			{	
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-force.x, 0));
			}

		} else if (dead) 
		{
			this.GetComponent<Rigidbody2D> ().gravityScale = .1f;
			GetComponent<BoxCollider2D>().isTrigger=true;
			GetComponentInChildren<EdgeCollider2D>().isTrigger=true;
			GetComponent<Rigidbody2D>().freezeRotation=true;

			LoadSceneNow ();
		}


	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if ((col.gameObject.tag == "Enemy_Bird" || col.transform.tag == "Enemy_Kite") ) 
		{ 
			dead = true;
			PlayCrashSound();  

			col.gameObject.GetComponent<BoxCollider2D>().enabled = false;
		}
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.transform.name == "Heal") 
		{
			target.gameObject.SetActive(false); 
			PlayHealSound();
		}
	}

	void PlayHealSound() 
	{
		GameObject go = new GameObject ("Sound");
		AudioSource aSrc = go.AddComponent<AudioSource> ();
		aSrc.clip = HealSound;
		aSrc.volume = 0.7f;
		aSrc.Play ();
		
		Destroy (go, HealSound.length);
		
	}

	void PlayCrashSound() 
	{
		GameObject go = new GameObject ("Sound");
		AudioSource aSrc = go.AddComponent<AudioSource> ();
		aSrc.clip = CrashSound;
		aSrc.volume = 0.7f;
		aSrc.Play ();
		
		Destroy (go, CrashSound.length);
		
	}
	
	void LoadSceneNow() 
	{
		StartCoroutine ("LoadScene");
	}

	IEnumerator LoadScene()
	{
		yield return new WaitForSeconds (5);
		Application.LoadLevel (secne); 

	}

}
