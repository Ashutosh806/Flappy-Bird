using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public Animator animator;
    [SerializeField] GameManager gameManager;
    [SerializeField] float force = 2f;
    void Start() 
    {
      rb = GetComponent<Rigidbody2D>();    
    }

    void Update() 
    {
      if(Input.GetKeyDown(KeyCode.Space))
      {
        rb.AddForce(transform.up * force);
        animator.SetBool("Jump",true);
      }  
      else animator.SetBool("Jump",false);  
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
      gameManager.GameOver();
    }
}
