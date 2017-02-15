using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SetLanguage();
	}
	
	void SetLanguage()
    {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == "th")
        {
            Text[] logoComponent = GetComponentsInChildren<Text>();
            logoComponent[0].text = "ชัก";
            logoComponent[1].text = "ให้สูง";
            logoComponent[2].text = "ธงชาติไทย";
        }
    }
}
