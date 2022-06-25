using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using GooglePlayGames.BasicApi;

public class LeaderBoardManager : MonoBehaviour
{
    public static LeaderBoardManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();

        Login ();
     
    }

    // Update is called once per frame
    void Update()
    {
        //AddScoreToLeaderBoard();
    }

    public void Login()
    {
        Social.localUser.Authenticate((bool success ) => { });
    }

    public void AddScoreToLeaderBoard()
    {
        Social.ReportScore(ScoreManager.instance.score, GPGS.leaderboard_score_board, (bool success) => {
        });
    }

    public void ShowLeaderBoard()
    {
        if (Social.localUser.authenticated)
        {
            PlayGamesPlatform.Instance.ShowLeaderboardUI(GPGS.leaderboard_score_board);
        }
        else
        {
            Login();
            PlayGamesPlatform.Instance.ShowLeaderboardUI(GPGS.leaderboard_score_board);
        } 
    }
}
