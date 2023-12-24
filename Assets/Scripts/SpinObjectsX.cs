using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObjectsX : MonoBehaviour
{
    //makes a varible
    public float spinSpeed;

    // Update is called once per frame
    void Update()
    {
        //Roatates object around
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
    }
}
