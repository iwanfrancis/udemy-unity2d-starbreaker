using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    // Cached references
    private GameSession gameSession;

    private void Start() {
        gameSession = FindObjectOfType<GameSession>();
    }

    public void LoadNextScene() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene() {
        gameSession.ResetGame();
        SceneManager.LoadScene(0);
    }

    public void QuitGame() {
        Application.Quit();
    }

}
