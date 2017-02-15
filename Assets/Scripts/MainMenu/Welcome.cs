using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Welcome : MonoBehaviour {

    string welcome_text;
    public GameObject askName;

	// Use this for initialization
	void Start () {
        GetWelcomeTextByLanguage();
        SetUpClick();
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

    public void OnPointerDownDelegate(PointerEventData data)
    {
        askName.SetActive(true);
    }

    void SetUpClick()
    {
        EventTrigger trigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((data) => { OnPointerDownDelegate((PointerEventData)data); });
        trigger.triggers.Add(entry);
    }
}
