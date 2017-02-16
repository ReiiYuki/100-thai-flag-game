using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour {

	// The gameObject that this camera will follow all the way.
	private GameObject playerFlag;

	// Use this for initialization
	void Start () {
		//Get player flag by finding FlagCtrl component which is attached to playerFlag
		playerFlag = FindObjectOfType<FlagCtrl>().gameObject;
	}

	// Update is called once per frame
	void Update () {
		//Change main camera transform's position
		//Only y-axis value changes
		Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x,
														playerFlag.transform.position.y,
														Camera.main.transform.position.z);
	}
}
