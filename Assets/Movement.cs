using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    PlayerControl controls;
    CharacterController characterController;
    public GameObject avatar;
    //public GameObject camera;
    [Range(0.5f, 5f)]
    public float moveSpeed = 1f;
    [Range(0.5f, 5f)]
    public float rotationSpeed = 1f;

    private void Awake()
    {
        characterController = avatar.GetComponent<CharacterController>();
        controls = new PlayerControl();
    }
    void Update()
    {
        //camera.transform.localPosition = new Vector3(0, 0.951f, 0);
        Debug.Log(controls.Player.Movement.ReadValue<Vector2>());
        move();
    }

    private void move()
    {
        Vector2 m = controls.Player.Movement.ReadValue<Vector2>();
        Vector3 movement;
        if (m.y > 0.9f)
        {
            movement = (avatar.transform.forward);
            characterController.Move(movement * moveSpeed * Time.deltaTime);
        }
        if (m.y < -0.9f)
        {
            movement = (-avatar.transform.forward);
            characterController.Move(movement * moveSpeed * Time.deltaTime);
        }
        if (m.x > 0.9f)
        {
            avatar.transform.Rotate(Vector3.up * 1 * rotationSpeed);
        }
        if (m.x < -0.9f)
        {
            avatar.transform.Rotate(Vector3.up * -1 * rotationSpeed);
        }
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }
}
