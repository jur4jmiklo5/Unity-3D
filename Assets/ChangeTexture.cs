using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour
{
    public Material yourCustomMaterial;
    public Material originalMaterial;

    public void setCustomTexture()
    {
        GetComponent<MeshRenderer>().material = yourCustomMaterial;
    }

    public void resetTexture()
    {
        GetComponent<MeshRenderer>().material = originalMaterial;
    }
}
