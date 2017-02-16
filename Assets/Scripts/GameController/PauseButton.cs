using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(Pause);
	}
	
	// Update is called once per frame
	void Update () {
	}

    void Pause()
    {
       Time.timeScale = 0;
    }
}
