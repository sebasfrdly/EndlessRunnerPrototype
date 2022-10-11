using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;


    public float score;

    public bool useFixedUpdate;

    public float changePerSecond;

    //Start is called at first frame
    private void Update()
    {
        //changes this value over time
        if(!useFixedUpdate)
        {
            score += changePerSecond * Time.deltaTime;
        }

        scoreText.text = ((int)score).ToString();

    }

    //update is called every frame
    private void FixedUpdate()
    {
        if(useFixedUpdate)
        {
            score += changePerSecond * Time.deltaTime;
        }
    }

}
