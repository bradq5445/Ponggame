using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aimovement : MonoBehaviour
{
        //Vector3 for going up and down
    Vector3 speedUp = Vector3.up;
    Vector3 speedDown = Vector3.down;
    float speed = 0.1f;
    // Update is called once per frame
    void FixedUpdate()
    {
        //Move paddle up
        transform.position += speedUp * speed;
    }

    //Swap direction when wall is hit
    void OnCollisionEnter2D(Collision2D collision)
    {
        speed = speed * -1;
    }

}
