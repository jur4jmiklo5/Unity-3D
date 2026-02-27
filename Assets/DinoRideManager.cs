using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoRideManager : MonoBehaviour
{
    public Transform playerAvatar;
    public Transform dinosaur;
    public float rideHeightOffset = 2f;

    public RideAnimatorSwitcher animatorSwitcher;

    private bool isRiding = false;
    private Transform originalParent;
    private Vector3 dismountPosition;
    private float storedYPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            TryMount();

        if (isRiding)
        {
            SyncDinoToAvatar(); 

            if (Input.GetKeyDown(KeyCode.G))
                Dismount();
        }
    }

    void TryMount()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, 100f))
        {
            if (hit.transform == dinosaur)
                Mount();
        }
    }

    void Mount()
    {
        storedYPosition = playerAvatar.position.y;
        if (isRiding) return;

        originalParent = playerAvatar.parent;
        dismountPosition = playerAvatar.position;

        // Hráč zostáva voľný (nepripája sa k dinosaurovi)
        // Presne sa umiestni nad dinosaura
        Vector3 dinoPos = dinosaur.position;
        playerAvatar.position = new Vector3(dinoPos.x, dinoPos.y + rideHeightOffset, dinoPos.z);
        playerAvatar.rotation = Quaternion.Euler(0, dinosaur.eulerAngles.y + 180f, 0);

        isRiding = true;

        if (animatorSwitcher != null)
            animatorSwitcher.StartRiding();
    }

    void Dismount()
    {
        if (!isRiding) return;

        // Pravá strana dinosaura + mierne dozadu
        Vector3 rightOfDino = dinosaur.right.normalized;
        Vector3 exitOffset = rightOfDino * 2f - dinosaur.forward * 0.5f;
        Vector3 exitPosition = dinosaur.position + exitOffset;

        // Zisti výšku terénu pod výstupom (raycast smerom dole)
        float groundY = exitPosition.y;
        RaycastHit hit;
        if (Physics.Raycast(exitPosition + Vector3.up * 2f, Vector3.down, out hit, 10f))
        {
            groundY = hit.point.y;
        }

        playerAvatar.position = new Vector3(exitPosition.x, storedYPosition, exitPosition.z);

        isRiding = false;

        if (animatorSwitcher != null)
            animatorSwitcher.StopRiding();
    }

    void SyncDinoToAvatar()
    {
        // Dinosaurus kopíruje pozíciu hráča (iba XZ)
        Vector3 newPos = playerAvatar.position;
        dinosaur.position = new Vector3(newPos.x, dinosaur.position.y, newPos.z);

        // Dinosaurus sa otočí ako hráč
        float yRotation = playerAvatar.eulerAngles.y - 180f;
        dinosaur.rotation = Quaternion.Euler(0f, yRotation, 0f);
    }
}
