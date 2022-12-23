using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this is only for the background music
public class MusicControl : MonoBehaviour
{
    public static MusicControl instance; 
    // creates a static varible for a MusicControl instance

    // runs before void Start()
    private void Awake(){
        DontDestroyOnLoad(this.gameObject); 
        // insures the music will not be "destroyed" when loading different scenes

        // if the player comes in contact with the object and the user gets brought back to the start menu, this code will make sure there will be no duplicates of the background music
        if (instance == null){
            instance = this; 
        }
        else{
            Destroy(gameObject); 
        }
    }
}