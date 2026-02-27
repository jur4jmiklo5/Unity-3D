using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideAnimatorSwitcher : MonoBehaviour
{
    public Animator dinosaurAnimator;
    public RuntimeAnimatorController idleController;
    public RuntimeAnimatorController walkController;

    private bool isRiding = false;

    void Update()
    {
        if (!isRiding) return;

        if (Input.GetKey(KeyCode.W))
        {
            if (dinosaurAnimator.runtimeAnimatorController != walkController)
                dinosaurAnimator.runtimeAnimatorController = walkController;
        }
        else
        {
            if (dinosaurAnimator.runtimeAnimatorController != idleController)
                dinosaurAnimator.runtimeAnimatorController = idleController;
        }
    }

    public void StartRiding()
    {
        isRiding = true;
        dinosaurAnimator.runtimeAnimatorController = idleController;
    }

    public void StopRiding()
    {
        isRiding = false;
        dinosaurAnimator.runtimeAnimatorController = idleController;
    }
}
