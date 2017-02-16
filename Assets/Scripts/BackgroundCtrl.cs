using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCtrl : MonoBehaviour {

	private bool hasLoadedNextBackground = false;
	public GameObject backgroundPrefab;
	private GameObject playerFlag;
//	private float[] levelHeights;
	private bool[] hasLoadedStage;
	public GameObject[] stagePrefabs;
	// Use this for initialization
	void Start () {
		playerFlag = FindObjectOfType<FlagCtrl> ().gameObject;
//		levelHeights = new float[] { 0f, 100f, 200f, 300f, 400f, 500f, 600f, 700f, 800f, 900f, 1000f };
		hasLoadedStage = new bool[] { false, false, false, false, false, false, false, false, false, false}; 
		StartCoroutine (LoadNextBackground ());
//		StartCoroutine(LoadNextStage());
	}
	
	// Update is called once per frame
//	void Update () {
//		
//	}

	IEnumerator LoadNextBackground() {
		if (playerFlag.gameObject.transform.position.y > gameObject.transform.position.y &&
		    !hasLoadedNextBackground) {
			hasLoadedNextBackground = true;
			float backgroundHeight = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
			Instantiate (backgroundPrefab, new Vector3 (gameObject.transform.position.x, 
														gameObject.transform.position.y + backgroundHeight, 
														gameObject.transform.position.z), Quaternion.identity); 
		}
		yield return new WaitForSeconds (0.2f);
		yield return LoadNextBackground ();
	}

//	IEnumerator LoadNextStage() {
//		if (playerFlag.transform.position.y >= levelHeights [1] && !hasLoadedStage [1]) {
//			hasLoadedStage [1] = true;
//			float backgroundHeight = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
//			Instantiate (stagePrefabs[1], new Vector3 (gameObject.transform.position.x, 
//				gameObject.transform.position.y + backgroundHeight,
//				gameObject.transform.position.z), Quaternion.identity);
////			Instantiate (stagePrefabs [1], null);
//		} else if (playerFlag.transform.position.y >= levelHeights [2] && !hasLoadedStage [2]) {
//			hasLoadedStage [2] = true;
//			float backgroundHeight = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
//			Instantiate (stagePrefabs[2], new Vector3 (gameObject.transform.position.x, 
//				gameObject.transform.position.y + backgroundHeight, 
//				gameObject.transform.position.z), Quaternion.identity);
////			Instantiate (stagePrefabs [2], null);
//		} else if (playerFlag.transform.position.y >= levelHeights [3] && !hasLoadedStage [3]) {
//			hasLoadedStage [3] = true;
//			float backgroundHeight = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
//			Instantiate (stagePrefabs[3], new Vector3 (gameObject.transform.position.x, 
//				gameObject.transform.position.y + backgroundHeight, 
//				gameObject.transform.position.z), Quaternion.identity);
//			Instantiate (stagePrefabs [3], null);
//		} else if (playerFlag.transform.position.y >= levelHeights [4] && !hasLoadedStage [4]) {
//			hasLoadedStage [4] = true;
//			float backgroundHeight = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
//			Instantiate (stagePrefabs[4], new Vector3 (gameObject.transform.position.x, 
//				gameObject.transform.position.y + backgroundHeight, 
//				gameObject.transform.position.z), Quaternion.identity);
////			Instantiate (stagePrefabs [4], null);
//		} else if (playerFlag.transform.position.y >= levelHeights [5] && !hasLoadedStage [5]) {
//			hasLoadedStage [5] = true;
//			float backgroundHeight = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
//			Instantiate (stagePrefabs[5], new Vector3 (gameObject.transform.position.x, 
//				gameObject.transform.position.y + backgroundHeight, 
//				gameObject.transform.position.z), Quaternion.identity);
////			Instantiate (stagePrefabs [5], null);
//		} else if (playerFlag.transform.position.y >= levelHeights [6] && !hasLoadedStage [6]) {
//			hasLoadedStage [6] = true;
//			float backgroundHeight = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
//			Instantiate (stagePrefabs[6], new Vector3 (gameObject.transform.position.x, 
//				gameObject.transform.position.y + backgroundHeight, 
//				gameObject.transform.position.z), Quaternion.identity);
////			Instantiate (stagePrefabs [6], null);
//		} else if (playerFlag.transform.position.y >= levelHeights [7] && !hasLoadedStage [7]) {
//			hasLoadedStage [7] = true;
//			float backgroundHeight = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
//			Instantiate (stagePrefabs[7], new Vector3 (gameObject.transform.position.x, 
//				gameObject.transform.position.y + backgroundHeight, 
//				gameObject.transform.position.z), Quaternion.identity);
//		} else if (playerFlag.transform.position.y >= levelHeights [8] && !hasLoadedStage [8]) {
//			hasLoadedStage [8] = true;
//			float backgroundHeight = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
//			Instantiate (stagePrefabs[8], new Vector3 (gameObject.transform.position.x, 
//				gameObject.transform.position.y + backgroundHeight, 
//				gameObject.transform.position.z), Quaternion.identity);
//		} else if (playerFlag.transform.position.y >= levelHeights [9] && !hasLoadedStage [9]) {
//			hasLoadedStage [9] = true;
//			float backgroundHeight = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
//			Instantiate (stagePrefabs[9], new Vector3 (gameObject.transform.position.x, 
//				gameObject.transform.position.y + backgroundHeight, 
//				gameObject.transform.position.z), Quaternion.identity);
//		} 
//		yield return new WaitForSeconds (0.2f);
//		yield return LoadNextStage ();
//	}

}
