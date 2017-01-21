using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleCtrl : MonoBehaviour {

	public GameObject flagAnchorPoint;
	public GameObject[] poleAnchorPoints;

	// Use this for initialization
	void Start () {
		StartCoroutine (drawStrings ());
	}
	
	// Update is called once per frame
	void Update () {
//		drawStrings ();
	}

//	void drawStrings() {
//		for (int i = 0; i < poleAnchorPoints.Length ; i++) {
////			LineRenderer lr = poleAnchorPoints[i].AddComponent <LineRenderer>();
//			GameObject line = new GameObject();
//			LineRenderer lr = line.AddComponent<LineRenderer> ();
//			lr.material = new Material (Shader.Find ("Sprites/Default"));
//			lr.startColor = new Color (224f, 224f, 224f);
//			lr.endColor = new Color (160f, 160f, 160f);
//			lr.startWidth = 0.025f;
//			lr.SetPositions ( new Vector3[2] { flagAnchorPoint.transform.position, poleAnchorPoints[i].transform.position } );
////			GameObject.DestroyObject(lr, 0.01f);
//			GameObject.DestroyObject(line, 0.0185f);
//		}
//	}

	IEnumerator drawStrings() {
		for (int i = 0; i < poleAnchorPoints.Length ; i++) {
			LineRenderer lr = poleAnchorPoints[i].AddComponent <LineRenderer>();
			lr.material = new Material (Shader.Find ("Sprites/Default"));
			lr.startColor = new Color (224f, 224f, 224f);
			lr.endColor = new Color (160f, 160f, 160f);
			lr.startWidth = 0.05f;
			lr.SetPositions ( new Vector3[2] { flagAnchorPoint.transform.position, poleAnchorPoints[i].transform.position } );
			GameObject.DestroyObject(lr, 0.02f);
		}
		yield return new WaitForSeconds (0.02f);
		yield return drawStrings();
	}
}
