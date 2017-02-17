using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : Obstacle {

    float speed;
    float x;
	// Use this for initialization
	void Start () {
        speed = 5f;
        initCore();
        SelectDirection();
        transform.position = new Vector2(transform.position.x,transform.position.y-4f);
    }
	
	// Update is called once per frame
	void Update () {
        if (!GetCore().isPause && !GetCore().isOver && GetCore().isStart)
            transform.Translate(Vector2.up * Time.deltaTime * speed);

        if (x <= 0)
        {
            if (transform.position.x >= 3.2)
                gameObject.SetActive(false);
        }
        else
        {
            if (transform.position.x <= 3.2)
                gameObject.SetActive(false);
        }
    }

    void SelectDirection()
    {
        x = transform.position.x;
        if (transform.position.x<=0)
            transform.Rotate(new Vector3(0f,0f,-45f));
        else
            transform.Rotate(new Vector3(0f, 0f, 45f));
    }

}
