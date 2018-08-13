using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {
	
	public float time;
	int minutes;
	int seconds;
	int fraction;
	public int SaveTime;
	
	Text text;

	bool dead;
	// Use this for initialization
	void Start () 
	{
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (GameObject.Find ("kite").GetComponent<Kite_Move> ().dead) 
		{
			dead = true;
		}
		if (!dead) {
			time += Time.deltaTime;
			minutes = (int)time / 60;
			seconds = (int)time % 60;
			fraction = (int)(time * 100) % 100;
			//GetComponent<TextMesh> ().text = string.Format ("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);
			//SaveTime = string.Format ("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);
			SaveTime = seconds;
			text.text = string.Format ("{0:00}", seconds);
		} 
		else 
		{
			Score.score = SaveTime;
		}


	}
}
