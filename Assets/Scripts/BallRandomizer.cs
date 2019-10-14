using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRandomizer : MonoBehaviour
{
    public Rigidbody rigid;
    void Start()
    {
        rigid = this.GetComponent<Rigidbody>();
        rigid.mass = Random.Range(1f, 5f);
    }
}
