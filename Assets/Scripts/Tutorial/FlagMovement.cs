using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagMovement : MonoBehaviour
{

    public string state;
    Vector2 origin;

    // Use this for initialization
    void Start()
    {
        state = "l";
        origin = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (state == "l")
            transform.Translate(new Vector2(-1f, 2f) * 1f * Time.deltaTime);
        else if (state == "c")
            transform.Translate(new Vector2(0, 1f) * 2f * Time.deltaTime);
        else if (state == "r")
            transform.Translate(new Vector2(1f, 2f) * 1f * Time.deltaTime);

        if (state == "l" && transform.position.x < -2)
        {
            transform.position = origin;
            state = "r";
        }
        if (state == "c" && transform.position.y > 3)
        {
            transform.position = origin;
            state = "l";
        }
        if (state == "r" && transform.position.x > 2)
        {
            transform.position = origin;
            state = "c";
        }
    }


}
