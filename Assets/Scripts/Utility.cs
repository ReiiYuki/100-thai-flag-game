using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utility : MonoBehaviour {

	public static int CalculatePositionInMeter(float height)
    {
        return (int)(height) / 2;
    }

}
