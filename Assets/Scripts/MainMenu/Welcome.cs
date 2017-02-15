using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Welcome : MonoBehaviour {

    string welcome_text;

	// Use this for initialization
	void Start () {
        GetWelcomeTextByLanguage();
	}
	
	// Update is called once per frame
	void Update () {
        UpdateWelcomeText();
	}

    void GetWelcomeTextByLanguage()
    {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == "th")
            welcome_text = "ยินดีต้อนรับ";
        else
            welcome_text = "Welcome";
    }

    void UpdateWelcomeText()
    {
        string name = PlayerPrefs.GetString("name");
        GetComponent<Text>().text = welcome_text + " " + name + " !";
    }
}
