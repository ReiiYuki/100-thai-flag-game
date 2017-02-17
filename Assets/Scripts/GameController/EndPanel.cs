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
    GameCore core;

	// Use this for initialization
	void Start () {
        core = GameObject.FindGameObjectWithTag("Core").GetComponent<GameCore>();
	}
	
	// Update is called once per frame
	void Update () {
		if ((int)time == 0 && (int)height == 0 && score == core.CalculateScore())
        {
            SetFinishText();
            if (Input.anyKey)
                SceneManager.LoadScene(4);
        }else
        {
            time -= time!=0?Time.deltaTime:0;
            score += score!=core.CalculateScore()?Time.deltaTime:0;
            height -= height != 0 ? Time.deltaTime : 0;
            SetText();
        }

	}

    public void Activate()
    {
        core = GameObject.FindGameObjectWithTag("Core").GetComponent<GameCore>();
        time = core.time;
        height = core.maxHeight;
        score = 0;
        StartCoroutine(GetRank());
    }

    void SetFinishText()
    {
        string finalText = core.isWin ? "Win!" : "Lose" +"\n"+"Score : "+score+"\nRank :"+rank;
        GetComponentInChildren<Text>().text = finalText;
    }

    void SetText()
    {
        string finalText = core.isWin ? "Win!" : "Lose" + "\n"+"Height : "+(int)height+" Time : "+(int)time + "\nScore : " + (int)score ;
        GetComponentInChildren<Text>().text = finalText;
    }

    IEnumerator GetRank()
    {
        WWWForm form = new WWWForm();
        form.AddField("token",PlayerPrefs.GetString("token"));
        form.AddField("score", core.CalculateScore());
        WWW request = new WWW("http://54.201.229.92:3000/api/player/score", form);
        yield return request;
        rank = JsonUtility.FromJson<Rank>(request.text).ranking;
    }
    class Rank
    {
        public int ranking;
    }
}
