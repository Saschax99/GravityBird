using UnityEngine;

public class RateBoxButtons : MonoBehaviour
{
    public void NoThanks()
    {
        AudioManager.Instance.PlaySFX(FindObjectOfType<AudioPlayer>().MenuSound);
        PlayerPrefs.SetInt("RateBoxDontShow", 1); // setting rateboxdontshow to true so no rate game comes out
        gameObject.SetActive(false);
    }
    public void Later()
    {
        AudioManager.Instance.PlaySFX(FindObjectOfType<AudioPlayer>().MenuSound);
        gameObject.SetActive(false);
    }
    public void RateNow()
    {
        AudioManager.Instance.PlaySFX(FindObjectOfType<AudioPlayer>().MenuSound);
#if UNITY_ANDROID
        Application.OpenURL("market://details?id=com.onemanpublisher.TapToLive");
#elif UNITY_IOS
        Application.OpenURL("https://apps.apple.com/us/app/the-real-gravity-bird/id1514182670?l=de#?platform=iphone");
#endif
        PlayerPrefs.SetInt("RateBoxDontShow", 1); // setting rateboxdontshow to true so no rate game comes out
        gameObject.SetActive(false);
    }
}
