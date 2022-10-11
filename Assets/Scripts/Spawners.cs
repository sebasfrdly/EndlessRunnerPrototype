using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    public GameObject cloud;
    public GameObject enemy;
    public int cloudAmount;

    public Vector3 cloudPositions;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpawnClouds();
    }

    //this spawns all of the clouds within the array
    private GameObject[] SpawnClouds()
    {
        GameObject[] cloudArray = new GameObject[cloudAmount];
        
        //for loop that will create the clouds in the background
        for(int i = 0; i < cloudArray.Length; i++)
        {
            //
            if(cloudArray[i] == null)
            {
                cloudArray[i] = GameObject.Instantiate(cloud);
            }

            else
            {
                return null;
            }
        }


        return null;
    }
    
 }
