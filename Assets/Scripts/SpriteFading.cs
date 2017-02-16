using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFading : MonoBehaviour {

	public SpriteRenderer spriteRenderer;
	public float fadeSpeed = 0.25f;

	float alpha = 0.0f;
	int fadeDir = 1;

	// Use this for initialization
	void Start () {
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		alpha += fadeDir * fadeSpeed * Time.deltaTime;
		alpha = Mathf.Clamp01(alpha);
		spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, alpha);
	}

	float BeginFade(int direction) {
		fadeDir = direction;
		return (fadeSpeed);
	}

}
