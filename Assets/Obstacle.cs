using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage=1;

    public float speed;

    private void Update(){
    transform.Translate(Vector2.left*speed*Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D col) {
        //player take damage
        if(col.gameObject.tag.Equals("Player")){
            col.gameObject.GetComponent<PlayerMovement>().health-=damage;
            Debug.Log(col.gameObject.GetComponent<PlayerMovement>().health);
            Destroy(gameObject);           
        }
    }
}
