using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMaker : MonoBehaviour {

    public GameObject cloud;

	// Use this for initialization
	void Start () {
        GenerateCloud();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateCloud()
    {
        for (int i = 20; i <= 190; i += Random.Range(10, 50))
        {
            bool isCreated = Mathf.Round(Random.Range(0, 2)) == 1;
            if (isCreated)
            {
                Debug.Log(i);
                Instantiate(cloud, new Vector2(-2.5f, i * 2f), Quaternion.identity);
                Instantiate(cloud, new Vector2(2.5f, i * 2f), Quaternion.identity);
            }
        }
    }
}
