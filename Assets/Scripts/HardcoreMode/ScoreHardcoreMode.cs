using UnityEngine;
using UnityEngine.UI;
// using CloudOnce;

public class ScoreHardcoreMode : MonoBehaviour
{
    public Text ScoreText;
    private float Multiplier = 0;

    public int ScoreVal { get { return Mathf.FloorToInt(Multiplier * 100); } }

    private void Update()
    {
        if (!FindObjectOfType<MovementHardcoreMode>().Player_dead)
        {
            Multiplier += Time.deltaTime;
            if (ScoreText.text != ScoreVal.ToString())
            {
                ScoreText.text = ScoreVal.ToString();
                if (PlayerPrefs.GetFloat("ScoreHardcore", 0) < ScoreVal)
                {
                    PlayerPrefs.SetFloat("ScoreHardcore", ScoreVal);
                    // Leaderboards.HardcoreHighscore.SubmitScore(ScoreVal);
                    StartNewHighscoreCheckpoint();
                }
                // if (ScoreVal >= 2500)
                // {
                // Achievements.ArchievementHardcore2500.Unlock();
                // }
                // if (ScoreVal >= 5000)
                // {
                // Achievements.ArchievementHardcore5000.Unlock();
                // }
                // if (ScoreVal >= 7500)
                // {
                // Achievements.ArchievementHardcore7500.Unlock();
                // }
                // if (ScoreVal >= 15000)
                // {
                // Achievements.ArchievementHardcore15000.Unlock();
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

