using UnityEngine;
using System.Collections;

public class Heal : MonoBehaviour {
	
	public float HorizontalSpeed;
	public float endPos;
	
	Vector2 TempPosition;
	Vector2 initPos;

	void Start () { 
		TempPosition = transform.position;
		initPos = transform.position;
	}
	
	void Update () {
		TempPosition.x += HorizontalSpeed*Time.deltaTime;
		transform.position = TempPosition;
		if (TempPosition.x < 0) 
		{
			if ((-1*TempPosition.x) >= endPos) 
			{
				TempPosition = initPos;
			}
		}
		
		else
		{
			if (TempPosition.x >= endPos) 
			{
				TempPosition = initPos;
			}
		}
	}
}
