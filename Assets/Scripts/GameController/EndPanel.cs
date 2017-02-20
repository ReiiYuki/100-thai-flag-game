﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndPanel : MonoBehaviour {

    float time;
    float height;
    float score;
    int rank;
    bool isLoadRank;
    GameCore core;
    string winStr;
    string loseStr;
    string scoreStr;
    string rankStr;
    string failStr;
    public GameObject mainButt;

	// Use this for initialization
	void Start () {
        core = GameObject.FindGameObjectWithTag("Core").GetComponent<GameCore>();
        SetLang();
        isLoadRank = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!isLoadRank)
        {
            isLoadRank = true;
            StartCoroutine(GetToken());
        }
	}

    void SetLang()
    {
        string lang = PlayerPrefs.GetString("lang");
        winStr = lang == "th" ? "ชนะ!" : "Win!";
        loseStr = lang == "th" ? "แพ้!" : "Lose!";
        scoreStr = lang == "th" ? "คะแนน : " : "Score : ";
        rankStr = lang == "th" ? "อันดับ : " : "Rank : ";
        failStr = lang=="th"?"การเชื่อมต่อมีปัญหา": "There are problem with the connection"; 
    }

    void SetFinishText()
    {
        string result = core.isWin ? winStr : loseStr;
        string finalText = result +"\n"+scoreStr+core.CalculateScore()+"\n"+rankStr+rank;
        GetComponentInChildren<Text>().text = finalText;
    }

    IEnumerator GetRank(string token)
    {
        WWWForm form = new WWWForm();
        form.AddField("token", token);
        form.AddField("score", core.CalculateScore());
        WWW request = new WWW("http://54.201.229.92:3000/api/player/score", form);
        yield return request;
        if (request.text == "")
        {
            string result = core.isWin ? winStr : loseStr;
            string finalText = result + "\n" + scoreStr + core.CalculateScore() + "\n" + failStr;
            GetComponentInChildren<Text>().text = finalText;
        }
        else
        {
            rank = JsonUtility.FromJson<Rank>(request.text).ranking;
            SetFinishText();
        }
        mainButt.SetActive(true);
    }
    [System.Serializable]
    class Rank
    {
        public int ranking;
    }

    IEnumerator GetToken()
    {
        WWWForm form = new WWWForm();
        form.AddField("player_name", PlayerPrefs.GetString("name"));
        WWW request = new WWW("http://54.201.229.92:3000/api/player/token/", form);
        yield return request;
        string token = JsonUtility.FromJson<Token>(request.text).token;
        StartCoroutine(GetRank(token));
    }

    class Token
    {
        public string token;
    }
}
