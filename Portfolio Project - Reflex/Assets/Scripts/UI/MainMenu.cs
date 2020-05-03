using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject TitleScreenUI;
    public GameObject MainMenuUI;
    public GameObject SingleplayerUI;
    public GameObject MultiplayerUI;
    public GameObject ControlsUI;
    public GameObject SettingsUI;
    public GameObject AreYouSureQuitUI;

    bool viewingTitleScreen = true;

    public void DisableTitleScreen()
    {
        if(Input.GetKeyDown(KeyCode.KeypadEnter) && viewingTitleScreen == true)
        {
            TitleScreenUI.SetActive(false);
            viewingTitleScreen = false;
            MainMenuUI.SetActive(true);
            //swing the camera round
        }
    }

    public void SingleplayerSelect()
    {
        SingleplayerUI.SetActive(true);
        MainMenuUI.SetActive(false);
    }

    public void MultiplayerSelect()
    {
        MultiplayerUI.SetActive(true);
        MainMenuUI.SetActive(false);
    }

    public void DisplayControls()
    {
        ControlsUI.SetActive(true);
        MainMenuUI.SetActive(false);
    }

    public void DisplaySettings()
    {
        SettingsUI.SetActive(true);
        MainMenuUI.SetActive(false);
    }

    public void Back()
    {
        MainMenuUI.SetActive(true);
        TitleScreenUI.SetActive(false);
        ControlsUI.SetActive(false);
        SettingsUI.SetActive(false);
        SingleplayerUI.SetActive(false);
        MultiplayerUI.SetActive(false);
        AreYouSureQuitUI.SetActive(false);
    }

    public void DisplayAreYouSureQuitUI()
    {
        AreYouSureQuitUI.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Game...");
        Application.Quit();
    }
}
