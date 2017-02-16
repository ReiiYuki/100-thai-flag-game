using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(Resume);
	}
	
	void Resume()
    {
        Time.timeScale = 1;
        transform.parent.gameObject.SetActive(false);
    }
}
