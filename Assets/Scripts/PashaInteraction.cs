using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PashaInteraction : MonoBehaviour
{
    [SerializeField] GameObject dialogue;
    [SerializeField] private CameraFollow playerCamera;
    public Transform dialoguetarget;
    public float camTransitionSpeed;

    Vector3 defCamOffset;
    Vector3 defCamPos;
    Quaternion defCamRot;

    public bool isDialogue = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isDialogue == false)
            isDialogue = true;
        else if (Input.GetKeyDown(KeyCode.F) && isDialogue == true)
            isDialogue = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        defCamOffset = playerCamera.offset;
        defCamPos = playerCamera.transform.position;
        defCamRot = playerCamera.transform.rotation;
    }

    private void OnTriggerExit(Collider other)
    {
        if(playerCamera.transform.rotation != defCamRot)
        {
            dialogue.SetActive(false);
            playerCamera.offset = new Vector3(defCamOffset.x, defCamOffset.y, defCamOffset.z);
            playerCamera.transform.position = Vector3.Slerp(defCamPos, playerCamera.transform.position, 2f);
            playerCamera.transform.rotation = Quaternion.Slerp(playerCamera.transform.rotation, defCamRot, camTransitionSpeed * Time.deltaTime);
        }
        isDialogue = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (isDialogue  && other.tag == "Player" && playerCamera.transform.rotation != dialoguetarget.rotation)
        {
            playerCamera.offset = new Vector3(-2f, 0f, 0f);
            playerCamera.transform.position = Vector3.Slerp(dialoguetarget.position, playerCamera.transform.position, 2f);
            playerCamera.transform.rotation = Quaternion.Slerp(playerCamera.transform.rotation, dialoguetarget.rotation, camTransitionSpeed * Time.deltaTime);

            dialogue.SetActive(true);
        }

        if (!isDialogue && other.tag == "Player" && playerCamera.transform.rotation != defCamRot)
        {
            dialogue.SetActive(false);
            playerCamera.offset = new Vector3(defCamOffset.x, defCamOffset.y, defCamOffset.z);
            playerCamera.transform.position = Vector3.Slerp(defCamPos, playerCamera.transform.position, 2f);
            playerCamera.transform.rotation = Quaternion.Slerp(playerCamera.transform.rotation, defCamRot, camTransitionSpeed * Time.deltaTime);
        }

        
    }
}
