using UnityEngine;

public class CollisionWall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(GameObject.Find("Enemy(Clone)")); // destroying gameobject to not overload the game
        }
        if (collision.tag == "PlaneTrigger")
        {
            Destroy(GameObject.Find("plane(Clone)"));
        }
    }
}
