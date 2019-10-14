using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRunningControl : MonoBehaviour
{
    public int score;
    public int duration;
    public float timeDifficulty;
  //  public int amountOfBalls = 10;
    public bool gang;
    public bool scoreUpdated;
    // Update is called once per frame
    private void Start()
    {
        gang = true;
        //DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        if(!gang)
        {
            StartCoroutine(endGame(duration));
        }
        if(score % 5 == 0)
        {
            if (!scoreUpdated)
            {
                timeDifficulty -= 0.3f;
                if(timeDifficulty < 0.25f)
                {
                    timeDifficulty = 0.25f;
                }
               // amountOfBalls += 15;
                scoreUpdated = true;
            }
        }
    }
    IEnumerator endGame(int time)
    {
        gang = true;
        yield return new WaitForSeconds(time);
        gang = false;
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("endScreen");
    }
}
