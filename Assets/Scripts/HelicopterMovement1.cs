using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterMovement1 : Obstacle {
    Vector2 origin;
	// Use this for initialization
	void Start () {
        origin = transform.position;
        initCore();
	}
	
	// Update is called once per frame
	void Update () {
        //        if (!GetCore().isPause && !GetCore().isOver && GetCore().isStart)
        Follow();
       if (!IsOutOfScreen())
            transform.position = origin;
    }
    void Follow()
    {
          Vector3 playerPos = Camera.main.transform.position;
          float distance = Mathf.Pow((transform.position.x - playerPos.x), 2)+ Mathf.Pow((transform.position.y - playerPos.y), 2);
          if (distance <= 30)
          {
              Vector2 position = playerPos - transform.position;
              transform.Translate(position * Time.deltaTime * 1.5f);
              transform.Rotate(new Vector3(0, 0, distance*-1)*Time.deltaTime);
          }else
          {
              transform.Translate(Vector3.right * -2f*Time.deltaTime);
          }
    }
}
