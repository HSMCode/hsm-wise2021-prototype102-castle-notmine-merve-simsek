using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
        {
             if (collision.gameObject.tag == "Lance")
             {
                 SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                 Debug.Log("Game Over Reload");
             }
        }
}
