using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject[] spawnPoints;
    public GameObject alien;

    public int maxAliensOnScreen;
    public int totalAliens;
    public float minSpawnTime;
    public float maxSpawnTime;
    public int aliensPerSpawn;

    private int aliensOnScreen = 0;
    private float generatedSpawnTime = 0;
    private float currentSpawnTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentSpawnTime += Time.deltaTime;
        if(currentSpawnTime > generatedSpawnTime)
        {
            currentSpawnTime = 0;
            generatedSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }

        if(aliensPerSpawn > 0 && aliensOnScreen < totalAliens)
        {
            List<int> previousSpawnLocations = new List<int>();
        }

        if(aliensPerSpawn > spawnPoints.Length)
        {
            aliensPerSpawn = spawnPoints.Length - 1;
        }
    }
}
