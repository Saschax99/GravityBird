using UnityEngine;
using UnityEngine.UI;

public class NewHighscoreCheckpoint : MonoBehaviour
{
    public GameObject HighscoreCheckpoint;

    string NewHighScoreWindowString = "New Highscore!";

    string NewHighScoreWindowStringGerman = "neuer Highscore!";

    public void StartNewHighscoreWindow()
    {
        if (PlayerPrefs.GetInt("Language", 1) == 1) // english
        {
            HighscoreCheckpoint.GetComponent<Text>().text = NewHighScoreWindowString;
        }
        else if (PlayerPrefs.GetInt("Language", 1) == 2) // german
        {
            HighscoreCheckpoint.GetComponent<Text>().text = NewHighScoreWindowStringGerman;
        }
        HighscoreCheckpoint.SetActive(true);
        Invoke("stopCheckpoint", 1.75f);
    }
    private void stopCheckpoint()
    {
        HighscoreCheckpoint.SetActive(false);
    }
}