using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {

    public GameObject pigeonPrototype;
    public GameObject drovePrototype;
    public GameObject sparrowPrototype;
    public GameObject gawowPrototype;
    public GameObject dronePrototype;
    public GameObject lampPrototype;
    public GameObject thaiRocketPrototype;
    public GameObject helicopterPrototype;
    public GameObject hotBolloonPrototype;
    public GameObject knifeChulaPrototype;
    public GameObject knifeSnakePrototype;

    Camera camera;

    List<GameObject> pigeonPool;
    List<GameObject> drovePool;
    List<GameObject> sparrowPool;
    List<GameObject> gawowPool;
    List<GameObject> dronePool;
    List<GameObject> lampPool;
    List<GameObject> thaiRocketPool;
    List<GameObject> helicopterPool;
    List<GameObject> hotBolloonPool;
    List<GameObject> knifeChulaPool;
    List<GameObject> snakePool;

	// Use this for initialization
	void Start () {
        BindingMainCamera();
        InitializeObjectPool();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void BindingMainCamera()
    {
        camera = Camera.main;
    }

    void InitializeObjectPool()
    {
        pigeonPool = new List<GameObject>();
        drovePool = new List<GameObject>();
        sparrowPool = new List<GameObject>();
        gawowPool = new List<GameObject>();
        dronePool = new List<GameObject>();
        lampPool = new List<GameObject>();
        thaiRocketPool = new List<GameObject>();
        helicopterPool = new List<GameObject>();
        hotBolloonPool = new List<GameObject>();
        knifeChulaPool = new List<GameObject>();
        snakePool = new List<GameObject>();
    }

    void SpawnObstacle(string type, Vector2 position)
    {
        List<GameObject> selectPool = null;
        GameObject selectPrototype = null; 
        if (type == "drove")
        {
            selectPool = drovePool;
            selectPrototype = drovePrototype;
        }
        else if (type == "pigeon")
        {
            selectPool = pigeonPool;
            selectPrototype = pigeonPrototype;
        }
        else if (type == "sparrow")
        {
            selectPool = sparrowPool;
            selectPrototype = sparrowPrototype;
        }
        else if (type == "gawow")
        {
            selectPool = gawowPool;
            selectPrototype = gawowPrototype;
        }
        else if (type == "drone")
        {
            selectPool = dronePool;
            selectPrototype = dronePrototype;
        }
        else if (type == "lamp")
        {
            selectPool = lampPool;
            selectPrototype = lampPrototype;
        }
        else if (type == "thai-rocket")
        {
            selectPool = thaiRocketPool;
            selectPrototype = thaiRocketPrototype;
        }
        else if (type == "hot-balloon")
        {
            selectPool = hotBolloonPool;
            selectPrototype = hotBolloonPrototype;
        }
        else if (type == "helicopter")
        {
            selectPool = helicopterPool;
            selectPrototype = helicopterPrototype;
        }
        else if (type == "chula-knife")
        {
            selectPool = knifeChulaPool;
            selectPrototype = knifeChulaPrototype;
        }
        else if (type == "snake-knife")
        {
            selectPool = snakePool;
            selectPrototype = knifeSnakePrototype;
        }
        PickUpFromPool(selectPool, selectPrototype, position);
    }

    void PickUpFromPool(List<GameObject> pool, GameObject prototype, Vector2 position)
    {
        foreach (GameObject go in pool)
            if (!go.activeSelf)
            {
                go.transform.position = position
                go.SetActive(true);
                return;
            }
        pool.Add(Instantiate(prototype, position, Quaternion.identity));
    }

    void AutomaticSpawn()
    {
        if (Utility.CalculatePositionInMeter(camera.transform.position.y)==10)
        {
            SpawnObstacle("pigeon", new Vector2(-4f, camera.transform.position.y));
            SpawnObstacle("sparrow", new Vector2(4f, camera.transform.position.y+5f));
            SpawnObstacle("pigeon", new Vector2(-4f, camera.transform.position.y+7f));
            SpawnObstacle("pigeon", new Vector2(-4f, camera.transform.position.y+10f));
            SpawnObstacle("drove", new Vector2(-8f, camera.transform.position.y+10f));
            SpawnObstacle("pigeon", new Vector2(-12f, camera.transform.position.y+10f));
            SpawnObstacle("pigeon", new Vector2(-15f, camera.transform.position.y+10f));
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 20)
        {
            //drove
            //sparrow
            //pigeon
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 40)
        {
            //drove
            //sparrow
            //pigeon
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 60)
        {
            //drove
            //sparrow
            //pigeon
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 80)
        {
            //drove
            //sparrow
            //pigeon
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 100)
        {
            //drove
            //sparrow
            //pigeon
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 120)
        {
            //drove
            //sparrow
            //pigeon
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 140)
        {
            //drove
            //sparrow
            //pigeon
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 160)
        {
            //drove
            //sparrow
            //pigeon
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 180)
        {
            //drove
            //sparrow
            //pigeon
        }
    }

}
