using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIController : SubController<InventoryUIRoot>
{
    public override void EnableUIController()
    {
        //Subscribe on view events here
        base.EnableUIController();
    }
    public override void DisableUIController()
    {
        //Unsubscribe on view events here
        base.DisableUIController();
    }
}
