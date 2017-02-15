using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoLang : MonoBehaviour {

    public GameObject objectiveTitle;
    public GameObject objective;
    public GameObject producer;
    public GameObject developer;

	// Use this for initialization
	void Start () {
        SetLang();
	}
	
	void SetLang()
    {
        string lang = PlayerPrefs.GetString("lang");
        if (lang == "th")
        {
            objectiveTitle.GetComponent<Text>().text = "จุดมุ่งหมาย";
            objective.GetComponent<Text>().text = "ฉลอง 100 ปี ธงชาติไทย";
            producer.GetComponent<Text>().text = "จัดสร้างโดย";
            developer.GetComponent<Text>().text = "พัฒนาโดย";
        }
    }
}
