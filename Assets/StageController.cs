using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour {
    public GameObject playerFlag;

    private float time;
    private int currentHeight, currentHighest;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentHeight = ConvertToMeter(playerFlag.transform.position.y);
        time += Time.deltaTime;
	}

    int ConvertToMeter(float virtualHeight)
    {
        return (int)(virtualHeight + 4.5) / 2;
    }
}
