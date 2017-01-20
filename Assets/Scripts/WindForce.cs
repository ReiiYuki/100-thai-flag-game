using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindForce : MonoBehaviour {
    public float windSpeed;
    public float direction;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        foreach (Rigidbody2D physicObject in GetComponentsInChildren<Rigidbody2D>())
        {
            float windForceX = windSpeed * (float)System.Math.Cos(direction);
            float windForceY = windSpeed * (float)System.Math.Sin(direction);
            physicObject.AddForce(new Vector2(windForceX, windForceY));
        }
            
	}
}
