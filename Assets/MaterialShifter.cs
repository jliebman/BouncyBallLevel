using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialShifter : MonoBehaviour
{
    private Material mat;
    bool gang;
    private void Start()
    {
        mat = GetComponent<Renderer>().material;
        gang = false;
    }
    void Update()
    {
        if (!gang)
        {
            StartCoroutine(adjustTiling());
        }
    }

    IEnumerator adjustTiling()
    {
        gang = true;
        yield return new WaitForSecondsRealtime(0.5f);
        mat.mainTextureScale = new Vector2(mat.mainTextureScale.x + 0.05f, mat.mainTextureScale.y + 0.05f);
        gang = false;
    }
}
