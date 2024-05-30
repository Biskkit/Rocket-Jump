using TMPro;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] AudioClip scoreSound;
    AudioSource scoreSource;
    PlayerMovement playerMovement;
    int score = 0;
    private void Start()
    {
        scoreSource = gameObject.AddComponent<AudioSource>();
        scoreSource.clip = scoreSound;
        scoreSource.clip = scoreSound;
        playerMovement = GetComponent<PlayerMovement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe") && !playerMovement.dead)
        {
            scoreSource.Play();
            score++;
            scoreText.text = "Score: " + score;
        }
    }
    public void resetScore()
    {
        score = 0;
    }
    public int getScore()
    {
        return score;
    }
}
