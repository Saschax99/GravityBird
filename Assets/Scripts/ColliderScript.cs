using UnityEngine;
// using CloudOnce;

public class ColliderScript : MonoBehaviour
{
    Vector3 DeadRotation;
    private void Start()
    {
        DeadRotation = new Vector3(0, 0, 180);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartHitSound();
            FindObjectOfType<Movement>().Player.transform.Rotate(DeadRotation);
            FindObjectOfType<Movement>().Player_dead = true;
        }
        if (collision.tag == "Enemy")
        {
            StartHitSound();
            FindObjectOfType<Movement>().Player_dead = true;
        }
        if (collision.tag == "PlaneTrigger")
        {
            StartHitSound();
            FindObjectOfType<Movement>().Player_dead = true;

            // if (!Achievements.HittedByPlane.IsUnlocked)
            // {
            // Achievements.HittedByPlane.Unlock();
            // }
        }
    }
    private void StartHitSound()
    {
        if (PlayerPrefs.GetInt("Sounds", 1) == 1)
        {
            AudioManager.Instance.PlaySFX(FindObjectOfType<AudioPlayer>().HitSound);
        }
    }
}
