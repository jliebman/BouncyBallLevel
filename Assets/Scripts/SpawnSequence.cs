using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSequence : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameController;
    int i = 0;
    bool gang;
    public GameObject ball;
    public Color[] colors = { Color.black, Color.blue, Color.cyan, Color.gray, Color.green, Color.grey, Color.magenta, Color.red, Color.white, Color.yellow };
    private void Awake()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        Debug.Log(gameController.GetComponent<GameRunningControl>().duration);
    }
    void Update()
    {
        if(!gang)
        {
            StartCoroutine(WaitToSpawn(gameController.GetComponent<GameRunningControl>().timeDifficulty));
        }
    }
    IEnumerator WaitToSpawn(float waitTime)
    {
        gang = true;
        yield return new WaitForSeconds(waitTime);
        Instantiate(ball);
        Debug.Log("Ball Spawned");
        ball.transform.SetPositionAndRotation((new Vector3(Random.Range(-1.2f, 1.2f), 9f, Random.Range(-1.2f, 1.2f))), Quaternion.identity);
        ball.GetComponent<Light>().color = colors[(int)Random.Range(0f, colors.Length)];
        gang = false;
  
    }
}
