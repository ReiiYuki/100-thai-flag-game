using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour {
    public GameObject connectFailText;
    void Start () {
        StartCoroutine(LoadScoreListFromServer());
	}

    IEnumerator LoadScoreListFromServer()
    {
        WWW request = new WWW("http://54.201.229.92:3000/api/player/score");
        yield return request;
        if (request.text == "")
        {
            connectFailText.SetActive(true);
        }else
        {
            ScoreList scoreList = JsonUtility.FromJson<ScoreList>(request.text);
            string scoreListStr = "";
            string nameListStr = "";
            string rankListStr = "";
            for (int i = 0; i < scoreList.score_list.Length; i++)
            {
                scoreListStr += scoreList.score_list[i].score + "\n";
                nameListStr += scoreList.score_list[i].name + "\n";
                rankListStr += (i + 1) + "\n";
            }
            GetComponentsInChildren<Text>()[0].text = rankListStr;
            GetComponentsInChildren<Text>()[1].text = nameListStr;
            GetComponentsInChildren<Text>()[2].text = scoreListStr;
        }
    }
    [System.Serializable]
    class ScoreList
    {
        public Score[] score_list;
    }
    [System.Serializable]
    public class Score
    {
        public string createdAt;
        public string id;
        public string name;
        public int score;
    }
}
