using TMPro;
using UnityEngine;


public class PlayerCollision : MonoBehaviour
{
    [SerializeField] AudioClip deathSound;
    AudioSource deathSource;
    PlayerMovement movement;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] TextMeshProUGUI highScoreText;
    PlayerTrigger trigger;
    Animator animator;
    int x = 0; //this is used to ensure that the player death sound doesn't play more than once
    // Start is called before the first frame update
    private void Start()
    {
        deathSource = gameObject.AddComponent<AudioSource>();
        deathSource.clip = deathSound;
        movement = GetComponent<PlayerMovement>();
        trigger = GetComponent<PlayerTrigger>();
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Pipe") && x < 1)
        {
            movement.dead = true;
            deathSource.Play();
            x++;
            if (trigger.getScore() > PlayerPrefs.GetInt("HighScore", 0)) 
                PlayerPrefs.SetInt("HighScore", trigger.getScore());
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
            gameOverScreen.SetActive(true);
            trigger.resetScore();
            animator.SetBool("Dead", true);

            

        }
    }
}