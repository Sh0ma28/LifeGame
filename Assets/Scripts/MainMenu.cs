using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Scene nextScene = SceneManager.GetSceneAt(1);
        SceneManager.MoveGameObjectToScene(GameObject.Find("MainPreset"), nextScene);
    }

    public void ExitGame()
    {
        Debug.Log("gameOver");
        Application.Quit();
    }
}
