using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePlatformTutorial : MonoBehaviour {

    public GameObject L, R;
    FlagMovement flag;

    // Use this for initialization
    void Start()
    {
        flag = GameObject.FindGameObjectWithTag("Player").GetComponent<FlagMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flag.state == "l")
        {
            L.SetActive(true);
            R.SetActive(false);
        }
        else if (flag.state == "c")
        {
            L.SetActive(true);
            R.SetActive(true);
        }
        else if (flag.state == "r")
        {
            L.SetActive(false);
            R.SetActive(true);
        }

    }
}
