using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIRoot : UIRoot
{
    [SerializeField]
    private MenuUIView menuView;
    public MenuUIView MenuView => menuView;
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
