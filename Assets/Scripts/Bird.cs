using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base class of birds
public class Bird : Obstacle {

	// Speed at which Bird flies
	protected float flyingSpeed = 1.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Fly ();
	}

	// Make the bird flies
	public virtual void Fly() {
		
	}
}
