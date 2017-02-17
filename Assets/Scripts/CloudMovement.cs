using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour {
    public Sprite[] sprites;
	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(2.5f,2.5f,1f);
        RandomSelectTypeOfCloud();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.right * Time.deltaTime * 0.01f);
        if (transform.position.x >= 3.5f)
            transform.position = new Vector2(-2.5f, transform.position.y);
	}

    void RandomSelectTypeOfCloud()
    {
        GetComponent<SpriteRenderer>().sprite = sprites[(int)Random.Range(0, sprites.Length - 1)];
    }
}
