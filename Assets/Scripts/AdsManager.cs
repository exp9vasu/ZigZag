using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GoogleMobileAds.Api;

public class AdsManager : MonoBehaviour
{
    public static AdsManager instance;
    public GameObject rewardButton;
    public int a;
    //public ReviewManager _reviewManager;
    //public PlayReviewInfo _playReviewInfo;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public BannerView bannerView;
    public InterstitialAd interstitialAd;
    public RewardedAd rewardedAd;

    public void Start()
    {
        MobileAds.Initialize(initStatus => { });

        this.RequestBanner();
        
        this.RequestRewVid();

        this.RequestInter();

        rewardButton.SetActive(false);

        //_reviewManager = new ReviewManager();

        //RequestReview();
    }

    private void RequestBanner()
    {
        //testid
        //string adUnitId = "ca-app-pub-3940256099942544/6300978111";

        //original
        string adUnitId = "ca-app-pub-3618556693995166/4274647461";

        this.bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);

        // Called when an ad request has successfully loaded.
        //this.bannerView.OnAdLoaded += this.HandleOnAdFailedToLoad;
        // Called when an ad request failed to load.
        this.bannerView.OnAdFailedToLoad += this.HandleOnAdFailedToLoad;
        // Called when an ad is clicked.
        //this.bannerView.OnAdOpening += this.HandleOnAdOpened;
        // Called when the user returned from the app after an ad click.
        //this.bannerView.OnAdClosed += this.HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        //this.bannerView.OnAdLeavingApplication += this.HandleOnAdLeavingApplication;

        // Create an empty ad request. For Original code.
        AdRequest request = new AdRequest.Builder().Build();
        
        //AdRequest request = new AdRequest.Builder().AddTestDevice("2077ef9a63d2b398840261c8221a0c9b").Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        //this.RequestBanner();
    }

    public void ShowBanner()
    {
        bannerView.Show();
    }

    public void HideBanner()
    {
        bannerView.Hide();
    }
    /*public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }
    */

    
    private void RequestInter()
    {
        //original
        string interadUnitId = "ca-app-pub-3618556693995166/9143830762";

        //test
        //string interadUnitId = "ca-app-pub-3940256099942544/1033173712";

        this.interstitialAd = new InterstitialAd(interadUnitId);

        // Called when an ad request has successfully loaded.
        this.interstitialAd.OnAdLoaded += HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.interstitialAd.OnAdFailedToLoad += HandleOnAdFailedToLoadInter;
        // Called when an ad is shown.
        //this.interstitialAd.OnAdOpening += HandleOnAdOpened;
        // Called when the ad is closed.
        this.interstitialAd.OnAdClosed += HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        //this.interstitialAd.OnAdLeavingApplication += HandleOnAdLeavingApplication;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        //AdRequest request = new AdRequest.Builder().AddTestDevice("bf678ed986fad0bd").Build();

        //AdRequest request = new AdRequest.Builder().AddTestDevice("2077ef9a63d2b398840261c8221a0c9b").Build();

        // Load the interstitial with the request.
        this.interstitialAd.LoadAd(request);
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdFailedToLoadInter(object sender, AdFailedToLoadEventArgs args)
    {
        //RequestInter();
    }
    
    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        //MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        //MonoBehaviour.print("HandleAdLeavingApplication event received");
    }

    public void ShowInter()
    {
        if (interstitialAd.IsLoaded())
        {
            this.interstitialAd.Show();
        }
    }

    private void RequestRewVid()
    {
        //testID
        //string videoadID = "ca-app-pub-3940256099942544/5224354917";

        //original
        string videoadID = "ca-app-pub-3618556693995166/8569115691";
        this.rewardedAd = new RewardedAd(videoadID);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        
        //AdRequest request = new AdRequest.Builder().AddTestDevice("2077ef9a63d2b398840261c8221a0c9b").Build();
        
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);

        // Called when an ad request has successfully loaded.
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;
    }

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        //MonoBehaviour.print("HandleRewardedAdLoaded event received");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        //RequestRewVid();
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        //MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        ShowVid();
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        rewardButton.SetActive(false);
        //MonoBehaviour.print("HandleRewardedAdClosed event received");
    }
    public void HandleUserEarnedReward(object sender, Reward args)
    {
        int mcount = PlayerPrefs.GetInt("count");
        mcount += 200;
        PlayerPrefs.SetInt("count",mcount);

    }

    public void ShowButton()
    {
        if (rewardedAd.IsLoaded())
        {
            rewardButton.SetActive(true);
        }
        else
        {
            rewardButton.SetActive(false);
        }
    }

    public void ShowVid()
    {

        if (rewardedAd.IsLoaded())
        {
            rewardedAd.Show();
            
        }
        else
        {
            RequestRewVid();
            rewardedAd.Show();
        }
    }

    /*public void RequestReview()
    {
        var requestFlowOperation = _reviewManager.RequestReviewFlow();
        
        _playReviewInfo = requestFlowOperation.GetResult();
    }

    public void LaunchReview()
    {
        _reviewManager.LaunchReviewFlow(_playReviewInfo);
        _playReviewInfo = null;
        
    }

    public void GetReview()
    {
        LaunchReview();
    }*/
}
