using UnityEngine;
using System.Collections;

public class Clouds_Reflection : MonoBehaviour {
	
	public float HorizontalSpeed;
	public float VerticalSpeed;
	public float amplitude;
	
	public Vector2 TempPosition;

	// Use this for initialization
	void Start () {
		TempPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		TempPosition.x += HorizontalSpeed;
		TempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * VerticalSpeed) * amplitude;
		transform.position = TempPosition;
		
		if (TempPosition.x >= 2.5f)
			TempPosition = transform.position;
	}
}
