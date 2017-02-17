using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour {
    GameCore core;
	// Use this for initialization
	void Start () {
        core = GameObject.FindGameObjectWithTag("Core").GetComponent<GameCore>();
        GetComponent<Button>().onClick.AddListener(Resume);
        SetLang();
	}
	
	void Resume()
    {
        core.isPause = false;
        transform.parent.gameObject.SetActive(false);
    }

    void SetLang()
    {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == "th")
            GetComponentInChildren<Text>().text = "เล่นต่อ";
    }
}
