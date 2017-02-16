using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour {

	void Start () {
        Time.timeScale = 1;
        GetComponent<Button>().onClick.AddListener(BackToMainMenu);
	}
	
	void BackToMainMenu()
    {
        SceneManager.LoadScene(4);
    }
}
