using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	public bool gameOver;
	
	void Awake(){
		if(instance==null){
			instance = this;	
		}
	}
	
    // Start is called before the first frame update
    void Start()
    {
		//Application.targetFrameRate = 30;
		AdsManager.instance.ShowBanner();
        gameOver=false;
    }

	public void GameStart(){
		UiManager.instance.GameStart();
		ScoreManager.instance.startScore();
	}

	public void GameOver(){
		
		UiManager.instance.GameOver();
		ScoreManager.instance.StopScore();
		LeaderBoardManager.instance.AddScoreToLeaderBoard();
		//AdsManager.instance.ShowInter();

		SoundManager.instance.Mute("music");
		//AdsManager.instance.ShowInter();
		AdsManager.instance.ShowButton();
	}
}
