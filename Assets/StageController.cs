using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour {

    //TODO ADD PREFAB HERE
    public GameObject playerFlag;

    //TODO ADD Object pool here

    private int currentHeight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentHeight = ConvertToMeter(playerFlag.transform.position.y);
        
	}

    int ConvertToMeter(float virtualHeight)
    {
        return (int)(virtualHeight + 4.5) / 2;
    }

    public int GetCurrentHeight()
    {
        return currentHeight;
    }

    //TODO Add stage here
}
