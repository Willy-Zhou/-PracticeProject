using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public PauseMenu escpauseMenu; 
    //no need for this apparently

    //Initialize
    void Start(){

    }

    //Update called once per frame
    void Update () {
        //if esc is pressed, make pause menu active
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(!pauseMenu.activeSelf); //checks wether itself is true, if true sets to false.
            Time.timeScale = 1f;
        }
        //if pausemenu is true, set to false
        //if (pauseMenu.activeSelf)



    }




    [SerializeField] GameObject pauseMenu; //no idea what this does

    public void Pause() 
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home(int sceneID)
    {
        
        Time.timeScale = 1f; 
        SceneManager.LoadScene(sceneID);
    }



}

