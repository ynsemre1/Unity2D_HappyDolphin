using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolphin : MonoBehaviour
{
    public bool isDead = false;

    public float velocity = 1f;
    public Rigidbody2D rb2D;

    public GameManager gameManager;
    public GameObject deathScreen;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        //Tiklamayi Al
        if (Input.GetMouseButtonDown(0))
        {
            //Baligi Sicrat
            rb2D.velocity = Vector2.up * velocity;
        }
    }

    //Baligin Colider Carpismalarini Kontrol Et
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            gameManager.UpdateScore();
        }

        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0f;
            deathScreen.SetActive(true);
        }
    }

    //Baligin RigidBody Carpismalarini Kontrol Et
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0f;
            deathScreen.SetActive(true);
        }
    }
}

