using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour {

    //TODO ADD PREFAB HERE
    public GameObject playerFlag;

    //TODO ADD Object pool here

    private int currentHeight;
    private bool[] stageBG;

	// Use this for initialization
	void Start () {
        stageBG = new bool[45];
	}
	
	// Update is called once per frame
	void Update () {
        currentHeight = ConvertToMeter(playerFlag.transform.position.y);
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

    //TODO Add stage here

    void SpawnBackground()
    {
        if (!stageBG[0]&&GetCurrentHeight()>=0)
        {

        }else if (!stageBG[1] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[2] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[3] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[4] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[5] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[6] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[7] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[8] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[9] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[10] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[11] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[12] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[13] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[14] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[15] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[16] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[17] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[18] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[19] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[20] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[21] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[22] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[23] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[24] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[25] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[26] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[27] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[28] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[29] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[30] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[31] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[32] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[33] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[34] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[35] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[36] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[37] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[38] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[39] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[40] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[41] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[42] && GetCurrentHeight() >= 0)
        {

        }
        else if (!stageBG[43] && GetCurrentHeight() >= 0)
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
