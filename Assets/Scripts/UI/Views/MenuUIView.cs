using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MenuUIView : UIView
{
    // TODO: add events and displaying methods here
    private Animator animator;
    public UnityAction OnCloseClicked;
    

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public override void ShowView()
    {
        base.ShowView();
    }
    public void CloseClicked()
    {
        OnCloseClicked?.Invoke();
    }
}
