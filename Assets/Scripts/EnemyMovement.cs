using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Vector2 EnemySpeed;
    private void Start()
    {
        EnemySpeed = new Vector2(-.5f, 0);
    }
    void Update()
    {
        this.transform.GetComponent<Rigidbody2D>().velocity = EnemySpeed;
    }
}
