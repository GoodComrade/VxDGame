using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private float playerSpeed;
    private PlayerInputConfig input;

    private void Awake()
    {
        input = new PlayerInputConfig();
        GameStateManager.Instance.OnGameStateChanged += OnGameStateChanged;
    }

    private void OnDestroy()
    {
        GameStateManager.Instance.OnGameStateChanged -= OnGameStateChanged;
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    private void Update()
    {
        Vector2 direction = input.Player.Move.ReadValue<Vector2>();
        Move(direction);
    }

    public void Move(Vector2 dir)
    {
        Vector3 movement = new Vector3(dir.x, 0, dir.y);
        transform.Translate(movement * playerSpeed * Time.deltaTime, Space.World);
        if (movement != Vector3.zero)
        {
            Quaternion toRot = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = toRot;
        }
    }

    private void OnGameStateChanged(GameState newGameState)
    {
        enabled = newGameState == GameState.Gameplay;
    }
}
