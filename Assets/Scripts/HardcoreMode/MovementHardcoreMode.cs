using UnityEngine;
using UnityEngine.UI;

public class MovementHardcoreMode : MonoBehaviour
{
    Vector2 jump_Velocity;

    public bool Player_dead;
    public Sprite BirdFlyingUp, BirdFlyingDown;
    public GameObject Player;
    public Slider GravityScale;

    private void Start()
    {
        Player_dead = false;

        jump_Velocity = new Vector2(0, 7);
    }
    private void Update()
    {
#if UNITY_EDITOR
        MoveInput();
#elif UNITY_IOS || UNITY_ANDROID
            TouchInput();
#endif

        if (Player.GetComponent<Rigidbody2D>().velocity.y > 0)
        {
            Player.GetComponent<SpriteRenderer>().sprite = BirdFlyingUp;
        }
        else if (Player.GetComponent<Rigidbody2D>().velocity.y < 0)
        {
            Player.GetComponent<SpriteRenderer>().sprite = BirdFlyingDown;
        }

        if (!Player_dead)
        {
            Player.GetComponent<Rigidbody2D>().gravityScale = Mathf.Sin(Time.timeSinceLevelLoad) + 4f; // Flying in a  Sin wave
            GravityScale.value = Player.GetComponent<Rigidbody2D>().gravityScale;
        }
    }

    void MoveInput()
    {
        //we check if left mouse button is pressed
        if (Input.GetMouseButton(0))
        {
            //if its down
            if (Input.GetMouseButtonDown(0))
            {
                TapPhysics();
            }
        }

        //when player lift the mouse button
        if (Input.GetMouseButtonUp(0))
        {

        }
    }

    void TouchInput()
    {
        //if touch count is more than 0
        if (Input.touchCount > 0)
        {
            //get the 1st touch
            Touch touch = Input.GetTouch(0);

            //if touch.phase is begin
            if (touch.phase == TouchPhase.Began)
            {
                TapPhysics();
            }
            //if touch.phase is Ended
            if (touch.phase == TouchPhase.Ended)
            {

            }
        }
    }
    void TapPhysics()
    {
        if (!Player_dead)
        {
            if (PlayerPrefs.GetInt("Sounds", 1) == 1)
            {
                AudioManager.Instance.PlaySFX(FindObjectOfType<AudioPlayer>().JumpSound);
            }
            Player.GetComponent<Rigidbody2D>().velocity = jump_Velocity;
        }
    }
}