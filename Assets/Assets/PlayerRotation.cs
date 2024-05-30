using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    Rigidbody2D rigidBody;
    [SerializeField] float rotationSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidBody.rotation > -45)
        {
            rigidBody.AddTorque(-rotationSpeed * Time.deltaTime);
        }
        else if (rigidBody.rotation <= -45)
        {
            
        }
        Debug.Log(rigidBody.rotation);

    }
}
