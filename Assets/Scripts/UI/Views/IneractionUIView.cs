using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IneractionUIView : UIView
{
    // TODO: add events and displaying methods here
    [SerializeField] private RectTransform npcInteractionPlaceholder;
    [SerializeField] private Image npcInteractionBackground;
    [SerializeField] private RectTransform npcInteractionTextHolder;
    [SerializeField] private RectTransform npcInteractionPanel;

    [SerializeField] private TextMeshProUGUI npcInteractionText;
    [SerializeField] private float waitTime = 0;

    private Image npcInteractionPlaceholderImage;

    Vector2 defPlaceholderPosition, defTextHolderPosition, defPanelPosition;
    Vector2 targetPlaceholderPosition, targetTextHolderPosition, targetPanelPosition;

    private void Start()
    {
        npcInteractionPlaceholderImage = npcInteractionPlaceholder.GetComponent<Image>();

        defPlaceholderPosition = npcInteractionPlaceholder.anchoredPosition;
        defTextHolderPosition = npcInteractionTextHolder.anchoredPosition;
        defPanelPosition = npcInteractionPanel.anchoredPosition;
    }

    public override void ShowView()
    {
        base.ShowView();
        StartCoroutine(PlayShowingAnimation());
    }
    IEnumerator PlayShowingAnimation()
    {
        float time = 0;
        Color startColor = new Color(0, 0, 0, 0);
        Color endColor = new Color(0, 0, 0, 200);
        targetPlaceholderPosition = defPlaceholderPosition + Vector2.right * 10;
        targetTextHolderPosition = defTextHolderPosition + Vector2.left * 10;
        targetPanelPosition = defPanelPosition + Vector2.up * 5;
        while (time < waitTime)
        {
            npcInteractionBackground.color = Color.Lerp(startColor, endColor, time/ waitTime);
            npcInteractionPlaceholder.anchoredPosition = Vector2.Lerp(npcInteractionPlaceholder.position, targetPlaceholderPosition, time / waitTime);
            npcInteractionTextHolder.anchoredPosition = Vector2.Lerp(npcInteractionTextHolder.position, targetTextHolderPosition, time / waitTime);
            npcInteractionPanel.anchoredPosition = Vector2.Lerp(npcInteractionPanel.position, targetPanelPosition, time / waitTime);

            time += Time.deltaTime;
            yield return null;
        }
        yield return null;
    }
}
