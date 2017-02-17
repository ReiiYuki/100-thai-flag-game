using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour {

    public Text title, press1, press2, or1, or2, tap1, tap2;

	// Use this for initialization
	void Start () {
        SetLang();
    }
	
	void SetLang()
    {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == "th")
        {
            title.text = "วิธีเล่น";
            press1.text = "กด";
            press2.text = "กด";
            or1.text = "หรือ";
            or2.text = "หรือ";
            tap1.text = "แตะ";
            tap2.text = "แตะ";
        }
    }
}
