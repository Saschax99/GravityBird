using UnityEngine;
// using CloudOnce;

public class Leaderboard : MonoBehaviour
{
    void Start()
    {
        // Cloud.OnInitializeComplete += CloudOnceInitializeComplete;
        // Cloud.Initialize(false, true);
        // Achievements.ArchievementStarted.Unlock();
    }
    public void CloudOnceInitializeComplete()
    {
        // Cloud.OnInitializeComplete -= CloudOnceInitializeComplete;
    }
}
