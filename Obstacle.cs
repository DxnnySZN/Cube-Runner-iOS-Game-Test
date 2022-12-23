using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    
    // Update is called once per frame
    void Update()
    {
        // make speed negative so the obstacle moves toward the player
        // use Time.deltaTime so the obstacle moves smoothly
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}