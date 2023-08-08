using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool hasGameEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUiBox;

    public void GameOver ()
    {
        if (!hasGameEnded)
        {
            hasGameEnded = true;
            Debug.Log("Game Over!!");
            Invoke("Restart", restartDelay);
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel ()
    {
        Debug.Log("Level Completed");
        completeLevelUiBox.SetActive(true);
    }
}
