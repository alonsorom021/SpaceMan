using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    public Text coinText, scoreText, maxScoreText;
    
    private PlayerController controller;

    void Start()
    {
        controller = GameObject.Find("Player").
            GetComponent<PlayerController>();
    }

    void Update()
    {
        if(GameManager.sharedInstance.currentGameState == GameState.inGame)
        {
            int coins = GameManager.sharedInstance.collectedObject;
            float score = controller.GetTravelDistance();
            float maxScore = PlayerPrefs.GetFloat("maxscore", 0f);

            coinText.text = coins.ToString();
            scoreText.text = "Score: " + score.ToString("f1");
            maxScoreText.text = "MaxScore: " + maxScore.ToString("f1");
        }
    }
}