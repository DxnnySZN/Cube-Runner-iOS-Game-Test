using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce;
    bool canJump;

    private void Awake(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetMouseButtonDown(0) also applies to whenever you touch the screen
        if(Input.GetMouseButtonDown(0) && canJump == true){
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            // ForceMode.Impulse allows the jumpForce to be more effective
        }
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Ground"){
            canJump = true;
        }
    }

    // this restricts the player from being able to jump infinitely while midair
    private void OnCollisionExit(Collision collision){
        if(collision.gameObject.tag == "Ground"){
            canJump = false;
        }
    }

    // if the player touches the obstacle, the game will restart
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Obstacle"){
            SceneManager.LoadScene("Game");
        }
    }
}