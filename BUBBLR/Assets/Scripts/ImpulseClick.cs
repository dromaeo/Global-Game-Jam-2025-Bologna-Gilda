using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseClick : MonoBehaviour{

    public float ImpulseForce;

    void Start()
    {
    }

    void Update() 
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("Click");
        }
        else
        {
        }
    }
}