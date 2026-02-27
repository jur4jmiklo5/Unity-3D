using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HologramFloatAndRotate : MonoBehaviour
{
    public float rotationSpeed = 30f; 
    public float floatAmplitude = 0.05f; 
    public float floatFrequency = 1f; 

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        
        float newY = startPos.y + Mathf.Sin(Time.time * floatFrequency) * floatAmplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
