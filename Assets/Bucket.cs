using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    public GameObject game;
    private void Awake()
    {
        game = GameObject.FindGameObjectWithTag("GameController");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            game.GetComponent<GameRunningControl>().score += 5;
            game.GetComponent<GameRunningControl>().scoreUpdated = false;
            this.GetComponent<AudioSource>().Play();
        }
    }
}
