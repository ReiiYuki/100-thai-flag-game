using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base class for any future obstacles
public class Obstacle : MonoBehaviour {

    bool left;

    public GameObject SetLeft(bool isLeft)
    {
        left = isLeft;
        return gameObject;
    }

	public bool IsOutOfScreen() {
		return gameObject.GetComponent<SpriteRenderer> ().isVisible;
	}
}
