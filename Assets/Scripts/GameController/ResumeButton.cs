using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour {
    GameCore core;
	// Use this for initialization
	void Start () {
        core = GameObject.FindGameObjectWithTag("Core").GetComponent<GameCore>();
        GetComponent<Button>().onClick.AddListener(Resume);
	}
	
	void Resume()
    {
        core.isPause = false;
        transform.parent.gameObject.SetActive(false);
    }
}
