using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    private Rigidbody2D vel ;
    private void Awake()
    {
        vel = GetComponent<Rigidbody2D>();
    }

    
    void Start()
    {
        
    }

    
    private void Update()
    {
        if (Input.GetKey(KeyCode.D) == true)
        {
            vel.velocity = Vector2.right * 1;
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            vel.velocity = Vector2.left * 1;
        }
    }
}
