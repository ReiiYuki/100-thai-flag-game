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
        Debug.Log("You are at " + Utility.CalculatePositionInMeter(camera.transform.position.y));
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
        PickUpFromPool(selectPool, selectPrototype, position);
    }

    void PickUpFromPool(List<GameObject> pool, GameObject prototype, Vector2 position)
    {
        foreach (GameObject go in pool)
            if (!go.activeSelf)
            {
                go.transform.position = position;
                go.SetActive(true);
                return;
            }
        pool.Add(Instantiate(prototype, position, Quaternion.identity));
    }

    void AutomaticSpawn()
    {
        if (Utility.CalculatePositionInMeter(camera.transform.position.y) < 10 && spawnEven)
        {
            spawnEven = false;
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y)==10&&!spawnEven)
        {
            SpawnObstacle("pigeon", new Vector2(-2f, camera.transform.position.y));
            SpawnObstacle("sparrow", new Vector2(-2f, camera.transform.position.y+5f));
            SpawnObstacle("pigeon", new Vector2(-2f, camera.transform.position.y+7f));
            SpawnObstacle("pigeon", new Vector2(-2f, camera.transform.position.y+10f));
            SpawnObstacle("drove", new Vector2(-4f, camera.transform.position.y+10f));
            SpawnObstacle("pigeon", new Vector2(-6f, camera.transform.position.y+10f));
            SpawnObstacle("pigeon", new Vector2(-8f, camera.transform.position.y+10f));
            SpawnObstacle("gawow", new Vector2(-2f, camera.transform.position.y + 30f));
            SpawnObstacle("gawow", new Vector2(-2f, camera.transform.position.y + 40f));
            spawnEven = true;
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 20&& spawnEven)
        {
            SpawnObstacle("chula-kite", new Vector2(-2f, camera.transform.position.y));
            SpawnObstacle("snake-kite", new Vector2(-2f, camera.transform.position.y + 30f));
            spawnEven = false;
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 40&&!spawnEven)
        {
            SpawnObstacle("drone", new Vector2(-2f, camera.transform.position.y));
            SpawnObstacle("snake-kite", new Vector2(-2f, camera.transform.position.y + 30f));
            SpawnObstacle("pigeon", new Vector2(-2f, camera.transform.position.y+15));
            SpawnObstacle("pigeon", new Vector2(-2f, camera.transform.position.y+20));
            spawnEven = true;
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 60&& spawnEven)
        {
            SpawnObstacle("pigeon", new Vector2(-2f, camera.transform.position.y));
            SpawnObstacle("pigeon", new Vector2(-2f, camera.transform.position.y + 5f));
            SpawnObstacle("pigeon", new Vector2(-2f, camera.transform.position.y + 7f));
            SpawnObstacle("pigeon", new Vector2(-2f, camera.transform.position.y + 10f));
            SpawnObstacle("drove", new Vector2(-4f, camera.transform.position.y + 10f));
            SpawnObstacle("pigeon", new Vector2(-6f, camera.transform.position.y + 10f));
            SpawnObstacle("pigeon", new Vector2(-8f, camera.transform.position.y + 10f));
            SpawnObstacle("drove", new Vector2(-2f, camera.transform.position.y + 30f));
            SpawnObstacle("drove", new Vector2(-2f, camera.transform.position.y + 40f));
            spawnEven = false;
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 80&& !spawnEven)
        {
            SpawnObstacle("chula-kite", new Vector2(-2f, camera.transform.position.y));
            SpawnObstacle("drone", new Vector2(-2f, camera.transform.position.y+30f));
            SpawnObstacle("snake-kite", new Vector2(-2f, camera.transform.position.y + 50f));
            spawnEven = true;
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 100&& spawnEven)
        {
            SpawnObstacle("lamp", new Vector2(-2f, camera.transform.position.y));
            SpawnObstacle("lamp", new Vector2(-2f, camera.transform.position.y + 5f));
            SpawnObstacle("lamp", new Vector2(-2f, camera.transform.position.y + 10f));
            SpawnObstacle("lamp", new Vector2(-2f, camera.transform.position.y + 15f));
            SpawnObstacle("lamp", new Vector2(-4f, camera.transform.position.y + 20f));
            SpawnObstacle("lamp", new Vector2(-6f, camera.transform.position.y + 25f));
            SpawnObstacle("lamp", new Vector2(-8f, camera.transform.position.y + 35f));
            SpawnObstacle("lamp", new Vector2(-2f, camera.transform.position.y + 30f));
            SpawnObstacle("lamp", new Vector2(-2f, camera.transform.position.y + 40f));
            spawnEven = false;
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 120&& !spawnEven)
        {
            SpawnObstacle("pigeon", new Vector2(-2f, camera.transform.position.y));
            SpawnObstacle("pigeon", new Vector2(-2f, camera.transform.position.y + 3f));
            SpawnObstacle("pigeon", new Vector2(-2f, camera.transform.position.y + 7f));
            SpawnObstacle("pigeon", new Vector2(-2f, camera.transform.position.y + 11f));
            SpawnObstacle("drove", new Vector2(-4f, camera.transform.position.y + 20f));
            SpawnObstacle("drove", new Vector2(-6f, camera.transform.position.y + 40f));
            SpawnObstacle("drove", new Vector2(-8f, camera.transform.position.y + 20f));
            SpawnObstacle("drove", new Vector2(-2f, camera.transform.position.y + 30f));
            SpawnObstacle("drove", new Vector2(-2f, camera.transform.position.y + 35f));
            spawnEven = true;
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 140&& spawnEven)
        {
            SpawnObstacle("lamp", new Vector2(-2f, camera.transform.position.y));
            SpawnObstacle("lamp", new Vector2(-2f, camera.transform.position.y + 5f));
            SpawnObstacle("lamp", new Vector2(-2f, camera.transform.position.y + 15f));
            SpawnObstacle("lamp", new Vector2(-4f, camera.transform.position.y + 20f));
            SpawnObstacle("lamp", new Vector2(-6f, camera.transform.position.y + 25f));
            SpawnObstacle("lamp", new Vector2(-8f, camera.transform.position.y + 35f));
            SpawnObstacle("lamp", new Vector2(-2f, camera.transform.position.y + 30f));
            SpawnObstacle("lamp", new Vector2(-2f, camera.transform.position.y + 40f));
            spawnEven = false;
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 160&& !spawnEven)
        {
            //drove
            //sparrow
            //pigeon
            spawnEven = true;
        }
        else if (Utility.CalculatePositionInMeter(camera.transform.position.y) == 180 && spawnEven)
        {
            //drove
            //sparrow
            //pigeon
            spawnEven = false;
        }
    }

}
