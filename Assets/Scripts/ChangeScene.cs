using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour {
    private float totalTime;
    private bool isDiscard;
    public string scene;
	// Use this for initialization
	void Start () {
        isDiscard = false;
	}
	
	// Update is called once per frame
	void Update () {
        totalTime += Time.deltaTime;
        if (totalTime > 1&&!isDiscard)
        {
            SceneManager.LoadScene(scene);
            isDiscard = true;
        }
	}
}
