using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnPoint;
    int score = 0;

    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject player;

    IEnumerator SpawnObstacles(){
        // infinite loop for the spawning of the obstacles
        while(true){
            float waitTime = Random.Range(0.8f, 1.5f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);
        }
    }

    void ScoreUp(){
        score++;
        scoreText.text = score.ToString();
        // must have ToString() in order to convert the score int to the score text string
    }

    public void GameStart(){
        // once the player presses the start button, the start button will disappear and the player object will appear
        player.SetActive(true);
        playButton.SetActive(false);

        StartCoroutine("SpawnObstacles");
        InvokeRepeating("ScoreUp", 2f, 1f);
        // the score will start to update after waiting two seconds and will keep on updating after every second
    }
}