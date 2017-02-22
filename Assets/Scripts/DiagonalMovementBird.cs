using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalMovementBird : Bird {

	// Target of the bird which in this context is the flag
//	public GameObject targetParent;

	public Vector3 start;
	public Vector3 target;

	// Direction that the bird is heading
	public Vector3 direction;

	// Modifier for the original speed of the bird
	public float speedModifier;

	public float distance;

	public float startTime;

	private Vector3 currentScale;

	// Find the vector for the direction of the bird and normalize it
	void Start () {
        initCore();
		GameObject levelManagerObj = GameObject.FindWithTag("LevelManager");

		speedModifier = 1.5f;

		startTime = Time.time;
		start = gameObject.transform.position;
		target = levelManagerObj.GetComponent<LevelManager> ().GetPlayer().transform.position;

		distance = Vector2.Distance (start, target);

		flyingSpeed = flyingSpeed * speedModifier;

		direction = target - start;
		direction.Normalize ();

//		maxDistance = Vector2.Distance (gameObject.transform.position, target.transform.position);

		currentScale = gameObject.transform.localScale;
		if (gameObject.transform.position.x >= 0) {
			currentScale.x = -1f;
			gameObject.transform.localScale = currentScale;
		}
	}
	
	// Fly awayyyyyyy
	void Update () {
		if (hasReachedTarget ()) {
//		if (!isWithinCircle ()) {
			setTarget();
			direction *= -1;
			currentScale.x *= -1;
			gameObject.transform.localScale = currentScale;
		}
        if (!GetCore().isPause && !GetCore().isOver && GetCore().isStart)
            Fly();
        if (!IsOutOfScreen())
            gameObject.SetActive(false);    
    }

	// Translate the bird 
	public override void Fly() {
		float fracDistance = (Time.time - startTime) * flyingSpeed / distance;
		gameObject.transform.position = Vector2.Lerp (start, target, fracDistance );
//		gameObject.transform.Translate (direction * Time.deltaTime * flyingSpeed);
	}

	public bool hasReachedTarget() {
		return Vector2.Distance(gameObject.transform.position, target) <= 0f;
	}

	public void setTarget() {
		startTime = Time.time;
		Vector3 temp = start;
		start = target;
		target = temp;
		distance = Vector2.Distance (start, target);
	}

}
