using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour {

    //TODO ADD PREFAB HERE
    public GameObject pigeonPrototype;
    public GameObject drovePrototype;
    public GameObject sparrowPrototype;
    public GameObject gawowPrototype;
    public GameObject dronePrototype;
    public GameObject lampPrototype;
    public GameObject thaiRocketPrototype;
    public GameObject helicopterPrototype;
    public GameObject hotBolloonPrototype;
    public GameObject knifeChulaPrototype;
    public GameObject knifeSnakePrototype;

    //TODO ADD Object pool here

    private int currentHeight;
    private bool[] stageBG;

	// Use this for initialization
	void Start () {
        stageBG = new bool[45];
	}
	
	// Update is called once per frame
	void Update () {
//        currentHeight = ConvertToMeter(playerFlag.transform.position.y);
        SpawnBackground();
	}

    int ConvertToMeter(float virtualHeight)
    {
        return (int)(virtualHeight + 4.5) / 2;
    }

    public int GetCurrentHeight()
    {
        return currentHeight;
    }

    void SpawnBackground()
    {
        if (!stageBG[0]&&GetCurrentHeight()>=0)
        {
            stageBG[0] = true;
        }else if (!stageBG[1] && GetCurrentHeight() >= 45)
        {

        }
        else if (!stageBG[2] && GetCurrentHeight() >= 61)
        {

        }
        else if (!stageBG[3] && GetCurrentHeight() >= 80)
        {

        }
        else if (!stageBG[4] && GetCurrentHeight() >= 112)
        {

        }
        else if (!stageBG[5] && GetCurrentHeight() >= 145)
        {

        }
        else if (!stageBG[6] && GetCurrentHeight() >= 170)
        {

        }
        else if (!stageBG[7] && GetCurrentHeight() >= 188)
        {   

        }
        else if (!stageBG[8] && GetCurrentHeight() >= 255)
        {

        }
        else if (!stageBG[9] && GetCurrentHeight() >= 394)
        {

        }
        else if (!stageBG[10] && GetCurrentHeight() >= 310)
        {

        }
        else if (!stageBG[11] && GetCurrentHeight() >= 361)
        {

        }
        else if (!stageBG[12] && GetCurrentHeight() >= 401)
        {

        }
        else if (!stageBG[13] && GetCurrentHeight() >= 489)
        {

        }
        else if (!stageBG[14] && GetCurrentHeight() >= 521)
        {

        }
        else if (!stageBG[15] && GetCurrentHeight() >= 580)
        {

        }
        else if (!stageBG[16] && GetCurrentHeight() >= 614)
        {

        }
        else if (!stageBG[17] && GetCurrentHeight() >= 809)
        {

        }
        else if (!stageBG[18] && GetCurrentHeight() >= 980)
        {

        }
        else if (!stageBG[19] && GetCurrentHeight() >= 1930)
        {

        }
        else if (!stageBG[20] && GetCurrentHeight() >= 1980)
        {

        }
        else if (!stageBG[21] && GetCurrentHeight() >= 2580)
        {

        }
        else if (!stageBG[22] && GetCurrentHeight() >= 2980)
        {

        }
        else if (!stageBG[23] && GetCurrentHeight() >= 3756)
        {

        }
        else if (!stageBG[24] && GetCurrentHeight() >= 4980)
        {

        }
        else if (!stageBG[25] && GetCurrentHeight() >= 4105)
        {

        }
        else if (!stageBG[26] && GetCurrentHeight() >= 4401)
        {

        }
        else if (!stageBG[27] && GetCurrentHeight() >= 4787)
        {

        }
        else if (!stageBG[28] && GetCurrentHeight() >= 5469)
        {

        }
        else if (!stageBG[29] && GetCurrentHeight() >= 6170)
        {

        }
        else if (!stageBG[30] && GetCurrentHeight() >= 6549)
        {

        }
        else if (!stageBG[31] && GetCurrentHeight() >= 6980)
        {

        }
        else if (!stageBG[32] && GetCurrentHeight() >= 7634)
        {

        }
        else if (!stageBG[33] && GetCurrentHeight() >= 7980)
        {

        }
        else if (!stageBG[34] && GetCurrentHeight() >= 8828)
        {

        }
        else if (!stageBG[35] && GetCurrentHeight() >= 11867)
        {

        }
        else if (!stageBG[36] && GetCurrentHeight() >= 15380)
        {

        }
        else if (!stageBG[37] && GetCurrentHeight() >= 17980)
        {

        }
        else if (!stageBG[38] && GetCurrentHeight() >= 20059)
        {

        }
        else if (!stageBG[39] && GetCurrentHeight() >= 23980)
        {

        }
        else if (!stageBG[40] && GetCurrentHeight() >= 111980)
        {

        }
        else if (!stageBG[41] && GetCurrentHeight() >= 399980)
        {

        }
        else if (!stageBG[42] && GetCurrentHeight() >= 588980)
        {

        }
        else if (!stageBG[43] && GetCurrentHeight() >= 3299980)
        {

        }
        else if (!stageBG[44] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[45] && GetCurrentHeight() >= 0)
        {

        }
    }

    //TODO Add Spawn Code
    void SpawnObstacle(GameObject obstacleType, Vector3 position)
    {
        // IF obstacle exist in List
        // IF obstacle not exist in List
    }
}
