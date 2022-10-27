using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PashaInteraction : MonoBehaviour
{
    [SerializeField] GameObject dialogue;
    [SerializeField] private CameraFollow playerCamera;
    public Transform dialoguetarget;
    public float camTransitionSpeed;

    bool IsInteraction = false;
    Animator animator;
    int open;

    private void Start()
    {
        animator = dialogue.GetComponent<Animator>();
        open = Animator.StringToHash("Open");
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && IsInteraction)
            DisableInteraction();
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F) && other.tag == "Player" && !IsInteraction)
            EnableInteraction();
        else if(Input.GetKeyDown(KeyCode.F) && other.tag == "Player" && IsInteraction)
            DisableInteraction();
    }

    void EnableInteraction()
    {
        dialogue.SetActive(true);
        IsInteraction = true;
        animator.SetBool(open, IsInteraction);
    }

    void DisableInteraction()
    {
        IsInteraction = false;
        dialogue.SetActive(false);
    }
}
