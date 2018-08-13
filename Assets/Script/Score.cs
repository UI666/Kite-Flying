using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public static int score = 0;
	Text scoreText;
	// Use this for initialization
	void Start ()
	{
		scoreText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		scoreText.text = "Score: " + score.ToString ();
		//GetComponent<TextMesh>().text = "Score: " + score.ToString();
	}
}
