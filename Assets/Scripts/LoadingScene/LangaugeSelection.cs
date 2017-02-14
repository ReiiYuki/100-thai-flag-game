using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LangaugeSelection : MonoBehaviour {

    public string language;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(SelectLanguage);
    }
    
    void SelectLanguage()
    {
        PlayerPrefs.SetString("lang", language);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
