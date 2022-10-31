using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseController : MonoBehaviour
{
    [SerializeField] private UIRootController UIRoot;

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            GameState currentGameState = GameStateManager.Instance.CurrentGameState;
            GameState newGameState = currentGameState == GameState.Gameplay
                ? GameState.Paused
                : GameState.Gameplay;

            UIRoot.ChangeController(newGameState == GameState.Gameplay 
                ? UIRootController.UIControllerTypeEnum.Player
                : UIRootController.UIControllerTypeEnum.Menu);
            
            GameStateManager.Instance.SetState(newGameState);
            
        }
    }
}
