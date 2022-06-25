using GooglePlayGames.BasicApi;
using UnityEngine;
using GooglePlayGames;

public class AchievementManager : MonoBehaviour
{
    public static AchievementManager instance;

    void Awake()
    {
        if (instance == null)
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

        Login();
    }

    // Update is called once per frame
    void Update()
    {
        //CheckAchievements();
    }

    public void Login()
    {
        Social.localUser.Authenticate((bool success) => {

        });
    }

    public void ShowAchievements()
    {
        if (Social.localUser.authenticated)
        {
            Social.ShowAchievementsUI();
        }
        else 
        {
            Login();
            Social.ShowAchievementsUI();
        }
    }

    public void CheckAchievements()
    {
        if (ScoreManager.instance.score >= 300)
        {
            Social.ReportProgress(GPGS.achievement_muladhara_chakra, 100f, (bool success) =>
            {
            });
        }
        if (ScoreManager.instance.score >= 500)
        {
            Social.ReportProgress(GPGS.achievement_svadhishthana_chakra, 100f, (bool success) =>
            {
            });
        }
        if (ScoreManager.instance.score >= 800)
        {
            Social.ReportProgress(GPGS.achievement_manipura_chakra, 100f, (bool success) =>
            {
            });
        }
        if (ScoreManager.instance.score >= 1200)
        {
            Social.ReportProgress(GPGS.achievement_anahata_chakra, 100f, (bool success) =>
            {
            });
        }
        if (ScoreManager.instance.score >= 2000)
        {
            Social.ReportProgress(GPGS.achievement_vishuddha_chakra, 100f, (bool success) =>
            {
            });
        }
        if (ScoreManager.instance.score >= 3000)
        {
            Social.ReportProgress(GPGS.achievement_ajna_chakra, 100f, (bool success) =>
            {
            });
        }
        if (ScoreManager.instance.score >= 5000)
        {
            Social.ReportProgress(GPGS.achievement_sahasrara_chakra, 100f, (bool success) =>
            {
            });
        }
    }
}
