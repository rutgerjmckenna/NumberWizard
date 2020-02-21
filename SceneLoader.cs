using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadNextScene() 
    {
        int currentSceneIndex = SceneLoaderManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    //We can now quit the game with the button in unity which calls the
    //quit method on the application
    public void QuitGame()
    {
        Application.Quit();
    }
}