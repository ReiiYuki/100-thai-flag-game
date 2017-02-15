using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHeaderLang : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SetLanguage();
	}
	
	void SetLanguage()
    {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == "th")
            GetComponent<Text>().text = "ตารางคะแนน";
    }
}
