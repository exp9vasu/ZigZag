using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GoogleMobileAds.Api;

public class adsManager : MonoBehaviour
{
    public static adsManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private BannerView bannerView;
    private InterstitialAd interstitialAd;
    private RewardedAd rewardedAd;

    public void Start()
    {
        MobileAds.Initialize(initStatus => { });
        
    }

    private void RequestBanner()
    {

        string adUnitId = "ca-app-pub-3940256099942544/6300978111";

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
        //AdRequest request = new AdRequest.Builder().Build();
        AdRequest request = new AdRequest.Builder().AddTestDevice("bf678ed986fad0bd").Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }

    /*public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }*/

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        this.RequestBanner();
    }

    public void ShowBanner()
    {
        this.RequestBanner();
        this.bannerView.Show();
    }

    public void HideBanner()
    {
        this.bannerView.Hide();
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
        string interadUnitId = "ca-app-pub-3940256099942544/1033173712";

        this.interstitialAd = new InterstitialAd(interadUnitId);

        // Create an empty ad request.
        //AdRequest request = new AdRequest.Builder().Build();
        AdRequest request = new AdRequest.Builder().AddTestDevice("bf678ed986fad0bd").Build();

        // Load the interstitial with the request.
        this.interstitialAd.LoadAd(request);
    } 

    public void showInter()
    {
        //if (this.interstitialAd.IsLoaded())
        {
            this.RequestInter();
            this.interstitialAd.Show();
        }
    }

    private void RequestRewVid()
    {
        string videoadID = "ca-app-pub-3940256099942544/5224354917";

        this.rewardedAd = new RewardedAd(videoadID);

        // Create an empty ad request.
        //AdRequest request = new AdRequest.Builder().Build();
        AdRequest request = new AdRequest.Builder().AddTestDevice("bf678ed986fad0bd").Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);

        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        int mcount = PlayerPrefs.GetInt("count");
        mcount += 200;
        PlayerPrefs.SetInt("count",mcount);

    }

    public void ShowVid()
    {
        //this.RequestRewVid();
        //if (rewardedAd.IsLoaded())
        {
            this.RequestRewVid();
            this.rewardedAd.Show();
            Debug.Log("Video AD");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //ShowBanner();
    }
}
