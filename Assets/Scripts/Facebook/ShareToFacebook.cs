using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
public class ShareToFacebook : MonoBehaviour {

	public void Share()
    {
        int score = GameObject.FindGameObjectWithTag("Core").GetComponent<GameCore>().CalculateScore();
        int height = (int)GameObject.FindGameObjectWithTag("Core").GetComponent<GameCore>().GetHeight();
        int time = (int)GameObject.FindGameObjectWithTag("Core").GetComponent<GameCore>().GetTime();
        string name = PlayerPrefs.GetString("name");
        string title = "";
        string content = "";
        if (PlayerPrefs.GetString("lang") == "th") { 
            title = name + " ทำได้ " + "\"" + score + "\" คะแนน ยินดีด้วยนะ~";
            content = name + " ทำได้ " + "\"" + score + "\" คะแนน ชักได้ "+height+" เมตรใน "+time+" วินาที"+" ยินดีด้วยนะ~";
        }else
        {
            title = name + " Get Score " + "\"" + score + "\" Points Congrat~";
            content = name + " Get Score " + "\"" + score + "\" คะแนน Go Height " + height + " Metres In " + time + " Seconds" + " Congrat~";
        }
        FB.ShareLink(
            new Uri("https://reiiyuki.github.io/100-thai-flag-game/"),
            title,
            content,
            new Uri("https://github.com/ReiiYuki/100-thai-flag-game/raw/master/docs/Screenshot_20170218-015428.png"),
            callback: ShareCallback
        );
    }

    private void ShareCallback(IShareResult result)
    {
        if (result.Cancelled || !String.IsNullOrEmpty(result.Error))
        {
            Debug.Log("ShareLink Error: " + result.Error);
        }
        else if (!String.IsNullOrEmpty(result.PostId))
        {
            // Print post identifier of the shared content
            Debug.Log(result.PostId);
        }
        else
        {
            // Share succeeded without postID
            Debug.Log("ShareLink success!");
        }
    }
}
