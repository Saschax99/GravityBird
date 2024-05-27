using UnityEngine;

public class CollisionWallHardcoreMode : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyHardcore")
        {
            Destroy(GameObject.Find("EnemyHardcore(Clone)")); // destroying gameobject to not overload the game
        }
        if (collision.tag == "PlaneTrigger")
        {
            Destroy(GameObject.Find("plane(Clone)"));
        }
    }
}
