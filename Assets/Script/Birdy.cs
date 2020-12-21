using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    // Değişkenler
    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rd2D;
    public GameManager managerGame;
    public GameObject DeathScreen;


    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {  
         //Tıklamayı Al
       if(Input.GetMouseButtonDown(0)) 
       {
           // Havada Kuşu Sıcrat
           rd2D.velocity = Vector2.up * velocity;
       }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        
        if(collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;
            
            DeathScreen.SetActive(true);
        }
    }
}
