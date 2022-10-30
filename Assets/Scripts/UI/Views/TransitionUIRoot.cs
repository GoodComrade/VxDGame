using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionUIRoot : UIRoot
{
    [SerializeField]
    private TransitionUIView transitionView;
    public TransitionUIView TransitionView => transitionView;
    public override void ShowRoot()
    {
        base.ShowRoot();

        transitionView.ShowView();
    }

    public override void HideRoot()
    {
        transitionView.HideView();

        base.HideRoot();
    }
}
