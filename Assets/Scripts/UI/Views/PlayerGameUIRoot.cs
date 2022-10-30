using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameUIRoot : UIRoot
{
    [SerializeField]
    private PlayerGameUIView playerGameView;
    public PlayerGameUIView PlayerGameView => playerGameView;
    public override void ShowRoot()
    {
        base.ShowRoot();

        playerGameView.ShowView();
    }

    public override void HideRoot()
    {
        playerGameView.HideView();

        base.HideRoot();
    }
}
