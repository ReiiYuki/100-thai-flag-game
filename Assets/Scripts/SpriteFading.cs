using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFading : MonoBehaviour {

	public SpriteRenderer spriteRenderer;
	public float fadeSpeed = 0.4f;

	float alpha = 0.0f;
	int fadeDir = 1;

	public GameObject nameText;

	private TextMesh nameMesh;

	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindWithTag ("LevelManager").GetComponent<LevelManager>();
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		nameMesh = nameText.GetComponent<TextMesh> ();
		setColor ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isVisibleByCamera ()) {
			print (name + " is visible by camera ");
			alpha += fadeDir * fadeSpeed * Time.deltaTime;
			alpha = Mathf.Clamp01 (alpha);
			setColor ();
		} 
//		else {
//			fadeDir *= -1;
//			fadeSpeed = 0.3f;
//		}
//		if (alpha >= 1) {
//		}
	}

	bool isVisibleByCamera() {
		Vector3 viewportPoint = levelManager.GetMainCamera().WorldToViewportPoint( gameObject.transform.position );
		return ( viewportPoint.x > 0 & viewportPoint.x < 1) & ( viewportPoint.y > 0 & viewportPoint.y < 1 );
	}

//	float BeginFade(int direction) {
//		fadeDir = direction;
//		return (fadeSpeed);
//	}

	private void setColor() {
		spriteRenderer.color = new Color (spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, alpha);
		nameMesh.color = new Color (spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, alpha);
	}

}
