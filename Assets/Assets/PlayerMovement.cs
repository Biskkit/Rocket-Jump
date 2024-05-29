using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidBody;
    [SerializeField] float velocityY = 1.0f;
    public bool dead = false;
    [SerializeField] InputAction playerControls;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        if ((playerControls.triggered) && !dead)
        {
            rigidBody.velocity = new Vector2(0f, velocityY);
           // if (rigidBody.velocity.y < 0) rigidBody.velocity = Vector2.zero;
            //rigidBody.AddForce(new Vector2(0f, velocityY), ForceMode2D.Impulse);
        }
    }
}