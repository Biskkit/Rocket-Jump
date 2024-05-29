using UnityEngine;


public class PlayerCollision : MonoBehaviour
{
    [SerializeField] AudioClip deathSound;
    AudioSource deathSource;
    PlayerMovement movement;
    [SerializeField] GameObject gameOverScreen;
    PlayerTrigger trigger;
    int x = 0;
    // Start is called before the first frame update
    private void Start()
    {
        deathSource = gameObject.AddComponent<AudioSource>();
        deathSource.clip = deathSound;
        movement = GetComponent<PlayerMovement>();
        trigger = GetComponent<PlayerTrigger>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Pipe") && x < 1)
        {
            movement.dead = true;
            deathSource.Play();
            x++;
            gameOverScreen.SetActive(true);
            trigger.resetScore();
        }
    }
}