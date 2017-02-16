using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour {
    public GameObject panel;
	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(Pause);
        GetComponent<Button>().onClick.AddListener(ShowMenu);
	}

    void Pause()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<FlagCtrl>().Pause();
    }

    void ShowMenu()
    {
        panel.SetActive(true);
    }
}
