using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour {
    public string mode;
    public GameObject playerFlag;
    private int currentHeight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentHeight = ConvertToMeter(playerFlag.transform.position.y);
        if (mode == "quick")
        {

        }
	}

    int ConvertToMeter(float virtualHeight)
    {
        return (int)(virtualHeight + 4.5) / 2;
    }
}
