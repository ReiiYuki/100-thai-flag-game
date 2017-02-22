using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	private GameObject player;
	private GameObject[] obstacles;
	private Camera mainCamera;

	// Use this for initialization
	void Start () {
		GetPlayer ();
		GetObstacles ();
		GetMainCamera ();
	}

	public GameObject GetPlayer() {
		if (!player) {
			player = GameObject.FindWithTag ("Player");
//			Debug.Log ("Player found");
		} else {
//			Debug.Log("Player Already found");
		}
		return player;
	}

	public GameObject[] GetObstacles() {
		if (obstacles == null || obstacles.Length == 0) {
			obstacles = GameObject.FindGameObjectsWithTag ("Obtacle");
//			Debug.Log("Obstacles found " + obstacles.Length);
		}
		return obstacles;
	}

	public Camera GetMainCamera() {
		if (!mainCamera) {
			mainCamera = Camera.main;
		} 
		return mainCamera;
	}

}
