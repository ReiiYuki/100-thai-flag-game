using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusoidalMovementBird : Bird {

	public float position_x;
	public float position_y;

	// Update is called once per frame
	void Update () {
		Fly ();
	}

	public override void Fly() {
		position_x = gameObject.transform.position.x + (flyingSpeed * Time.deltaTime);
		position_y = Mathf.Sin ( Mathf.Deg2Rad * position_x * 90 );
		gameObject.transform.position = new Vector2 (position_x, position_y);
	}
}
