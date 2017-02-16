using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base class for any future obstacles
public class Obstacle : MonoBehaviour {

    public bool isPause;

    void Start()
    {
        isPause = false;
    }

    void SetPause(bool pause)
    {
        isPause = pause;
    }

}
