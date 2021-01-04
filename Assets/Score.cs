using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;

    private void update(){
        scoreDisplay.text=score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other) {
       
       if(other.CompareTag("Respawn")){
           score+=10;
           Debug.Log(score);
       }
   }
}
