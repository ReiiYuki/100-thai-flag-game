using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour {
    public InputField nameField;
	// Use this for initialization
	void Start () {
        nameField.onEndEdit.AddListener(delegate { SubmitName(); });
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void SubmitName()
    {
        Debug.Log(nameField.text);
    }
}
