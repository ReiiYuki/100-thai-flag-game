using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextUpdate : MonoBehaviour {

    string highStr = "High";
    string timeStr = "Time";

	// Use this for initialization
	void Start () {
        SetLang();
	}
	
	// Update is called once per frame
	void Update () {
        UpdateText();
	}

    void UpdateText()
    {
        GetComponentsInChildren<Text>()[0].text = highStr+"\n" + Utility.CalculatePositionInMeter(Camera.main.transform.position.y);
        GetComponentsInChildren<Text>()[1].text = timeStr+"\n" + (int)GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<FlagCtrl>().time;
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
