using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public Transform player;

    void OnTriggerEnter(Collider other)
    {
        player.GetComponent<CharacterController>().enabled = false;
        Debug.Log("Triggered");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        player.GetComponent<CharacterController>().enabled = true;
    }
}
