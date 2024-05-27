using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy, SpriteAttentionMarkIcon;

    public float spawnRate = 2f;
    float SpawnRangeScreenMin = -3.8f;
    float SpawnRangeScreenMax = 4.8f;
    Vector3 Spawn1, Spawn2;
    private void Start()
    {
        Invoke("spawnEnemy", .8f);
    }

    void spawnEnemy()
    {
        if (!FindObjectOfType<Movement>().Player_dead)
        {
            CancelInvoke(); // Stop the timer (I don't think you need it, try without)
            var RandomValue = Random.Range(Camera.main.transform.position.y + SpawnRangeScreenMin, SpawnRangeScreenMax);
            Spawn1 = new Vector3(Camera.main.transform.position.x + 2.35f, RandomValue, 10); // random Pos for Spawning
            Spawn2 = new Vector3(Camera.main.transform.position.x + 4.3f, RandomValue, 10); // random Pos for Spawning

            Instantiate(this.SpriteAttentionMarkIcon, Spawn1, Quaternion.identity);
            StartCoroutine(delayDestroy(.4f));
            Instantiate(this.Enemy, Spawn2, Quaternion.identity);
            // Start a new timer for the next random spawn
            Invoke("spawnEnemy", Random.Range(1, 3)); // time 1 to 3
        }
    }
    IEnumerator delayDestroy(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(GameObject.Find("AttentionMarkSignal(Clone)"));
    }
}
