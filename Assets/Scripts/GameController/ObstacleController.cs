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
    public GameObject kiteChulaPrototype;
    public GameObject kiteSnakePrototype;

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
    List<GameObject> kiteChulaPool;
    List<GameObject> snakePool;

    bool spawnEven;

	// Use this for initialization
	void Start () {
        BindingMainCamera();
        InitializeObjectPool();
	}
	
	// Update is called once per frame
	void Update () {
//        Debug.Log("You are at " + Utility.CalculatePositionInMeter(camera.transform.position.y));
        AutomaticSpawn();
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
        kiteChulaPool = new List<GameObject>();
        snakePool = new List<GameObject>();
    }

    GameObject SpawnObstacle(string type, float x,float y)
    {
        List<GameObject> selectPool = null;
        GameObject selectPrototype = null;
        Vector2 position = new Vector2(x, y);
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
        else if (type == "chula-kite")
        {
            selectPool = kiteChulaPool;
            selectPrototype = kiteChulaPrototype;
        }
        else if (type == "snake-kite")
        {
            selectPool = snakePool;
            selectPrototype = kiteSnakePrototype;
        }
        return PickUpFromPool(selectPool, selectPrototype, position);
    }

    GameObject PickUpFromPool(List<GameObject> pool, GameObject prototype, Vector2 position)
    {
        foreach (GameObject go in pool)
            if (!go.activeSelf)
            {
                go.transform.position = position;
                go.SetActive(true);
                return go;
            }
        GameObject gb = Instantiate(prototype, position, Quaternion.identity);
        pool.Add(gb);
        return gb;
    }

    void AutomaticSpawn()
    {
        float cam_y = camera.transform.position.y+4f;
        int position = Utility.CalculatePositionInMeter(cam_y);
        if (spawnEven)
        {
            if (position < 5)
            {
                spawnEven = false;
            }else if (position == 10)
            {
                spawnEven = false;
                SpawnObstacle("pigeon", -1f, cam_y).GetComponent<Obstacle>();
                SpawnObstacle("pigeon", -2f, cam_y);
            }
            else if (position == 20)
            {
                spawnEven = false;
                SpawnObstacle("drove", -3f, cam_y).GetComponent<Obstacle>();
                SpawnObstacle("gawow", -1f, cam_y).GetComponent<Obstacle>();
                SpawnObstacle("drove", -2f, cam_y).GetComponent<Obstacle>();
            }
            else if (position == 35)
            {
                spawnEven = false;
                SpawnObstacle("snake-kite", -3f, cam_y).GetComponent<Obstacle>();
            }
            else if (position == 50)
            {
                spawnEven = false;
                SpawnObstacle("drone", -3f, cam_y).GetComponent<Obstacle>();
            }
            else if (position == 75)
            {
                spawnEven = false;
                SpawnObstacle("thai-rocket", -2.8f, cam_y).GetComponent<Obstacle>();
            }
            else if (position == 95)
            {
                spawnEven = false;
                SpawnObstacle("lamp", -3f, cam_y).GetComponent<Obstacle>();
                SpawnObstacle("lamp", -2f, cam_y).GetComponent<Obstacle>();
                SpawnObstacle("lamp", -1f, cam_y).GetComponent<Obstacle>();
            }
            else if (position == 105)
            {
                spawnEven = false;
                SpawnObstacle("pigeon", -3f, cam_y).GetComponent<Obstacle>();
                SpawnObstacle("pigeon", -1f, cam_y).GetComponent<Obstacle>();
            }
            else if (position == 125)
            {
                spawnEven = false;
                SpawnObstacle("drone", -3f, cam_y).GetComponent<Obstacle>();
            }
            else if (position == 150)
            {
                spawnEven = false;
                SpawnObstacle("thai-rocket", -2.8f, cam_y).GetComponent<Obstacle>();
            }
            else if (position == 175)
            {
                spawnEven = false;
                SpawnObstacle("pigeon", -3f, cam_y).GetComponent<Obstacle>();
                SpawnObstacle("pigeon", -1f, cam_y).GetComponent<Obstacle>();
            }
        } else
        {
            if (position == 5)
            {
                spawnEven = true;
                SpawnObstacle("pigeon", 3f,cam_y);
            }else if (position == 15)
            {
                spawnEven = true;

                SpawnObstacle("pigeon", 3f,cam_y);
                SpawnObstacle("sparrow", 2f,cam_y);
                SpawnObstacle("sparrow", 1f,cam_y);
            }else if (position == 25)
            {
                spawnEven = true;
                SpawnObstacle("gawow", 3f,cam_y);
                SpawnObstacle("gawow", 1f,cam_y);
            }else if (position == 40)
            {
                spawnEven = true;
                SpawnObstacle("chula-kite", 3f, cam_y);
                SpawnObstacle("chula-kite", 1f, cam_y);
            }else if (position == 60)
            {
                spawnEven = true;
                SpawnObstacle("lamp", 3f, cam_y);
                SpawnObstacle("lamp", 1f, cam_y);
            }else if (position == 90)
            {
                spawnEven = true;
                SpawnObstacle("lamp", 3f, cam_y);
                SpawnObstacle("lamp", 1f, cam_y);
            }else if (position == 100)
            {
                spawnEven = true;
                SpawnObstacle("pigeon", 3f, cam_y);
                SpawnObstacle("pigeon", 1f, cam_y);
                SpawnObstacle("pigeon", 2f, cam_y);
            }else if (position == 120)
            {
                spawnEven = true;
                SpawnObstacle("drone", 3f, cam_y);
            }else if (position == 140)
            {
                spawnEven = true;
                SpawnObstacle("helicopter", 3f, cam_y);
            }else if (position == 170)
            {
                spawnEven = true;
                SpawnObstacle("pigeon", 3f, cam_y);
                SpawnObstacle("gawow", 2f, cam_y);
                SpawnObstacle("pigeon", 1f, cam_y);
            }else if (position == 180)
            {
                spawnEven = true;
                SpawnObstacle("helicopter", 3f, cam_y);
            }
        }
    }

}
