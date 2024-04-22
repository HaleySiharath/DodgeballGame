using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    void Update() {
        if(Input.GetKeyDown(KeyCode.E)) {
            print("Pressed E");
            if(!pauseMenu.activeSelf) {
                Pause();
            }else if(pauseMenu.activeSelf) {
                Resume();
            }
        }
    }
    public void Pause() {  
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home(int sceneID) {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
