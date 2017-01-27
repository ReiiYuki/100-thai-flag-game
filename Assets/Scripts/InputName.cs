using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour {
    public InputField nameField;
    private const string SERVER_URL = "http://54.201.229.92:3000";
    private const string GET_TOKEN = "/api/player/token/";
    // Use this for initialization
    void Start () {
        nameField.onEndEdit.AddListener(delegate { SubmitName(); });
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void SubmitName()
    {
        StartCoroutine(ConnectToServer());
    }

    IEnumerator ConnectToServer()
    {
        WWWForm form = new WWWForm();
        form.AddField("player_name", nameField.text);
        WWW request = new WWW(SERVER_URL + GET_TOKEN, form);
        yield return request;
        Token token = JsonUtility.FromJson<Token>(request.text);
        Debug.Log(token.token);
    }

    class Token
    {
        public string token;
    }
}
