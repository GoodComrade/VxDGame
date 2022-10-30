using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionUIRoot : UIRoot
{
    [SerializeField]
    private IneractionUIView interactionView;
    public IneractionUIView InteractionView => interactionView;

    public override void ShowRoot()
    {
        base.ShowRoot();

        InteractionView.ShowView();
    }

    public override void HideRoot()
    {
        InteractionView.HideView();

        base.HideRoot();
    }
}
