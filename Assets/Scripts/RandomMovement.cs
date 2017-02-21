using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour {
	private Vector2 direction;
	public float heightScale = 1.0F;
	public float widthScale = 1.0F;
	public float xDirection = 0.1F;
	public float yDirection = 0.1F;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		Vector2 pos = transform.position;
		float height = heightScale * (Mathf.PerlinNoise (pos.y*Time.time,Time.time)-0.5F);
		float width = widthScale * (Mathf.PerlinNoise (Time.time, pos.x*Time.time)-0.5F);
		pos.y += height + Mathf.PerlinNoise (Time.time * pos.y, 0.0F) * yDirection;
		pos.x += width + Mathf.PerlinNoise(0.0F,Time.time*pos.x)* xDirection;
		transform.position = pos;
	}
}
