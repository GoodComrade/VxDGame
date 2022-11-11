using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIController : SubController<MenuUIRoot>
{
    public override void EnableUIController()
    {
        ui.MenuView.OnCloseClicked += CloseMenuCanvas;
        //Subscribe on view events here
        base.EnableUIController();
    }
    public override void DisableUIController()
    {
        //Unsubscribe on view events here
        base.DisableUIController();
        
        ui.MenuView.OnCloseClicked -= CloseMenuCanvas;
    }

    void CloseMenuCanvas()
    {
        root.ChangeController(UIRootController.UIControllerTypeEnum.Player);
        GameStateManager.Instance.SetState(GameState.Gameplay);
    }


}
