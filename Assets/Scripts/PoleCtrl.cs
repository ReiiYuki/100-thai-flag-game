using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleCtrl : MonoBehaviour {

	public GameObject flagAnchorPoint;
	public GameObject[] poleAnchorPoints;
	private Material spriteMaterial;
	private Vector3[] linePositions;

	// Use this for initialization
	void Start () {
		linePositions = new Vector3[2];
		linePositions [1] = flagAnchorPoint.transform.position;
		spriteMaterial = new Material (Shader.Find ("Sprites/Default"));
	}
	
	// Update is called once per frame
	void Update () {
		drawStrings ();
	}

	void drawStrings() {
		for (int i = 0; i < poleAnchorPoints.Length ; i++) {
			GameObject line = new GameObject ();
			LineRenderer lr = line.AddComponent<LineRenderer> ();
			lr.material = spriteMaterial;
			lr.startColor = Color.white;
			lr.endColor = Color.white;
			lr.startWidth = 0.02f;
			linePositions [0] = poleAnchorPoints [i].transform.position;
			linePositions [1] = flagAnchorPoint.transform.position;
			lr.SetPositions (linePositions);

			GameObject.DestroyObject (line, Time.deltaTime);

		}
	}

}
