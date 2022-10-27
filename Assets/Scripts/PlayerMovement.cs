using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private PlayerInput playerInput;
    [SerializeField] private GameObject dialoguecanvas;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 movement = new Vector3(playerInput.movementInput.x, 0f, playerInput.movementInput.y);
        movement.Normalize();
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
        if (movement != Vector3.zero)
        {
            Quaternion toRot = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = toRot;
        }
    }

}
