using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFading : MonoBehaviour {

	public SpriteRenderer spriteRenderer;
	public float fadeSpeed = 0.25f;

	float alpha = 0.0f;
	int fadeDir = 1;

	public string name;

	public GameObject nameText;

	private TextMesh nameMesh;

	// Use this for initialization
	void Start () {
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		nameMesh = nameText.GetComponent<TextMesh> ();
		nameMesh.text = name;
		nameMesh.color = Color.clear;
	}
	
	// Update is called once per frame
	void Update () {
		if (isVisible ()) {
			alpha += fadeDir * fadeSpeed * Time.deltaTime;
			alpha = Mathf.Clamp01 (alpha);
			spriteRenderer.color = new Color (spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, alpha);
			nameMesh.color = new Color (spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, alpha);
		
		} else {
			fadeDir *= -1;
			fadeSpeed = 0.15f;
		}
//		if (alpha >= 1) {
//		}
	}

	bool isVisible() {
		return gameObject.GetComponent<SpriteRenderer> ().isVisible;
	}

//	float BeginFade(int direction) {
//		fadeDir = direction;
//		return (fadeSpeed);
//	}

}
