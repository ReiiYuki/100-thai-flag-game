using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AskName : MonoBehaviour {

	void Start () {
        SetLanguage();
        CheckNameExisted();
	}
	
	void CheckNameExisted()
    {
        string name = PlayerPrefs.GetString("name");
        if (name != "")
        {
            gameObject.SetActive(false);
        }
        GetComponentInChildren<InputField>().onEndEdit.AddListener(delegate { AskPlayerName(); });
    }
    
    void AskPlayerName()
    {
        string name = GetComponentsInChildren<Text>()[1].text;
        if (name == "") return;
        PlayerPrefs.SetString("name", name);
        gameObject.SetActive(false);
    }

    void SetLanguage()
    {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == "th")
            GetComponentInChildren<Text>().text = "ชื่ออะไร?";
    }

 
}
