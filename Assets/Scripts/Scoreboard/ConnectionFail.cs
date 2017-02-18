using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectionFail : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void SetLang()
    {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == "th")
            GetComponent<Text>().text = "ขออภัย!\nการเชื่อมต่อมีปัญหา";
    }
}
