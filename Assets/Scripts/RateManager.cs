using UnityEngine;

public class RateManager : MonoBehaviour
{
    [SerializeField]
    private RateBoxButtons rateBox;

    public int countToRate = 0;

    [HideInInspector]
    private int PlayCount = 13;

    private void Start()
    {
        ClickPlay();
    }
    public void ClickPlay()
    {
        PlayerPrefs.SetInt("RateBox", PlayerPrefs.GetInt("RateBox", 0) + 1);
        if (PlayerPrefs.GetInt("RateBox", 0) % PlayCount == 0 && PlayerPrefs.GetInt("RateBoxDontShow", 0) != 1)
        {
            rateBox.gameObject.SetActive(true);
        }
    }
}
