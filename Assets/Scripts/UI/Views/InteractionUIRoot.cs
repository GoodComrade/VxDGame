using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionUIRoot : UIRoot
{
    [SerializeField]
    private IneractionUIView menuView;
    public IneractionUIView MenuView => menuView;

    public override void ShowRoot()
    {
        base.ShowRoot();

        menuView.ShowView();
    }

    public override void HideRoot()
    {
        menuView.HideView();

        base.HideRoot();
    }
}
