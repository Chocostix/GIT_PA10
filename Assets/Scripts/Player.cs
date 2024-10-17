using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public Rigidbody rb;

    public int score;
    public Text scoret;
    bool nice;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * 5;
            thisAnimation.Play();
        }

        if (transform.position.y <= -4.5)
        {
            SceneManager.LoadScene("Lose");
        }  

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Box"))
        {
            score += 1;
            scoret.text = "SCORE: " + score;
        }
    }
}
