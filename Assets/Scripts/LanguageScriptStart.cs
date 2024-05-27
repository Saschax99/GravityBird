using UnityEngine;
using UnityEngine.UI;

public class LanguageScriptStart : MonoBehaviour
{
    public GameObject StartButton, LeaderboardButton, HardcoreButton, SettingsButton, GravityScaleText,
        RateUs, RateContent, RateNothanks, RateLater, RateNow;

    string StartString = "Start";
    string LeaderboardString = "Leaderboard";
    string HardcoreModeString = "Hardcore Mode";
    string SettingsString = "Settings";
    string GravityScaleString = "Watch out for the Gravityscale!";

    string RateUsString = "Rate us!";
    string RateGameContentString = "if you enjoy playing, please take a moment to rate.\nThanks for your support!";
    string RateGameNoThanks = "No Thanks";
    string RateGameLater = "Later";
    string RateGameRateNow = "Rate Now";


    string StartStringGerman = "Starten";
    string LeaderboardStringGerman = "Rangliste";
    string HardcoreModeStringGerman = "Hardcore Modus";
    string SettingsStringGerman = "Einstellungen";
    string GravityScaleStringGerman = "Achte auf die Schwerkraft-Skala!";

    string RateUsStringGerman = "Bewerte uns!";
    string RateGameContentStringGerman = "Wenn dir das spielen Spaß macht, nimm dir bitte einen Moment Zeit, um die App zu bewerten\nDanke für deine Unterstützung!";
    string RateGameNoThanksGerman = "Nein Danke";
    string RateGameLaterGerman = "Später";
    string RateGameRateNowGerman = "Bewerte jetzt";

    private void Start()
    {
        if (PlayerPrefs.GetInt("Language", 1) == 1) // English
        {
            StartButton.GetComponent<Text>().text = StartString;
            LeaderboardButton.GetComponent<Text>().text = LeaderboardString;
            HardcoreButton.GetComponent<Text>().text = HardcoreModeString;
            SettingsButton.GetComponent<Text>().text = SettingsString;
            GravityScaleText.GetComponent<Text>().text = GravityScaleString;

            RateContent.GetComponent<Text>().text = RateGameContentString;
            RateNothanks.GetComponent<Text>().text = RateGameNoThanks;
            RateLater.GetComponent<Text>().text = RateGameLater;
            RateNow.GetComponent<Text>().text = RateGameRateNow;
            RateUs.GetComponent<Text>().text = RateUsString;

        }
        else if (PlayerPrefs.GetInt("Language", 1) == 2) // German
        {
            StartButton.GetComponent<Text>().text = StartStringGerman;
            LeaderboardButton.GetComponent<Text>().text = LeaderboardStringGerman;
            HardcoreButton.GetComponent<Text>().text = HardcoreModeStringGerman;
            SettingsButton.GetComponent<Text>().text = SettingsStringGerman;
            GravityScaleText.GetComponent<Text>().text = GravityScaleStringGerman;

            RateContent.GetComponent<Text>().text = RateGameContentStringGerman;
            RateNothanks.GetComponent<Text>().text = RateGameNoThanksGerman;
            RateLater.GetComponent<Text>().text = RateGameLaterGerman;
            RateNow.GetComponent<Text>().text = RateGameRateNowGerman;
            RateUs.GetComponent<Text>().text = RateUsStringGerman;
        }
    }
}
