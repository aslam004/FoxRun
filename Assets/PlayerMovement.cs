using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    float horizontalMove=0f;
    public float runSpeed=40f;
    bool jump=false;
    bool crouch=false;
    
    public int health=3;
    public Text healthDisplay;

    public GameObject gameOver;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        healthDisplay.text=health.ToString();

         if (health<=0){
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        horizontalMove=Input.GetAxisRaw("Horizontal")*runSpeed;
        
        if (Input.GetButtonDown("Jump")){
            jump=true;
        }
        if (Input.GetButtonDown("Crouch")){
            crouch=true;
        }else if (Input.GetButtonUp("Crouch")){
            crouch=false;
        }
    }
    void FixedUpdate() {
        //move character
        controller.Move(horizontalMove*Time.fixedDeltaTime,crouch,jump);
        jump=false;
        crouch=false;
    }
}
