using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Interactor : MonoBehaviour
{
    [SerializeField] private UIRootController UIRoot;
    [SerializeField] private GameObject interactionText;
    [SerializeField] private Sprite npcInteractionPlaceholder;

    private void Start()
    {
        interactionText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            interactionText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            interactionText.SetActive(false);

    }

    private void OnTriggerStay(Collider other)
    {
        if (Keyboard.current.fKey.wasPressedThisFrame && other.tag == "Player")
        {
            UIRoot.InteractionUIController.SetInteractorData(npcInteractionPlaceholder);
            EnableInteraction();
            //other.gameObject.GetComponent<PlayerController>().
        }
            
        /*else if(Input.GetKeyDown(KeyCode.F) && other.tag == "Player")
            DisableInteraction();*/
        
    }

    void EnableInteraction()
    {
        UIRoot.ChangeController(UIRootController.UIControllerTypeEnum.Interaction);
    }
}
