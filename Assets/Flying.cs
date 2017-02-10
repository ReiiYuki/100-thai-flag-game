using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour {

    Rigidbody2D physicBody;

	// Use this for initialization
	void Start () {
        physicBody = GetComponent<Rigidbody2D>();
        InvokeRepeating("Fly", 0f, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {

    }

    void Fly()
    {
        physicBody.AddForce(Vector3.up * Time.deltaTime * 100f);
        physicBody.AddForce(Vector3.right * Time.deltaTime * 100f);
    }

}
