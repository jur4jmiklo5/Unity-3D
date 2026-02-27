using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setcolor : MonoBehaviour
{
    public MeshRenderer renderer;
    [Range(0f, 4f)]
    public float red = 1;
    [Range(0f, 4f)]
    public float green = 1;
    [Range(0f, 4f)]
    public float blue = 1;
    
    void Start()
    {
        renderer.material.color = new Color(red, green, blue);
    }

    void Update()
    {
        renderer.material.SetColor("_Color", new Color(red, green, blue));
    }
}
