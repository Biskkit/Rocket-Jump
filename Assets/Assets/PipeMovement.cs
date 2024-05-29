using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float xDestroyPosition = 0;
    GameObject player;
    PlayerMovement playerMovement;
    float timer = 0;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if(!playerMovement.dead)
        {
            movePipe();
        }
        else
        {
            if(timer < 1)
            {
                movePipe();
                timer += Time.deltaTime;
            }
        }
    }

    void movePipe()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x <= xDestroyPosition)
        {
            Destroy(gameObject);
        }
    }
}