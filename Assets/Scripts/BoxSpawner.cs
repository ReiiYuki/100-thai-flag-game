using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour {

	// Pool for spawning obstacles
	public GameObject[] obstaclePrefabs;
//	private float minSpawnX;
//	private float maxSpawnX;
	public GameObject leftSpawner;
	public GameObject rightSpawner;
	public float heightIntervalToSpawn;
	public float currentHeightInterval;
	private float previousHeight;
	public int spawnCallTime;
	public float timer;
//	public float timeInterval;

	// Use this for initialization
	void Start () {
		previousHeight = gameObject.transform.position.y;
//		minSpawnX = Camera.main.ViewportToWorldPoint (Vector3.zero).x;
//		maxSpawnX = Camera.main.ViewportToWorldPoint (Vector3.right).x;
//		print (string.Format ("Min:{0} , Max:{1}", minSpawnX, maxSpawnX));
//		timer = 0f;
//		StartCoroutine (spawnObstacle ());
	}
//	
	// Update is called once per frame
	void Update () {
		float currentHeight = gameObject.transform.position.y;
		currentHeightInterval += currentHeight - previousHeight;
		previousHeight = currentHeight;
		timer += Time.deltaTime;
		if (timer >= spawnCallTime & currentHeightInterval >= heightIntervalToSpawn) {
//			if () {
				timer = 0f;
				currentHeightInterval = 0f;
//				StartCoroutine (spawnObstacle ());
				spawnObstacle();
//			}
		}
	}

//	IEnumerator spawnObstacle() {
//		for (;;) {
//			Random.Range (0, 1);
//			Vector2 spawnPoint;
//			if (Random.Range (0, 1) == 1) {
//				spawnPoint = leftSpawner.transform.position;
//			} else {
//				spawnPoint = rightSpawner.transform.position;
//			}
//			// TO DO: Find a way to spawn obstacles based on height
//			int rand = Random.Range(0, obstaclePrefabs.Length - 1);
//			Instantiate (obstaclePrefabs[rand], spawnPoint, Quaternion.identity);
//			yield return null;
//		}
//	}

	void spawnObstacle() {
		Random.Range (0, 1);
		Vector2 spawnPoint;
		if (Random.Range (0, 1) == 1) {
			spawnPoint = leftSpawner.transform.position;
		} else {
			spawnPoint = rightSpawner.transform.position;
		}
		// TO DO: Find a way to spawn obstacles based on height
		int rand = Random.Range(0, obstaclePrefabs.Length - 1);
		Instantiate (obstaclePrefabs[rand], spawnPoint, Quaternion.identity);
	}
//
//	void OnDrawGizmosSelected() {
//		Gizmos.color = new Color(1, 0, 0, 0.5F);
//		Gizmos.DrawCube(transform.position, new Vector3(6, 1, 1));
//	}
}
