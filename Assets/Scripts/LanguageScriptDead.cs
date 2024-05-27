using UnityEngine;
using UnityEngine.UI;

public class LanguageScriptDead : MonoBehaviour
{
    public GameObject RetryButton, QuitButton;

    string RetryString = "Retry";
    string QuitString = "Quit";

    string RetryStringGerman = "Wiederholen";
    string QuitStringGerman = "Verlassen";

    void Start()
    {
        if (PlayerPrefs.GetInt("Language", 1) == 1) // english
        {
            RetryButton.GetComponent<Text>().text = RetryString;
            QuitButton.GetComponent<Text>().text = QuitString;
        }
        else if (PlayerPrefs.GetInt("Language", 1) == 2) // german
        {
            RetryButton.GetComponent<Text>().text = RetryStringGerman;
            QuitButton.GetComponent<Text>().text = QuitStringGerman;
        }
    }
}