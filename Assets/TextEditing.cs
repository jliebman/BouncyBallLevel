using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextEditing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject game;
    private void Awake()
    {
        game = GameObject.FindGameObjectWithTag("GameController");
    }
    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMesh>().text = 
               "Time Remaining: " + (game.GetComponent<GameRunningControl>().duration - Time.timeSinceLevelLoad) + "\n" +
               "Score: " + game.GetComponent<GameRunningControl>().score + "\n" +
               "SpawnSpeed: " + game.GetComponent<GameRunningControl>().timeDifficulty;
    }
}
