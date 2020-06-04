using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public PlayerController player;
    private ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().PlayLoop("run-loop");
        scoreManager = FindObjectOfType<ScoreManager>();
        scoreManager.scoreIncreasing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -8)
        {
            scoreManager.scoreIncreasing = false;
            PlayerPrefs.SetFloat("HighScore", scoreManager.highScoreCount);
            PlayerPrefs.SetFloat("Score", scoreManager.scoreCount);
            SceneManager.LoadScene("GameOver");
        }
    }
}
