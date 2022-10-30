using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIRoot : UIRoot
{
    [SerializeField]
    private InventoryUIView inventoryView;
    public InventoryUIView InventoryView => inventoryView;
    public override void ShowRoot()
    {
        base.ShowRoot();

        inventoryView.ShowView();
    }

    public override void HideRoot()
    {
        inventoryView.HideView();

        base.HideRoot();
    }
}
