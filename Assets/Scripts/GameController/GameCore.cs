using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour {

    public bool isStart;
    public bool isPause;
    public bool isOver;
    public float time;
    public float maxHeight;

	// Use this for initialization
	void Start () {
        isStart = false;
        isPause = false;
        isOver = false;
        time = 0;
        maxHeight = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (isStart && !isPause && !isOver)
            time += Time.deltaTime;
        if (isOver)
            Debug.Log(CalculateScore());
        if (Camera.main.transform.position.y > maxHeight)
            maxHeight = Camera.main.transform.position.y;

    }

    public int CalculateScore()
    {
        return (int) (Utility.CalculatePositionInMeter(maxHeight) / time*100f);
    }
}
