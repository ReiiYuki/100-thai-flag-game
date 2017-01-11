using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagControl : MonoBehaviour {
    Rigidbody2D physicObject;

    void Awake () {
        physicObject = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            physicObject.AddForce(new Vector2(-5f, 0f));
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            physicObject.AddForce(new Vector2(5f, 0f));
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            physicObject.AddForce(new Vector2(0f, 15f));
    }
}
