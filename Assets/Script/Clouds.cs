using UnityEngine;
using System.Collections;

public class Clouds : MonoBehaviour {

	//public float HorizontalSpeed;
	public float VerticalSpeed;
	public float endPos;

	Vector2 TempPosition;
	Vector2 initPos;
	
	void Start () {
		TempPosition = transform.position;
		initPos = transform.position;
	}

	void Update () {
		TempPosition.y += VerticalSpeed* Time.deltaTime;
		transform.position = TempPosition;

		if (TempPosition.y >= endPos) 
		{
			TempPosition = initPos;
		}
	
	}


}
