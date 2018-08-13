using UnityEngine;
using System.Collections;

public class Bird_Move : MonoBehaviour {
	public float HorizontalSpeed;
	public float endPos;
	
	public Vector2 TempPosition;
	public Vector2 initPos;

	public bool FlagX;
	//public GameObject bird;

	void Start () {

		TempPosition = transform.position;
		transform.position = initPos;

	}

	void Update ()
	{
		BirdMove ();
//		TempPosition.x += (HorizontalSpeed * Time.deltaTime);
//		transform.position = TempPosition;
//		if (TempPosition.x < 0) 
//		{
//			if ((-1*TempPosition.x) >= endPos) 
//			{
//				TempPosition = initPos;
//			}
//		}
//		
//		else
//		{
//			if (TempPosition.x >= endPos) 
//			{
//				TempPosition = initPos;
//			}
//		}
	}
	
	void BirdMove()
	{
		TempPosition.x += HorizontalSpeed * Time.deltaTime;
		transform.position = TempPosition;

		if (TempPosition.x < 0) {
			FlagX = false;
		}
		else 
		{
			FlagX = true;
		}

		if(!FlagX)
		{
			if((TempPosition.x) >= endPos)
			{
				TempPosition = initPos;
			}
		}

		else
		{
			if(TempPosition.x <= endPos)
			{
				TempPosition = initPos;
			}
		}
	}
}
