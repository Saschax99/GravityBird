using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button Start_Button, Hardcore_Button;
    public GameObject Hardcore_Score;
    public GameObject BackgroundVogel, BackgroundPicture;
    public Sprite RedEyedVogel, BackgroundHellPicture, NormalVogel, BackgroundNormal;
    private void Start()
    {
        if (PlayerPrefs.GetFloat("Score",0) >= 7500)
        {
            Hardcore_Button.interactable = true;
            Hardcore_Button.GetComponent<Text>().color = Color.white;

            Hardcore_Score.SetActive(true);
        }
        else
        {

            Hardcore_Button.interactable = false;
            Hardcore_Button.GetComponent<Text>().color = Color.gray;

            Hardcore_Score.SetActive(false);
        }
        if (PlayerPrefs.GetInt("HardcoreMode", 0) == 1)
        {
            Start_Button.GetComponentInChildren<Text>().text = "HardcoreMode";
            BackgroundVogel.GetComponent<SpriteRenderer>().sprite = RedEyedVogel;
            BackgroundPicture.GetComponent<SpriteRenderer>().sprite = BackgroundHellPicture;
        }
        else
        {
            Start_Button.GetComponentInChildren<Text>().text = "Start";
            BackgroundVogel.GetComponent<SpriteRenderer>().sprite = NormalVogel;
            BackgroundPicture.GetComponent<SpriteRenderer>().sprite = BackgroundNormal;
        }
    }
    public void StartGame()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            StartMenuSound();
        }
        if (PlayerPrefs.GetInt("HardcoreMode", 0) == 1)
        {
            SceneManager.LoadScene("HardcoreGame");
        }
        else
        {
            SceneManager.LoadScene("Game");
        }
    }
    public void Retry()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            StartMenuSound();
        }
        SceneManager.LoadScene("Game");
    }
    public void QuitToMenu()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            StartMenuSound();
        }
        SceneManager.LoadScene("Start");
    }

    public void HardcoreMode()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            StartMenuSound();
        }

        if (PlayerPrefs.GetInt("HardcoreMode",0) == 0)
        {
            PlayerPrefs.SetInt("HardcoreMode", 1);

            if (PlayerPrefs.GetInt("Language", 1) == 1)
            {
                Start_Button.GetComponentInChildren<Text>().text = "Start Hardcore";
            }
            else if (PlayerPrefs.GetInt("Language", 1) == 2)
            {
                Start_Button.GetComponentInChildren<Text>().text = "Starte Hardcore";
            }
            BackgroundVogel.GetComponent<SpriteRenderer>().sprite = RedEyedVogel;
            BackgroundPicture.GetComponent<SpriteRenderer>().sprite = BackgroundHellPicture;
        }
        else if (PlayerPrefs.GetInt("HardcoreMode", 0) == 1)
        {
            PlayerPrefs.SetInt("HardcoreMode", 0);

            if (PlayerPrefs.GetInt("Language", 1) == 1)
            {
                Start_Button.GetComponentInChildren<Text>().text = "Start";
            }
            else if (PlayerPrefs.GetInt("Language", 1) == 2)
            {
                Start_Button.GetComponentInChildren<Text>().text = "Starten";
            }
            BackgroundVogel.GetComponent<SpriteRenderer>().sprite = NormalVogel;
            BackgroundPicture.GetComponent<SpriteRenderer>().sprite = BackgroundNormal;
        }
    }
    public void Settings()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            StartMenuSound();
        }

        SceneManager.LoadScene("Settings");
    }
    public void StartMenuSound()
    {
        AudioManager.Instance.PlaySFX(FindObjectOfType<AudioPlayer>().MenuSound);
    }
}