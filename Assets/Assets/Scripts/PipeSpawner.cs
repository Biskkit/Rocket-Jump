using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] Object pipe;
    [SerializeField] float interval = 1;
    GameObject player;
    PlayerMovement movement;
    float acc = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        movement = player.GetComponent<PlayerMovement>();
        spawnPipe();
    }
    // Update is called once per frame
    void Update()
    {
        acc += Time.deltaTime;
        if(acc >= interval)
        {
            acc = 0;
            spawnPipe();
        }
    }
    void spawnPipe()
    {
        Vector2 pos = new Vector2(transform.position.x, Random.Range(-.5f, .5f));
        if(!movement.dead)
        {
            Instantiate(pipe, pos, transform.rotation);
        }
    }
}
