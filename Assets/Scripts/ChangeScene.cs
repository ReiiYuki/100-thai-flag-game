using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Application.LoadLevel(scene);
            isDiscard = true;
        }
	}
}
