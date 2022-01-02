using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // set gameover UI element and final score UI element
    public GameObject gameOverUI;
    public TMP_Text gameOverInformation;

    void Start() {
        gameOverUI.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Lance")
            {
                /* 
                - stop time when colliding
                - get final score from score script
                - change information text to display the score
                - activate gameover UI elements
                */
                Time.timeScale = 0;

                Score finalScore = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
                gameOverInformation.text = "Congratulations, Knight, you managed to achieve " + finalScore.score + " point(s) in the tournament!";

                gameOverUI.SetActive(true);
            }
        }
}
