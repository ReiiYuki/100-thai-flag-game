using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {
    public string nextScene;

    void Start () {
        StartCoroutine(SwapScene());
	}

    IEnumerator SwapScene()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("OK");
    }
}
