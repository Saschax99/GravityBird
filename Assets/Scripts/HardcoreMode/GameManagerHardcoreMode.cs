using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerHardcoreMode : MonoBehaviour
{
    public GameObject DeadScreenCanvas, ScoreWhileAlive, Background;
    public Text DeadScreenScore, DeadScreenHighscore;
    bool only_Once = false;

    private void Start()
    {
        DeadScreenCanvas.SetActive(false);
    }

    private void Update()
    {
        if (FindObjectOfType<MovementHardcoreMode>().Player_dead)
        {
            StartCoroutine(DelayDead());
        }
    }
    IEnumerator DelayDead()
    {
        if (!only_Once)
        {
            only_Once = true;
            yield return new WaitForSeconds(.5f);
            DeadScreenCanvas.SetActive(true);
            ScoreWhileAlive.SetActive(false);
            DeadScreenScore.text = "Score: " + FindObjectOfType<ScoreHardcoreMode>().ScoreVal.ToString();
            DeadScreenHighscore.text = "Highscore: " + PlayerPrefs.GetFloat("ScoreHardcore", 0);
        }
    }
}
