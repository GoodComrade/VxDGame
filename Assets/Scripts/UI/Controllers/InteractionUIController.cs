using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionUIController : SubController<InteractionUIRoot>
{

    private void Awake()
    {
        
    }
    public override void EnableUIController()
    {
        //Subscribe on view events here
        ui.InteractionView.OnCloseClicked += CloseInteractionCanvas;

        base.EnableUIController();
    }
    public override void DisableUIController()
    {
        //Unsubscribe on view events here
        base.DisableUIController();
        ui.InteractionView.OnCloseClicked -= CloseInteractionCanvas;
    }

    void CloseInteractionCanvas()
    {
        root.ChangeController(UIRootController.UIControllerTypeEnum.Player);
    }
}
