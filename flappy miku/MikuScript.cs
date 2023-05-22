using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikuScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpStrength;
    public LogicScript logic;
    public bool mikuAlive = true;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && mikuAlive)
        {
            myRigidbody.velocity = Vector2.up * jumpStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        mikuAlive = false;
       
    }
}
