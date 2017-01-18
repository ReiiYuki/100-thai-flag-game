using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour {

    public Sprite spriteNormal;
    public Sprite spriteOnHover;

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
}
