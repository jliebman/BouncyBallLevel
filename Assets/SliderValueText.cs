using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderValueText : MonoBehaviour
{
    public GameObject slider;
    public string type;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = type + ": " + (slider.GetComponent<UnityEngine.UI.Slider>().value).ToString();
    }
}
