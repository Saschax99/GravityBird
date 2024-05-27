using UnityEngine;
using UnityEngine.SceneManagement;
public class PreScene : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.LoadScene("Start");
    }
}
