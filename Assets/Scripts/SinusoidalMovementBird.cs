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

	// next position for game object (for performace)?
	private Vector2 nextPosition;

	// Direction of that the bird will fly to -- 1 fly to right while -1 fly to the left
	public int direction;

	private Vector3 currentScale;

	void Start() {
        initCore();
		maxDistance = 4.5f;
		nextPosition = Vector2.zero;
		// Get current scale
		currentScale = gameObject.transform.localScale;
		// If +x just fly to the right
		if (gameObject.transform.position.x >= 0) {
			// 
			direction = 1;
		// If -x just fly to the left and set localScale's x to negative -- mirror the bird's sprite
		} else {
			direction = -1;
			currentScale.x = -1f;
			gameObject.transform.localScale = currentScale;
		}
	}

	// Update is called once per frame
	void Update () {
        if (!GetCore().isPause && !GetCore().isOver && GetCore().isStart)
            Fly();
        if (!IsOutOfScreen())
            gameObject.SetActive(false);
    }

	// Override method from super class
	public override void Fly() {
		// If needed to be flipped, change flying direction and mirror the sprite
		if (canFlip ()) {
			direction *= -1;
			currentScale.x *= -1;
			gameObject.transform.localScale = currentScale;
		} 
		// Set x and y position based on sinusoidal equation
		position_x = gameObject.transform.position.x + (flyingSpeed * Time.deltaTime * direction);
		position_y = Mathf.Sin ( Mathf.Deg2Rad * position_x * 90 );
		// Set the position!
		setNextPosition (position_x, position_y);
	}

	// Is the distance that bird has traveled >= max distance?
	public bool canFlip() {
		return Mathf.Abs(gameObject.transform.position.x) >= maxDistance;
	}

	// Set game object's position
	private void setNextPosition(float x, float y) {
		nextPosition.x = x;
		nextPosition.y = y;
		gameObject.transform.position = nextPosition;
	}

}
