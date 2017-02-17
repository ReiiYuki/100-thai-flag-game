using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesktopPlatformTutorial : MonoBehaviour {
    public GameObject A, D, L, R;
    FlagMovement flag;
    ColorBlock color;
    ColorBlock colorSelect;

    // Use this for initialization
    void Start () {
        flag = GameObject.FindGameObjectWithTag("Player").GetComponent<FlagMovement>();
        color = ColorBlock.defaultColorBlock;
        colorSelect = A.GetComponent<Button>().colors;
        colorSelect.normalColor = Color.red;
    }
	
	// Update is called once per frame
	void Update () {
        if (flag.state == "l")
        {
            A.GetComponent<Button>().colors = colorSelect;
            L.GetComponent<Button>().colors = colorSelect;
            D.GetComponent<Button>().colors = color;
            R.GetComponent<Button>().colors = color;
        }
        else if (flag.state == "c")
        {
            A.GetComponent<Button>().colors = colorSelect;
            L.GetComponent<Button>().colors = colorSelect;
            D.GetComponent<Button>().colors = colorSelect;
            R.GetComponent<Button>().colors = colorSelect;
        }
        else if (flag.state == "r")
        {
            A.GetComponent<Button>().colors = color;
            L.GetComponent<Button>().colors = color;
            D.GetComponent<Button>().colors = colorSelect;
            R.GetComponent<Button>().colors = colorSelect;
        }

    }

}
