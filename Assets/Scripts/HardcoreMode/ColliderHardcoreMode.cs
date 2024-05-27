using UnityEngine;
// using CloudOnce;

public class ColliderHardcoreMode : MonoBehaviour
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
            if (PlayerPrefs.GetInt("Sounds", 1) == 1)
            {
                StartHitSound();
            }
            FindObjectOfType<MovementHardcoreMode>().Player.transform.Rotate(DeadRotation);
            FindObjectOfType<MovementHardcoreMode>().Player_dead = true;
        }
        if (collision.tag == "EnemyHardcore")
        {
            StartHitSound();
            FindObjectOfType<MovementHardcoreMode>().Player_dead = true;
        }
        if (collision.tag == "PlaneTrigger")
        {
            StartHitSound();
            FindObjectOfType<MovementHardcoreMode>().Player_dead = true;
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
