using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAdding : MonoBehaviour
{
    public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = "Score: " + game.GetComponent<GameRunningControl>().score;
    }
}
