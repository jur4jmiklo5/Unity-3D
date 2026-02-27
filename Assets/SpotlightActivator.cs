using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightActivator : MonoBehaviour
{
    public Light[] spotlights;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            foreach (Light light in spotlights)
            {
                if (light != null)
                    light.enabled = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            foreach (Light light in spotlights)
            {
                if (light != null)
                    light.enabled = false;
            }
        }
    }
}
