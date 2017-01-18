using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : MonoBehaviour {

    public Sprite thSprite;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnLevelWasLoaded(int level)
    {
        if (PlayerPrefs.GetString("lang") == "th")
            GetComponent<SpriteRenderer>().sprite = thSprite;
    }
}
