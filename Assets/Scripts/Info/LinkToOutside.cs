using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LinkToOutside : MonoBehaviour {

    public string url;

    void OnMouseDown()
    {
        Application.OpenURL(url);
    }
}
