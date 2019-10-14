using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderController : MonoBehaviour
{
    public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.FindGameObjectWithTag("GameController");
    }
    private void Update()
    {
        updateTime();
        updateTimeBetween();
    }

    public void updateTime()
    {
        if(this.gameObject.name.Equals("Duration"))
        game.GetComponent<GameRunningControl>().duration = (int)this.GetComponent<UnityEngine.UI.Slider>().value;
    }
    public void updateTimeBetween()
    {
        if (this.gameObject.name.Equals("TimeBetweenDrop"))
            game.GetComponent<GameRunningControl>().timeDifficulty = this.GetComponent<UnityEngine.UI.Slider>().value;
    }

}
