using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AboutScript : MonoBehaviour
{
    public GameObject BackButton;

    string BackString = "Back";
    string BackStringGerman = "Zurück";

    private void Start()
    {
        if (PlayerPrefs.GetInt("Language", 1) == 1) // english
        {
            BackButton.GetComponent<Text>().text = BackString;
        }
        else if (PlayerPrefs.GetInt("Language", 1) == 2) // deutsch
        {
            BackButton.GetComponent<Text>().text = BackStringGerman;
        }
    }
    public void BackToSettings()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            AudioManager.Instance.PlaySFX(FindObjectOfType<AudioPlayer>().MenuSound);
        }
        SceneManager.LoadScene("Settings");
    }
}
