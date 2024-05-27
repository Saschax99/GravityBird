using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsHardcoreMode : MonoBehaviour
{
    public void Retry()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            AudioManager.Instance.PlaySFX(FindObjectOfType<AudioPlayer>().MenuSound);
        }
        SceneManager.LoadScene("HardcoreGame");
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
