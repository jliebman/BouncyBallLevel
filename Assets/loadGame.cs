using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadGame : MonoBehaviour
{
    // Start is called before the first frame update
 public void loadNextScene(string sceneName)
    {
        Debug.Log("start pressed");
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);
    }
    public void endGame()
    {
        Debug.Log("quit pressed");
        Application.Quit();
    }
}
