using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utility : MonoBehaviour {

	public static int CalculatePositionInMeter(float height)
    {
        return height<0?0:(int)(height) / 2;
    }

}
