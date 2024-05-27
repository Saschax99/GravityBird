using UnityEngine;

public class EnemyMovementHardcore : MonoBehaviour
{
    private Vector2 EnemySpeed;
    private void Start()
    {
        EnemySpeed = new Vector2(-2f, 0);
    }
    void Update()
    {
        this.transform.GetComponent<Rigidbody2D>().velocity = EnemySpeed;
    }
}
