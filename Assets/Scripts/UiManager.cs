using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{	

	public static UiManager instance;
	
	public GameObject zigzagPanel;
	public GameObject gameOverPanel;
	public GameObject tapText;
	public GameObject live;
	public GameObject RateButton;

	public TMP_Text score;
	public TMP_Text highScore1;
	public TMP_Text highScore2;
	public TMP_Text totalCorona;
	public TMP_Text liveScore;

	public TMP_Text countTextLive;

	int imgn;

	[SerializeField]
	int coronaTotal;
	int corona;

	void Awake(){
		if (instance == null){
			instance = this;
		}
	} 
	
    // Start is called before the first frame update
    void Start()
    {
		highScore1.text="High Score:" + PlayerPrefs.GetInt("highScore");
		int	rand = UnityEngine.Random.Range(0, 11);
		imgn = rand;

		AdsManager.instance.a = 0;
	}
	
	public void GameStart(){
		tapText.SetActive (false);
		zigzagPanel.SetActive(false);

		//zigzagPanel.GetComponent<Animator> ().Play("ZigZag");
		//liveCorona.text = PlayerPrefs.GetInt("score").ToString();

	}

	IEnumerator ExecuteAfterTime(float time)
	{
		yield return new WaitForSeconds(time);
		// Code to execute after the delay
		gameOverPanel.SetActive(true);
	}

	IEnumerator ExecuteAfterTime1(float time)
	{
		yield return new WaitForSeconds(time);
		BallController.instance.MuteFall();
		//AdsManager.instance.ShowInter();
	}

	IEnumerator ExecuteAfterTime2(float time)
	{
		yield return new WaitForSeconds(time);
		//AdsManager.instance.ShowInter();
		AdsManager.instance.a = 0;
		MonoBehaviour.print("INTER-MILAN");
	}

	public void GameOver(){

		score.text = PlayerPrefs.GetInt ("score").ToString();
		highScore2.text = PlayerPrefs.GetInt("highScore").ToString();

		
		CheckRateButton();


		StartCoroutine(ExecuteAfterTime(0.3f));
		StartCoroutine(ExecuteAfterTime1(0.2f));
		StartCoroutine(ExecuteAfterTime2(0.01f));

		if (gameOverPanel)
		{ AdsManager.instance.ShowInter(); }

		BallController.instance.PlayFall();
		
		
	}
	
	public void Reset(){
		SceneManager.LoadScene (0);
	}
	
	public void Rate()
    {
		Application.OpenURL("https://play.google.com/store/apps/details?id=com.tanishgames.sweepit1");
	}

	public void CheckRateButton()
    {
		if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork || Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
		{
			RateButton.SetActive(true);
		}
        else
        {
			RateButton.SetActive(false);
        }
	}

	// Update is called once per frame
    void Update()
    {
		live.SetActive(true);
		//liveScore.text = PlayerPrefs.GetInt("score").ToString();
		//countTextLive.text = PlayerPrefs.GetInt("count").ToString();
	}

}
