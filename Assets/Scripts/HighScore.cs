using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text HighScoreText, HardcoreScoreText;

    private void Update()
    {
        if (HighScoreText.text != PlayerPrefs.GetFloat("Score").ToString())
        {
            HighScoreText.text = "Highscore: " + PlayerPrefs.GetFloat("Score").ToString();
        }
        if (HardcoreScoreText.text != PlayerPrefs.GetFloat("ScoreHardcore").ToString())
        {
            HardcoreScoreText.text = "Hardcore Score: " + PlayerPrefs.GetFloat("ScoreHardcore").ToString();
        }
    }
}
