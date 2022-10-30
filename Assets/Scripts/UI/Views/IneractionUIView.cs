using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class IneractionUIView : UIView
{
    public UnityAction OnCloseClicked;

    private Animator animator;
    private readonly int openHash = Animator.StringToHash("Open");

    // TODO: add events and displaying methods here
    [SerializeField] private Image npcInteractionPlaceholder;
    [SerializeField] private Image npcInteractionBackground;
    [SerializeField] private GameObject npcInteractionTextHolder;
    [SerializeField] private GameObject npcInteractionPanel;
    [SerializeField] private TextMeshProUGUI npcInteractionText;

    

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public override void ShowView()
    {
        base.ShowView();
        animator.SetBool(openHash, true);
    }

    public override void HideView()
    {
        base.HideView();
    }

    public void CloseClicked()
    {
        OnCloseClicked?.Invoke();
        animator.SetBool(openHash, false);
    }

    public void SetInteractorData(Sprite _npcInteractionPlaceholder)
    {
        npcInteractionPlaceholder.sprite = _npcInteractionPlaceholder;
    }
}
