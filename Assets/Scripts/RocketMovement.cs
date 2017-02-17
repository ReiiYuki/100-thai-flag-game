using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour {

    float speed;

	// Use this for initialization
	void Start () {
        speed = 5f;
        SelectDirection();
        transform.position = new Vector2(transform.position.x,transform.position.y-4f);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }

    void SelectDirection()
    {
        if (transform.position.x<=0)
            transform.Rotate(new Vector3(0f,0f,-45f));
        else
            transform.Rotate(new Vector3(0f, 0f, 45f));
    }
}
