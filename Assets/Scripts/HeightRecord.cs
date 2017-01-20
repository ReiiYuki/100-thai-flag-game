using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightRecord : MonoBehaviour {
    public GameObject flag;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(flag.GetComponent<Transform>().position.y);
	}
}
