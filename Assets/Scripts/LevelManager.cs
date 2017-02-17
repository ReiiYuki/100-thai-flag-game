using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	private GameObject player;
	private GameObject[] obstacles;

	// Use this for initialization
	void Start () {
		GetPlayer ();
		GetObstacles ();
	}

	public GameObject GetPlayer() {
		if (!player) {
			player = GameObject.FindWithTag ("Player");
			print ("Player found");
		} else {
			print ("Player Already found");
		}
		return player;
	}

	private GameObject[] GetObstacles() {
		if (obstacles == null || obstacles.Length == 0) {
			obstacles = GameObject.FindGameObjectsWithTag ("Obtacle");
			print ("Obstacles found " + obstacles.Length);
		}
		return obstacles;
	}

	// Update is called once per frame
//	void Update () {
//		if (player.transform.position.y >= 100f) {
//			
//		}
//	}

}
