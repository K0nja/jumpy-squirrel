using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public float scoreCount;
    public float highScoreCount;
    public float pointPerSecond;
    public bool scoreIncreasing;
    // Start is called before the first frame update
    void Start()
    {
        scoreCount = 0;
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
        else
        {
            highScoreCount = 0;
        }
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreIncreasing)
        {
            scoreCount += pointPerSecond * Time.deltaTime;
            scoreText.text = "Score: " + Mathf.Round(scoreCount);
            if (scoreCount > highScoreCount)
            {
                highScoreCount = scoreCount;
                highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);
                PlayerPrefs.SetFloat("HighScore", highScoreCount);
            }
        }
    }
}
