using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;
using UnityEngine.UI;

public class ADSmanager : MonoBehaviour
{
    public Text RewardText;
    private int rewardCount = 0;
    private string gameId = "1234567";
    private bool testMode = true;
    string placementId_video = "video";
    string placementId_rewarded = "rewardedVideo";


    void Start()
    {
       if(Application.platform == RuntimePlatform.IPhonePlayer)
        {
            gameId = "3876521";
        }
            else if(Application.platform == RuntimePlatform.Android)
        {
            gameId = "3876520";
        }
        Monetization.Initialize(gameId, testMode);
    }

    

    public void ShowAd()
    {
        StartCoroutine(WaitForAd());
    }
    public void ShowRewardedADS()
    {
        StartCoroutine(WaitForAd(true));
    }

    IEnumerator WaitForAd(bool reward=false)
    {
        string placementId = reward ? placementId_rewarded : placementId_video;
        while (!Monetization.IsReady(placementId))
        {
            yield return null;
        }

        ShowAdPlacementContent ad = null;
        ad = Monetization.GetPlacementContent(placementId) as ShowAdPlacementContent;

        if (ad != null)
        {
            if (reward)
                ad.Show(AdFinished);
            else
                ad.Show();
        }
    }

    void AdFinished(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            rewardCount++;
            RewardText.text = rewardCount.ToString();
        }
    }
}


