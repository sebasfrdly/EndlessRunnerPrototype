using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    int score = 0;
    int highScore = 0;

    //Start is called at first frame
    private void Start()
    {
        //putting text on the screen
        scoreText.text = score.ToString() + "POINTS";
        highScoreText.text = "HIGHSCORE" + highScore.ToString();
    }

    //update is called every frame
    private void Update()
    {
        
    }

}
