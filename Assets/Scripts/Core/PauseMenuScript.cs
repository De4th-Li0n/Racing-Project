using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;    

    public static bool GameisPause = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {        
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameisPause = true;
        AudioListener.volume = 0f;
    }

    public void Resume()
    {        
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameisPause = false;
        AudioListener.volume = 1f;
    }
    public void Home(int sceneID)
    {        
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
        AudioListener.volume = 1f;
    }
    public void QuitGame()
    {        
        Application.Quit();
        AudioListener.volume = 1f;
    }
}
