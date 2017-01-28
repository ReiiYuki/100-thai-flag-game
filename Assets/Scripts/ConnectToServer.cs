using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectToServer : MonoBehaviour {

    private string url = "http://54.201.229.92:3000";

    // Use this for initialization
    IEnumerator Start () {
        Debug.Log("Join");
        WWWForm form = new WWWForm();
        form.AddField("player_name", "nut");
        WWW request = new WWW(url+ "/api/player/token/",form);
        yield return request;
        Debug.Log(request.text);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
