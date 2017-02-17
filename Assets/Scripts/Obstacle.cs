using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base class for any future obstacles
public class Obstacle : MonoBehaviour {

    GameCore core;
    
    void Start()
    {
        initCore();
    }

    public GameCore GetCore()
    {
        return core;
    }

    public void initCore()
    {
        core = GameObject.FindGameObjectWithTag("Core").GetComponent<GameCore>();
    }

    public bool IsOutOfScreen() {
		return gameObject.GetComponent<SpriteRenderer> ().isVisible;
	}

}
