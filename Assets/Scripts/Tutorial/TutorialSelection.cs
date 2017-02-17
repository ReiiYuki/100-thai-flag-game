using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialSelection : MonoBehaviour {
    public GameObject mobilePlatformTutorial;
    public GameObject desktopPlatformTutorial;
	// Use this for initialization
	void Start () {
        if (Application.isMobilePlatform)
            mobilePlatformTutorial.SetActive(true);
        else
            desktopPlatformTutorial.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
            SceneManager.LoadScene(8);
	}
}
