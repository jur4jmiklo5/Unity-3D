using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinClickTrigger : MonoBehaviour
{
    public GameObject infoPanel;

    void OnMouseDown()
    {
        gameObject.SetActive(false); 
        if (infoPanel != null)
        {
            infoPanel.SetActive(true); 
        }
    }
}
