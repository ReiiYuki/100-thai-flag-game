using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarningText : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SetLang();
	}
	
	void SetLang()
    {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == "th")
            GetComponent<Text>().text = "อย่าหยุดกด!";
    }
}
