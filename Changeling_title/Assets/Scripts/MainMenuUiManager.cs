using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUiManager : MonoBehaviour
{
    private bool settingsOpen; //this will lock the user out of the behind buttons so we don't run into any overlapping menu issues.
    public void StartGame() 
    {
        //Start the next scene from there we will load the user's save data.
        SceneManager.LoadScene("HubScene");
    }

    public void OpenSettings() 
    {
        //Open the settings menu and lock this UI
    }

    public void QuitGame() 
    {
        //Because this is a main menu quit function we don't need to confirm save data saving as we'll do that on return to main menu
        Application.Quit();
    }
}
