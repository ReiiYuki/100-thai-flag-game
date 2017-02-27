using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextUpdate : MonoBehaviour {

    string highStr = "Height";
    string timeStr = "Time";
    GameCore core;
	// Use this for initialization
	void Start () {
        core = GameObject.FindGameObjectWithTag("Core").GetComponent<GameCore>();
        SetLang();
	}
	
	// Update is called once per frame
	void Update () {
        UpdateText();
	}

    void UpdateText()
    {
        GetComponentsInChildren<Text>()[0].text = highStr+"\n" + Utility.CalculatePositionInMeter(Camera.main.transform.position.y);
        GetComponentsInChildren<Text>()[1].text = timeStr+"\n" + (int)core.time;
    }

    void SetLang()
    {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == "th")
        {
            highStr = "สูง";
            timeStr = "เวลา";
            GetComponentsInChildren<Text>()[0].text = highStr + "\n0";
            GetComponentsInChildren<Text>()[1].text = timeStr + "\n0";
        }
    }
}
