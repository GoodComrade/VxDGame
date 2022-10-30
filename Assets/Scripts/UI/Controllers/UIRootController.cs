using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UIRootController;

public class UIRootController : MonoBehaviour
{
    public enum UIControllerTypeEnum
    {
        Menu,
        Inventory,
        Interaction,
        Transition,
        Player
    }

    [Header("Controllers")]
    [SerializeField]
    private PlayerGameUIController playerGameController;
    [SerializeField]
    private MenuUIController menuController;
    [SerializeField]
    private InteractionUIController interactionController;
    [SerializeField]
    private InventoryUIController inventoryController;
    [SerializeField]
    private SceneTransitionController sceneTransitionController;

    public PlayerGameUIController PlayerGameUIController => playerGameController;
    public MenuUIController MenuUIController => menuController;
    public InteractionUIController InteractionUIController => interactionController;
    public InventoryUIController InventoryUIController => inventoryController;
    public SceneTransitionController SceneTransitionController => sceneTransitionController;
    


    void Start()
    {
        playerGameController.root = this;
        menuController.root = this;
        interactionController.root = this;
        inventoryController.root = this;
        sceneTransitionController.root = this;

        ChangeController(UIControllerTypeEnum.Player);
    }

    public void ChangeController(UIControllerTypeEnum controller)
    {
        // Reseting subcontrollers.
        DisableUIControllers();

        // Enabling subcontroller based on type.
        switch (controller)
        {
            case UIControllerTypeEnum.Menu:
                menuController.EnableUIController();
                break;
            case UIControllerTypeEnum.Interaction:
                interactionController.EnableUIController();
                break;
            case UIControllerTypeEnum.Inventory:
                inventoryController.EnableUIController();
                break;
            case UIControllerTypeEnum.Transition:
                sceneTransitionController.EnableUIController();
                break;
            case UIControllerTypeEnum.Player:
                playerGameController.EnableUIController();
                break;
            default:
                break;
        }
    }
    public void DisableUIControllers()
    {
        menuController.DisableUIController();
        interactionController.DisableUIController();
        inventoryController.DisableUIController();
        sceneTransitionController.DisableUIController();
        playerGameController.DisableUIController();
    }
}
