using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusoidalMovementBird : Bird {

	// Equation: y = sin(x)

	// X each frame = Current position + ( flying speed x time between frame )
	public float position_x;

	// Y each frame = Sin ( (PI x 2) / 360 x X x 90 )
	public float position_y;

	// Max distance the bird travels from the center
	public float maxDistance;

	private Vector2 nextPosition;

	public int direction;
	public bool hasFlipped;

	void Start() {
		maxDistance = 4.5f;
		nextPosition = Vector2.zero;
		if (gameObject.transform.position.x >= 0) {
			direction = 1;
		} else {
			direction = -1;
		}
	}

	// Update is called once per frame
	void Update () {
		Fly ();
	}

	// Override method from super class
	public override void Fly() {
		if (canFlip ()) {
			direction *= -1;
		} 
		position_x = gameObject.transform.position.x + (flyingSpeed * Time.deltaTime * direction);
		position_y = Mathf.Sin ( Mathf.Deg2Rad * position_x * 90 );
		setNextPosition (position_x, position_y);
	}

	public bool canFlip() {
		return Mathf.Abs(gameObject.transform.position.x) >= maxDistance;
	}

	private void setNextPosition(float x, float y) {
		nextPosition.x = x;
		nextPosition.y = y;
		gameObject.transform.position = nextPosition;
	}

}
