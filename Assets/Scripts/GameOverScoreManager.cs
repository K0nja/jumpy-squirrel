using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("fall");
        scoreText.text = "Score: " + Mathf.Round(PlayerPrefs.GetFloat("Score"));
        highScoreText.text = "High Score: " + Mathf.Round(PlayerPrefs.GetFloat("HighScore"));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
