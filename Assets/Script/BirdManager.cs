using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BirdManager : MonoBehaviour 
{
	public List<GameObject> birds;
	public float rateOfSpawn;
	public float spawnPos;
	
	float nextSpawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		SpawnBird ();
	}
	
	GameObject GetRandom()
	{
		int i = Random.Range (0, birds.Count - 1);
		return birds [i];
	}

	bool isLeft()
	{
		int value = Random.Range (1, 100);
		if (value % 2 != 0)
			return true;
		else
			return false;
	}
	
	void SpawnBird()
	{
		if (Time.time > nextSpawn) 
		{
			nextSpawn = Time.time+ rateOfSpawn;
			if(isLeft())
			{
				GameObject clone = Instantiate (GetRandom (), new Vector3 (-13,Random.Range(1.5f,4f),0), Quaternion.identity) as GameObject;
			}
			else
			{
				GameObject clone = Instantiate (GetRandom (), new Vector3 (13,Random.Range(1.5f,4f),0), Quaternion.identity) as GameObject;
			}
		}
	}
}
