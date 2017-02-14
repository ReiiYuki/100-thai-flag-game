using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToScoreBoard : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        SetLanguage();
        GetComponent<Button>().onClick.AddListener(LoadQuickGame);
    }

    void LoadQuickGame()
    {
        //SceneManager.LoadScene(5);
    }

    void SetLanguage()
    {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == "th")
            GetComponentInChildren<Text>().text = "กระดานคะแนน";
    }
}
