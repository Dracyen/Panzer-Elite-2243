using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{


    public static bool isPaused = false;

    public GameObject pauseMenuUI;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }


    
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }


    public void Play()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }

    public void levelSelected()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Sair Jogo");
    }
}
