using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicFogController : MonoBehaviour
{
    public Transform playerCamera;
    public Transform castleCenter;

    public float maxFogDensity = 0.02f;
    public float minFogDensity = 0.001f;
    public float maxDistance = 30f;

    void Update()
    {
        float distance = Vector3.Distance(playerCamera.position, castleCenter.position);
        distance = Mathf.Clamp(distance, 0f, maxDistance);
        float t = distance / maxDistance;

        RenderSettings.fogDensity = Mathf.Lerp(minFogDensity, maxFogDensity, t);
    }
}
