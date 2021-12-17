using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{

    void Update()
    {
        //press R to Reload the Scene
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadingScene();
        }
    }


    void ReloadingScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Reloaded Scene!");
    }







}
