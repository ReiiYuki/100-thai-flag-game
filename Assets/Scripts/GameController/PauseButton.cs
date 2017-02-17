using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour {
    public GameObject panel;
    GameCore core;

    // Use this for initialization
    void Start () {
        core = GameObject.FindGameObjectWithTag("Core").GetComponent<GameCore>();
        GetComponent<Button>().onClick.AddListener(Pause);
        GetComponent<Button>().onClick.AddListener(ShowMenu);
	}

    void Pause()
    {
        core.isPause = true;
    }

    void ShowMenu()
    {
        panel.SetActive(true);
    }
}
