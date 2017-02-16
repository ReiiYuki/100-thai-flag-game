using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A bird that moves horizontally
public class HorizontalMovementBird : Bird {

	public Vector2 originalPosition;
	public Vector2 finalPosition;
	public float startTime;
	public float distance;
	public Vector3 currentScale;

	// Use this for initialization
	void Start () {
		currentScale = gameObject.transform.localScale;
		findDistance ();
	}
	
	// Update is called once per frame
	void Update () {
		if (hasReachedFinalPosition ()) {
			currentScale.x *= -1;
			gameObject.transform.localScale = currentScale;
			findDistance ();
		}
		this.Fly ();
		if (IsOutOfScreen ()) {
			print ("Visible");
		} else {
			print ("Invisible");
		}
	}

	public override void Fly() {
		float fracDistance = (Time.time - startTime) * flyingSpeed / distance;
		gameObject.transform.position = Vector2.Lerp (originalPosition, finalPosition, fracDistance );
	}
		
	private void findDistance() {
		startTime = Time.time;
		originalPosition = gameObject.transform.position;
		finalPosition = new Vector2(-gameObject.transform.position.x, gameObject.transform.position.y);
		distance = Vector2.Distance (originalPosition, finalPosition);
	}

	private bool hasReachedFinalPosition() {
		return (currentScale.x == 1 & finalPosition.x <= gameObject.transform.position.x) | (currentScale.x == -1 & finalPosition.x >= gameObject.transform.position.x);
	}

}
