using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PashaInteraction : MonoBehaviour
{
    [SerializeField] UIRootController dialogueUI;

    bool IsInteraction = false;

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && IsInteraction)
            DisableInteraction();
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F) && other.tag == "Player" && !IsInteraction)
            EnableInteraction();
        else if(Input.GetKeyDown(KeyCode.F) && other.tag == "Player" && IsInteraction)
            DisableInteraction();
    }

    void EnableInteraction()
    {
        IsInteraction = true;
        dialogueUI.ChangeController(UIRootController.UIControllerTypeEnum.Interaction);
    }

    void DisableInteraction()
    {
        IsInteraction = false;
        dialogueUI.ChangeController(UIRootController.UIControllerTypeEnum.Player);
    }
}
