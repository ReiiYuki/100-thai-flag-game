using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToInfo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(LoadInfo);
    }

    void LoadInfo()
    {
        SceneManager.LoadScene(7);
    }
}
