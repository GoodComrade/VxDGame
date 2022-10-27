using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelTransition : MonoBehaviour
{
    [SerializeField] private string targetScene;
    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.F) && other.tag == "Player")
        {
            SceneManager.LoadScene(targetScene);
        }
    }
}
