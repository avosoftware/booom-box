using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public ObstacleGenerator obstacleGenerator;
    public GameObject levelCompleteUI;
    public Score scoreUI;
    public float restartDelay = 1f;
    public float nextLevelDelay = 1f;

    bool hasEnded = false;
    bool loadNextLevel = false;
    float score = 0;

    private void Start()
    {
        score = 0;

        obstacleGenerator.GenerateMap(SceneManager.GetActiveScene().buildIndex);
    }

    private void Update()
    {
        scoreUI.score = (int)(score * 100);
    }

    private void FixedUpdate()
    {
        if (!loadNextLevel)
        {
            score += Time.deltaTime;
        }
    }

    public void EndGame()
    {
        if (!hasEnded)
        {
            hasEnded = true;
            Debug.Log("You died!");

            Invoke("RestartLevel", restartDelay);
        }
    }

    public void RestartLevel()
    {
        Debug.Log("Restarting level");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LevelComplete()
    {
        if (!loadNextLevel)
        {
            loadNextLevel = true;
            Debug.Log("Level completed");

            levelCompleteUI.SetActive(true);
        }
    }

    public void LoadNextLevel()
    {
        Debug.Log("Next level");

        loadNextLevel = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartGame()
    {
        Debug.Log("Start game");

        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        Debug.Log("Main menu");

        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit game");

        Application.Quit();
    }
}
