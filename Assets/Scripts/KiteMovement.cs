using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiteMovement : Obstacle {
    Vector2 origin;
	// Use this for initialization
	void Start () {
        initCore();
        origin = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (!GetCore().isPause && !GetCore().isOver && GetCore().isStart)
            transform.Translate(new Vector2(2f, 8f)*Time.deltaTime*0.1f);
        if ((origin.x <= 0 && transform.position.x > 3)&&(origin.x>0 && transform.position.x<-3))
            transform.position = origin;
	}
}
