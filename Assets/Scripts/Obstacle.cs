﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base class for any future obstacles
public class Obstacle : MonoBehaviour {

    bool left;

    GameObject SetLeft(bool isLeft)
    {
        left = isLeft;
        return gameObject;
    }
}
