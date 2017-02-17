using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour {

	void Start () {
        GetComponent<Button>().onClick.AddListener(BackToMainMenu);
        SetLang();
	}
	
	void BackToMainMenu()
    {
        SceneManager.LoadScene(4);
    }

    void SetLang()
    {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == "th")
            GetComponentInChildren<Text>().text = "กลับไปที่เมนูหลัก";
    }
}
