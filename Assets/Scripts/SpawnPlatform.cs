using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
	public GameObject platform;
	public GameObject diamonds;
	//public GameObject block;
	
	Vector3 lastpos;
	float size;

	int score;

	public bool gameOver;

    void Start()
    {
		score = PlayerPrefs.GetInt("score");

		lastpos = platform.transform.position;
		size = platform.transform.localScale.x;    
    
	for (int i = 0; i<20;i++)
	{
		SpawnPlatforms (); 
	}
	
	InvokeRepeating ("SpawnPlatforms",4f,0.2f);
	}

    // Update is called once per frame
    void Update()
    {
		if (gameOver) {
			CancelInvoke("SpawnPlatforms"); 
		} 
    }
	
	void SpawnPlatforms(){
		
		int rand = UnityEngine.Random.Range(0,8);
		if (rand < 4){
			SpawnX();
		}
		else if (rand>=4){
			SpawnZ();
		}
	}
	
	void SpawnX(){
	
		Vector3 pos = lastpos;
		pos.x += size;
		lastpos = pos;
		Instantiate(platform, pos, Quaternion.identity);
		
		int rand = UnityEngine.Random.Range(0,10);
		if (rand <= 2)
		{
			Instantiate(diamonds, new Vector3(pos.x, pos.y + 1.5f, pos.z), diamonds.transform.rotation);
		}	
	}
	
	void SpawnZ() {
		
		Vector3 pos = lastpos;
		pos.z += size;
		lastpos = pos;
		Instantiate(platform, pos, Quaternion.identity);
		
		int rand = UnityEngine.Random.Range(0,10);
		if(rand >=8)
		{
			Instantiate(diamonds,new Vector3(pos.x,pos.y + 1.5f,pos.z),diamonds.transform.rotation);
		}
		
	}
}

