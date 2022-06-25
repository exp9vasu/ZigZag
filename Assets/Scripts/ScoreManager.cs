using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{	

	public static ScoreManager instance;
	public int score;
	public int highScore;

	public TMP_Text liveScore;
	
	void Awake(){
		if(instance == null){
			instance=this;
		}
	}

    // Start is called before the first frame update
    void Start()
    {
			score=0;
			//PlayerPrefs.SetInt("score", score);
    }

    // Update is called once per frame
    void Update()
    {
		//PlayerPrefs.SetInt("score", score);
	}
	
	void incrementScore(){
		score +=1;
		PlayerPrefs.SetInt("score", score);
		liveScore.text = score.ToString();
	}

	public void UpdateAcvm()
    {
		AchievementManager.instance.CheckAchievements();
    }

	public void startScore(){
		InvokeRepeating ("incrementScore",0.1f,0.5f);
		InvokeRepeating("UpdateAcvm", 30f, 30f);
	}
	  
	public void StopScore(){
		CancelInvoke("incrementScore");
		//PlayerPrefs.SetInt("score",score);	
		
		if(PlayerPrefs.HasKey("highScore")){
			if(score>PlayerPrefs.GetInt("highScore")){
				PlayerPrefs.SetInt ("highScore", score);
			}
		}
		else {
			PlayerPrefs.SetInt("highScore",highScore);
		}
	}	
}
