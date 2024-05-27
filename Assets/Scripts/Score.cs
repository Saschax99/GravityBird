using UnityEngine;
using UnityEngine.UI;
// using CloudOnce;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    private float Multiplier = 0;

    public int ScoreVal
    {
        get
        {
            return Mathf.FloorToInt(Multiplier * 100);
        }
    }

    private void Update()
    {
        if (!FindObjectOfType<Movement>().Player_dead)
        {
            Multiplier += Time.deltaTime;
            if (ScoreText.text != ScoreVal.ToString())
            {
                ScoreText.text = ScoreVal.ToString();
                if (PlayerPrefs.GetFloat("Score", 0) < ScoreVal)
                {
                    PlayerPrefs.SetFloat("Score", ScoreVal);
                    // Leaderboards.Highscore.SubmitScore(ScoreVal);
                    StartNewHighscoreCheckpoint();
                }

                // if (ScoreVal >= 2500 && !Achievements.Archievement2500.IsUnlocked)
                // {
                // Achievements.Archievement2500.Unlock();
                // }
                // if (ScoreVal >= 5000 && !Achievements.Archievement5000.IsUnlocked)
                // {
                // Achievements.Archievement5000.Unlock();
                // }
                // if (ScoreVal >= 7500 && !Achievements.Archievement7500.IsUnlocked)
                // {
                // Achievements.Archievement7500.Unlock();
                // Achievements.ArchievementHardcoreModeActivated.Unlock();
                // }
            }
        }
    }
    bool alreadystarted = false; // only once starting
    private void StartNewHighscoreCheckpoint()
    {
        if (!alreadystarted)
        {
            FindObjectOfType<NewHighscoreCheckpoint>().StartNewHighscoreWindow();
            alreadystarted = true;
        }
    }
}