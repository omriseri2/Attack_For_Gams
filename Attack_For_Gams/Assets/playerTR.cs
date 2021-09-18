using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTR : MonoBehaviour
{
    public Transform pl;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Y = transform.position.y;
        float X = pl.position.x;
        float Z = pl.position.z;
        transform.position = new Vector3(X, Y, Z);
    }
}
