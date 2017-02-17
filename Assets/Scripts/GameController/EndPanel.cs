using System.Collections;
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

    public GameObject mainButt;

	// Use this for initialization
	void Start () {
        core = GameObject.FindGameObjectWithTag("Core").GetComponent<GameCore>();
        isLoadRank = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!isLoadRank)
        {
            isLoadRank = true;
            StartCoroutine(GetRank());
        }
	}

    void SetFinishText()
    {
        string finalText = core.isWin ? "Win!" : "Lose" +"\n"+"Score : "+core.CalculateScore()+"\nRank : "+rank;
        GetComponentInChildren<Text>().text = finalText;
    }

    IEnumerator GetRank()
    {
        WWWForm form = new WWWForm();
        form.AddField("token", PlayerPrefs.GetString("token"));
        form.AddField("score", core.CalculateScore());
        WWW request = new WWW("http://54.201.229.92:3000/api/player/score", form);
        yield return request;
        rank = JsonUtility.FromJson<Rank>(request.text).ranking;
        SetFinishText();
        mainButt.SetActive(true);
    }
    class Rank
    {
        public int ranking;
    }
}
