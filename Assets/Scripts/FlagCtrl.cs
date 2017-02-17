using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagCtrl : MonoBehaviour {

	// Physics of the flag
	private Rigidbody2D physic2D;

	// Scalar value of force to be added to flag's Rigidbody2D
	// Exposed on inspector
	public float forceMagnitude = 7.5f;

	private Rect leftScreen = new Rect(0, 0, Screen.width / 2, Screen.height*0.8f);
	private Rect rightScreen = new Rect(Screen.width / 2, 0, Screen.width, Screen.height*0.8f);

	public Vector2 currentVelocity;
	public float max_y_velocity;

    GameCore core;

    void Start()
    {
        core = GameObject.FindGameObjectWithTag("Core").GetComponent<GameCore>();
    }

	void Awake() {
		//Reference physic2D to flag's Rigidbody2D
		physic2D = GetComponent<Rigidbody2D> ();
		//Remove flag from physics simulation
		physic2D.Sleep ();
		max_y_velocity = 5f;
    }

	// Update is called once per frame
	void Update () {
		// Start Physics simulation and take user's inputs 
		// [Condition] Any button is pressed
		if (core.isStart&&!core.isPause&&!core.isOver) {

			// A or LeftArrow add force up and to the left of the flag
			if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow) || (Input.GetMouseButtonDown(0) && leftScreen.Contains(Input.mousePosition))) {
				physic2D.AddForce ((Vector2.up + Vector2.left) * forceMagnitude, ForceMode2D.Impulse);
			}
			// D or RightArrow add force up and to the right of the flag	
			if (Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.RightArrow) || (Input.GetMouseButtonDown(0) && rightScreen.Contains(Input.mousePosition))) {
				physic2D.AddForce ((Vector2.up + Vector2.right) * forceMagnitude, ForceMode2D.Impulse);
			}

			currentVelocity = physic2D.velocity;

			/*if (physic2D.velocity.y >= max_y_velocity) {
				print ("Exceeded max velocity. Clamping...");
			}*/


			currentVelocity.y = Mathf.Clamp (physic2D.velocity.y, -max_y_velocity, max_y_velocity);
			physic2D.velocity = currentVelocity;

		} else if (Input.anyKeyDown && !core.isStart) {
			core.isStart = true;
			physic2D.WakeUp ();
		} 

        if (core.isPause||!core.isStart||core.isOver)
        {
            physic2D.Sleep();
        }else
        {
            physic2D.WakeUp();
        }
	}

	void OnTriggerEnter2D (Collider2D other) {
		//        if (other.tag == "Win")
		//        print("You win");
		if (other.tag == "Obtacle") {
			print ("You got hit by a " + other.gameObject.name);
			//            print("Move to Play again scene");
			print ("Total time = " + core.time);
            core.isOver = true;
		} else {
			print ("Out of play area");
            core.isOver = true;
            print("Total time = " + core.time);
        }
    }
}
