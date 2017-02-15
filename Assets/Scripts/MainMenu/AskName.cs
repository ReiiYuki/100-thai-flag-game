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
            StartCoroutine(GetToken(name));
            gameObject.SetActive(false);
        }
        GetComponentInChildren<InputField>().onEndEdit.AddListener(delegate { AskPlayerName(); });
    }
    
    void AskPlayerName()
    {
        string name = GetComponentsInChildren<Text>()[1].text;
        if (name == "") return;
        PlayerPrefs.SetString("name", name);
        StartCoroutine(GetToken(name));
    }

    IEnumerator GetToken(string name) {
        WWWForm form = new WWWForm();
        form.AddField("player_name", name);
        WWW request = new WWW("http://54.201.229.92:3000/api/player/token/", form);
        yield return request;
        PlayerPrefs.SetString("token",JsonUtility.FromJson<Token>(request.text).token);
        if (request.text != "")
            gameObject.SetActive(false);
    }

    void SetLanguage()
    {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == "th")
            GetComponentInChildren<Text>().text = "ชื่ออะไร?";
    }

    class Token
    {
        public string token;
    }
}
