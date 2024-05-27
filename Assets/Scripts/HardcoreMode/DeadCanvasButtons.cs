using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadCanvasButtons : MonoBehaviour
{
    public void Retry()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            AudioManager.Instance.PlaySFX(FindObjectOfType<AudioPlayer>().MenuSound);
        }
        SceneManager.LoadScene("Game");
    }
    public void QuitToMenu()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            AudioManager.Instance.PlaySFX(FindObjectOfType<AudioPlayer>().MenuSound);
        }
        SceneManager.LoadScene("Start");
    }
}