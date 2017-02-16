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

	// Find the vector for the direction of the bird and normalize it
	void Start () {
		GameObject levelManagerObj = GameObject.FindWithTag("LevelManager");
		target = levelManagerObj.GetComponent<LevelManager> ().GetPlayer();
		flyingSpeed = flyingSpeed * speedModifier;
		direction = target.transform.position - gameObject.transform.position;
		direction.Normalize ();
	}
	
	// Fly awayyyyyyy
	void Update () {
		Fly ();
	}

	// Translate the bird 
	public override void Fly() {
		gameObject.transform.Translate (direction * Time.deltaTime * flyingSpeed);
	}
}
