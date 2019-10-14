using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(progressToStart());
    }
    IEnumerator progressToStart()
    {
        yield return new WaitForSecondsRealtime(15f);
        Destroy(GameObject.FindGameObjectWithTag("GameController"));
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("startScreen");
    }
}
