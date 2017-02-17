using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalMovementBird : Bird {

	// Target of the bird which in this context is the flag
//	public GameObject targetParent;

	private GameObject target;

	// Direction that the bird is heading
	public Vector3 direction;

	// Modifier for the original speed of the bird
	public float speedModifier = 2f;

	public float maxDistance;

	private Vector3 currentScale;

	// Find the vector for the direction of the bird and normalize it
	void Start () {
        initCore();
		GameObject levelManagerObj = GameObject.FindWithTag("LevelManager");
		target = levelManagerObj.GetComponent<LevelManager> ().GetPlayer();

		flyingSpeed = flyingSpeed * speedModifier;

		direction = target.transform.position - gameObject.transform.position;
		direction.Normalize ();

		maxDistance = Vector2.Distance (gameObject.transform.position, target.transform.position);

		currentScale = gameObject.transform.localScale;
		if (gameObject.transform.position.x >= 0) {
			currentScale.x = -1f;
			gameObject.transform.localScale = currentScale;
		}
	}
	
	// Fly awayyyyyyy
	void Update () {
		if (!isWithinCircle ()) {
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
		gameObject.transform.Translate (direction * Time.deltaTime * flyingSpeed);
	}

	public bool isWithinCircle() {
		float x = target.transform.position.x;
		float y = target.transform.position.y;
		float a = gameObject.transform.position.x;
		float b = gameObject.transform.position.y;
		return Mathf.Pow ((x - a), 2) + Mathf.Pow ((y - b), 2) <= Mathf.Pow (maxDistance, 2);
	}
}
