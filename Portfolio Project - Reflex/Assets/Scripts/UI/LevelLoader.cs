using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public GameObject loadingScreenTip;
    public Slider slider;
    public TextMeshProUGUI progressText;
    private int RandomNum;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
        Time.timeScale = 1f;
        Pause_Menu.gameIsPaused = false;
    }

    public void DisplayRandomTip()
    {
        RandomNum = UnityEngine.Random.Range(0, 6);

        if (RandomNum == 0)
        {
            loadingScreenTip.GetComponent<TextMeshProUGUI>().text = "Tip: 111111111111111111111111111111111111111111111111";
        }
        else if (RandomNum == 1)
        {
            loadingScreenTip.GetComponent<TextMeshProUGUI>().text = "Fact: 222222222222222222222222222222222222222222222222";
        }
        else if (RandomNum == 2)
        {
            loadingScreenTip.GetComponent<TextMeshProUGUI>().text = "Tip: 333333333333333333333333333333333333333333333333";
        }
        else if (RandomNum == 3)
        {
            loadingScreenTip.GetComponent<TextMeshProUGUI>().text = "Fact: 444444444444444444444444444444444444444444444444";
        }
        else if (RandomNum == 4)
        {
            loadingScreenTip.GetComponent<TextMeshProUGUI>().text = "Tip: 555555555555555555555555555555555555555555555555";
        }
        else if (RandomNum == 5)
        {
            loadingScreenTip.GetComponent<TextMeshProUGUI>().text = "Fact: 666666666666666666666666666666666666666666666666";
        }
        else if (RandomNum == 6)
        {
            loadingScreenTip.GetComponent<TextMeshProUGUI>().text = "Tip: 777777777777777777777777777777777777777777777777";
        }
    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = "LOADING..." + (progress * 100f).ToString("0") + "%";
            yield return null;
        }
    }
}
