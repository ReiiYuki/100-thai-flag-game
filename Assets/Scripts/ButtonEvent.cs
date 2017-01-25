using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour {

    public Sprite spriteNormal;
    public Sprite spriteOnHover;
    public string language;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().sprite = spriteOnHover;
    }

    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = spriteNormal;
    }

    private void OnMouseDown()
    {
        PlayerPrefs.SetString("lang", language);
        SceneManager.LoadScene("Main_Menu_Scene");
    }
}
