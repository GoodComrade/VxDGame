using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IneractionUIView : UIView
{
    // TODO: add events and displaying methods here
    [SerializeField] private Image npcInteractionPlaceholder;
    [SerializeField] private Image npcInteractionBackground;
    [SerializeField] private GameObject npcInteractionTextHolder;
    [SerializeField] private GameObject npcInteractionPanel;
    [SerializeField] private TextMeshProUGUI npcInteractionText;

    private Animator animator;
    private readonly int openHash = Animator.StringToHash("Open"); 

    private void Awake()
    {
        animator = GetComponent<Animator>();
        npcInteractionPlaceholder = GetComponent<Image>();
        npcInteractionBackground = GetComponent<Image>();
    }

    public override void ShowView()
    {
        base.ShowView();
        animator.SetBool(openHash, true);
    }

    public override void HideView()
    {
        animator.SetBool(openHash, false);
        base.HideView();
    }

}
