using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    private Vector2 PlaneSpeed;
    private void Start()
    {
        PlaneSpeed = new Vector2(-15, 0);
    }
    void Update()
    {
        transform.GetComponent<Rigidbody2D>().velocity = PlaneSpeed;
    }
}
