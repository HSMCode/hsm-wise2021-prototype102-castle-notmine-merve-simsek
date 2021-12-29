using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    // set button that will let the player restart the game
    public Button restartButton;

    void Start()
    {
        // add listener script to restart button
        restartButton.onClick.AddListener(ReloadingScene);
    }


    public void ReloadingScene()
    {
        // reload the scene and unpause the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        Debug.Log("Reloaded Scene!");
    }







}
