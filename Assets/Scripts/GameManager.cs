using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    private int score = 0;
    private int lives = 5;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
    //Print the update number of lives and "Game Over" when all the lives are lost
    public void AddLives(int value){
        lives += value;
            
        if (lives <= 0){
            Debug.Log("Game Over");
            lives = 0;
        } else{
            Debug.Log("Lives = " + lives);
        }
    }
    //Print the update score each time it changes
    public void AddScore(int value){
        score += value;
        Debug.Log("Score = " + score);
    }
}
