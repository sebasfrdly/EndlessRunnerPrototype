using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    public GameObject cloud;
    public GameObject enemy;

    //changes the amount of enemies and/or clouds
    public int cloudAmount;
    public int enemyAmount;
    //Made to space things out in the array
    public float cloudSpacing;
    public float enemySpacing;

    //variables for the enmy array
    GameObject[] enemyArray;

    //setting up the cloud Arrays
    GameObject[] cloudArray;
    [HideInInspector]public Vector3 spawnPositions; //this is just to spawn things at the edge of the screen
    // Start is called before the first frame update
    void Start()
    {
        spawnPositions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width + 1f, Screen.height , Camera.main.transform.position.z));
        //defines my two arrays for the spawnable objects
        cloudArray = new GameObject[cloudAmount];
        enemyArray = new GameObject[enemyAmount];
    }

    // Update is called once per frame
    void Update()
    {
        SpawnClouds();
        SpawnEnemies();
    }

    //this spawns all of the clouds within the array
    private GameObject[] SpawnClouds()
    {
        
        
        //for loop that will create the clouds in the background
        for(int i = 0; i < cloudArray.Length; i++)
        {
            cloudSpacing = Random.Range(0, 3.3f);
            if (cloudArray[i] == null)
            {
                cloudArray[i] = GameObject.Instantiate(cloud);
                cloudArray[i].transform.position = new Vector3(spawnPositions.x + cloudSpacing * i, Random.Range(1.3f,3.7f));
            }
        }

        return cloudArray;

    }

    private GameObject[] SpawnEnemies()
    {
        //for loop that will create the clouds in the background
        for (int i = 0; i < enemyArray.Length; i++)
        {
            enemySpacing = Random.Range(4, 6.3f);
            if (enemyArray[i] == null)
            {
                enemyArray[i] = GameObject.Instantiate(enemy);
                enemyArray[i].transform.position = new Vector3(spawnPositions.x + enemySpacing * i, Random.Range(0.5f, -2.5f));
            }
        }

        return enemyArray;
    }
    
 }
