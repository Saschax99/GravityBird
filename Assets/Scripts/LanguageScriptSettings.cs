using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LanguageScriptSettings : MonoBehaviour
{
    public GameObject LanguageButton, SoundsButton, AboutButton, BackButton;

    string LanguageString = "Language English";
    string SoundsStringOn = "Sound On";
    string SoundsStringOff = "Sound Off";
    string AboutString = "About";
    string BackString = "Back";


    string LanguageStringGerman = "Sprache Deutsch";
    string SoundsStringGermanOn = "Sound An";
    string SoundsStringGermanOff = "Sound Aus";
    string AboutStringGerman = "Über";
    string BackStringGerman = "Zurück";

    private void Update()
    {
        if (PlayerPrefs.GetInt("Language", 1) == 1) // English
        {
            LanguageButton.GetComponent<Text>().text = LanguageString;
            AboutButton.GetComponent<Text>().text = AboutString;
            BackButton.GetComponent<Text>().text = BackString;

            if (PlayerPrefs.GetInt("Sounds", 1) == 1)
            {
                SoundsButton.GetComponent<Text>().text = SoundsStringOn;
            }
            else if (PlayerPrefs.GetInt("Sounds", 1) == 2)
            {
                SoundsButton.GetComponent<Text>().text = SoundsStringOff;
            }

        }
        else if (PlayerPrefs.GetInt("Language", 1) == 2)
        {
            LanguageButton.GetComponent<Text>().text = LanguageStringGerman;
            AboutButton.GetComponent<Text>().text = AboutStringGerman;
            BackButton.GetComponent<Text>().text = BackStringGerman;

            if (PlayerPrefs.GetInt("Sounds", 1) == 1)
            {
                SoundsButton.GetComponent<Text>().text = SoundsStringGermanOn;
            }
            else if (PlayerPrefs.GetInt("Sounds", 1) == 2)
            {
                SoundsButton.GetComponent<Text>().text = SoundsStringGermanOff;
            }
        }
    }

    public void ChangeLanguage()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            StartSoundMenu();
        }
        if (PlayerPrefs.GetInt("Language", 1) == 1)
        {
            PlayerPrefs.SetInt("Language", 2);
        }
        else if (PlayerPrefs.GetInt("Language", 1) == 2)
        {
            PlayerPrefs.SetInt("Language", 1);
        }
    }
    public void About()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            StartSoundMenu();
        }
        SceneManager.LoadScene("About");
    }
    public void Sound()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            // set off
            StartSoundMenu();
            PlayerPrefs.SetInt("Sounds", 2);
            AudioListener.pause = true;
            //FindObjectOfType<AudioManager>().PauseMusic();
        }
        else if (PlayerPrefs.GetInt("Sounds", 1) == 2)
        {
            // set on
            StartSoundMenu();
            PlayerPrefs.SetInt("Sounds", 1);
            AudioListener.pause = false;
            //FindObjectOfType<AudioManager>().UnPauseMusic();
        }
    }
    public void BackToMenu()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            StartSoundMenu();
        }
        SceneManager.LoadScene("Start");
    }
    private void StartSoundMenu()
    {
        AudioManager.Instance.PlaySFX(FindObjectOfType<AudioPlayer>().MenuSound);
    }
}
