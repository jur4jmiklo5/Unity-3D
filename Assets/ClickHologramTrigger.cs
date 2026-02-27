using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHologramTrigger : MonoBehaviour
{
    public GameObject kastiel_b;
    public AudioSource hologramAudio;

    void OnMouseDown()
    {
        if (kastiel_b != null)
        {
            bool newState = !kastiel_b.activeSelf;
            kastiel_b.SetActive(newState);

            if (hologramAudio != null)
            {
                if (newState && !hologramAudio.isPlaying)
                {
                    hologramAudio.Play();
                }
                else if (!newState && hologramAudio.isPlaying)
                {
                    hologramAudio.Stop();
                }
            }
        }
    }
}
