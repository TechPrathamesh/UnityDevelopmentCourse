using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform playerPosition;
    public float speed;
    public float acceleration;
    public float speed1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        speed += acceleration;

        transform.Translate(Input.GetAxis("Horizontal") * speed1 * Time.deltaTime, 0, 0);
    }
}
